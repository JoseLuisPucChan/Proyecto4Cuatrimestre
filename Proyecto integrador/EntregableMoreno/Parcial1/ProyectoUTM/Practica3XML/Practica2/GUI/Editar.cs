using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.IO;

namespace Practica2.GUI
{
    public partial class Editar : MetroForm
    {

        //----------------------------Constructor------------------------
        public Editar()
        {
            InitializeComponent();

            btnEliminar.Visible = false;
            btnModificar.Visible = false;
        }
        public Editar(DataTable dt)
        {
            InitializeComponent();
            this.Modificar(dt);
            btnGuardar.Visible = false;

            btnModificar.Location = new Point(260, 87);
            btnEliminar.Location = new Point(260, 134);
        }

        //----------------------------Eventos----------------------------

        private void Editar_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this.Guardar();
            this.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            this.ActualizarDatos();
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            this.Eliminar();
            this.Close();
        }
        private void btnBuscarIMG_Click(object sender, EventArgs e)
        {
            this.CargaImagen();
        }

        //----------------------------Metodos----------------------------

        //---------Listar----------
        private DataTable Listar()
        {
            DataSet dsBibliografia = new DataSet();
            string Rutacompleta = Application.StartupPath.ToString();
            string ruta = Rutacompleta.Substring(0, Rutacompleta.Length - 5) + @"\XMLBibliografia.xml";
            dsBibliografia.Clear();
            dsBibliografia.ReadXml(ruta);

            if (dsBibliografia.Tables.Count == 0)
            {
                
                string Rutacompleta2 = Application.StartupPath.ToString();
                string ruta2 = Rutacompleta2.Substring(0, Rutacompleta2.Length - 5) + @"\XMLBibliografia2.xml";
                dsBibliografia.ReadXml(ruta2);
                
                return dsBibliografia.Tables[0];
            }
            else
            {
                return dsBibliografia.Tables[0];
            }
            

        }

        //---------Guardar----------

        private void Guardar()
        {
            DataSet dsBibliografia = new DataSet();
            dsBibliografia.Tables.Add(this.Listar().Copy());
            DataRow dr;
            try
            {
                dsBibliografia.Tables[0].Rows.Clear();
                dr = dsBibliografia.Tables[0].NewRow();
                dr["ISBN"] = txtISBN.Text.Trim();
                dr["Nombre"] = txtNombre.Text.Trim();
                dr["Autor"] = txtAutor.Text.Trim();
                dr["Editorial"] = txtEditorial.Text.Trim();
                dr["Precio"] = txtPrecio.Text.Trim();
                dr["Imagen"] = GuardarImagen();
                dsBibliografia.Tables[0].Rows.Add(dr);

                string Rutacompleta = Application.StartupPath.ToString();
                string ruta = Rutacompleta.Substring(0, Rutacompleta.Length - 5) + @"\XMLBibliografia.xml";              
                dsBibliografia.WriteXml(ruta);               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        //-------Modificar--------
        private void Modificar (DataTable dtBibliografia)
        {           
            txtAutor.Text = dtBibliografia.Rows[0]["Autor"].ToString();
            txtISBN.Text = dtBibliografia.Rows[0]["ISBN"].ToString();
            txtNombre.Text = dtBibliografia.Rows[0]["Nombre"].ToString();
            txtPrecio.Text = dtBibliografia.Rows[0]["Precio"].ToString();
            txtEditorial.Text = dtBibliografia.Rows[0]["Editorial"].ToString();
            pbImagen.Image = this.AbrirImagen( dtBibliografia.Rows[0]["Imagen"].ToString() );         
        }

        //------ActualizarDatos----

        private void ActualizarDatos()
        {
            DataTable dsBibliografia = new DataTable();
            DataTable dsTemporal = new DataTable();
            dsBibliografia = this.Listar();
     
            
                foreach (DataRow r in dsBibliografia.Rows)
                {
                    if (r["ISBN"].ToString() == txtISBN.Text.Trim())
                    {
                        r["Nombre"] = txtNombre.Text.Trim();
                        r["Precio"] = txtPrecio.Text.Trim();
                        r["Editorial"] = txtEditorial.Text.Trim();
                        r["Autor"] = txtAutor.Text.Trim();
                        r["Imagen"] = this.GuardarImagen();
                    }
                    string Rutacompleta = Application.StartupPath.ToString();
                    string ruta = Rutacompleta.Substring(0, Rutacompleta.Length - 5) + @"\XMLBibliografia.xml";
                    dsBibliografia.WriteXml(ruta);
                }          
        }
        //-------Eliminar--------
        private void Eliminar()
        {
            DataTable dsBibliografia = new DataTable();
            DataTable dsTemporal = new DataTable();
            dsBibliografia = this.Listar();

            int filas = dsBibliografia.Rows.Count;
            for (int i = 0; i < filas; i++)
            {
                if (dsBibliografia.Rows[i]["ISBN"].ToString() == txtISBN.Text.Trim())
                {
                    dsBibliografia.Rows[i].Delete();
                    string Rutacompleta = Application.StartupPath.ToString();
                    string ruta = Rutacompleta.Substring(0, Rutacompleta.Length - 5) + @"\XMLBibliografia.xml";
                    dsBibliografia.WriteXml(ruta);
                    break;
                }
                
            }
        }

        //------CargarImagenALPictureBox------ 
        private void CargaImagen()
        {
            OpenFileDialog open = new OpenFileDialog();
            open.InitialDirectory = @"C:\users\public\pictures";
            open.Filter = "JPG [*.jpg] |*.jpg|JPEG [*.jpeg]|*.jpeg|PNG[*.png]|*.png|BMP|*.bmp";

            if (open.ShowDialog() == DialogResult.OK)
            {
                string ruta = open.FileName;
                pbImagen.Image = Image.FromFile(ruta);
            }

        }

        //------GuardarImagenXML--------
        private string GuardarImagen()
        {
            MemoryStream ms = new MemoryStream();
            pbImagen.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            byte[] imageBytes = ms.ToArray();

            //convierte la imagen a string
            string imagen = Convert.ToBase64String(imageBytes);
            return imagen;
        }

        //-----CargarImagen----------
        private Image AbrirImagen(string imagen)
        {
            //convirte el string en un arreglo de bytes 
            byte[] imageBytes = Convert.FromBase64String(imagen);
            MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);
            Image img = Image.FromStream(ms, true);
            return img;
        }

        
    }
}
