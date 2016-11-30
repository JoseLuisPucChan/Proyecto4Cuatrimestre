using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AgendaContactos
{
    public partial class EditarPersona : Form
    {

        public EditarPersona()
        {
            InitializeComponent();
        }

        public EditarPersona(DataTable dt)
        {
            InitializeComponent();
            txtid.Text = dt.Rows[0]["ID"].ToString();
            txtnombre.Text = dt.Rows[0]["Nombre"].ToString();
            txtap.Text = dt.Rows[0]["AP"].ToString();
            txtam.Text = dt.Rows[0]["AM"].ToString();
            txtedad.Text = dt.Rows[0]["Edad"].ToString();
            txttelefono.Text = dt.Rows[0]["Telefono"].ToString();
            txtln.Text = dt.Rows[0]["LugarNacimiento"].ToString();
            txtfn.Text = dt.Rows[0]["FechaNacimiento"].ToString();
            pictureBox1.Image = this.recuperarimagen(dt.Rows[0]["imagen"].ToString());
        }

        public DataTable listarPersonas()
        {
            DataSet dsPersona = new DataSet();
            string rutacompleta = Application.StartupPath.ToString();
            string ruta = rutacompleta.Substring(0, rutacompleta.Length - 5) + @"\XMLAgenda.xml";
            dsPersona.ReadXml(ruta);
            return dsPersona.Tables[0];
        }

        public void agregarPersona()
        {
            DataSet dsPersona = new DataSet();
            dsPersona.Tables.Add(listarPersonas().Copy());
            DataRow dr;
            try
            {
                dr = dsPersona.Tables[0].NewRow();
                dr["ID"] = txtid.Text.Trim();
                dr["Nombre"] = txtnombre.Text.Trim();
                dr["AP"] = txtap.Text.Trim();
                dr["AM"] = txtam.Text.Trim();
                dr["Edad"] = txtedad.Text.Trim();
                dr["Telefono"] = txttelefono.Text.Trim();
                dr["LugarNacimiento"] = txtln.Text.Trim();
                dr["FechaNacimiento"] = txtfn.Text.Trim();
                dr["Imagen"] = convertirimagenstring();
                dsPersona.Tables[0].Rows.Add(dr);
                string rutacompleta = Application.StartupPath.ToString();
                string ruta = rutacompleta.Substring(0, rutacompleta.Length - 5) + @"\XMLAgenda.xml";
                dsPersona.WriteXml(ruta);
                listarPersonas();
                MessageBox.Show("¡Los datos se guardaron correctamente!");
            }
            catch
            {
                MessageBox.Show("¡Favor de verificar los datos!");
            }
        }

        public void modificarPersona()
        {
            string ID = txtid.Text.Trim();
            DataTable dt = listarPersonas();
            int n = dt.Rows.Count;
            try
            {
            for (int i = 0; i < n; i++)
            {
                if (dt.Rows[i]["ID"].ToString().Trim() == ID.Trim())
                {

                    dt.Rows[i]["Nombre"] = txtnombre.Text.Trim();
                    dt.Rows[i]["AP"] = txtap.Text.Trim();
                    dt.Rows[i]["AM"] = txtam.Text.Trim();
                    dt.Rows[i]["Edad"] = txtedad.Text.Trim();
                    dt.Rows[i]["Telefono"] = txttelefono.Text.Trim();
                    dt.Rows[i]["LugarNacimiento"] = txtln.Text.Trim();
                    dt.Rows[i]["FechaNacimiento"] = txtfn.Text.Trim();
                    dt.Rows[i]["Imagen"] = this.convertirimagenstring();

                    string rutacompleta = Application.StartupPath.ToString();
                    string ruta = rutacompleta.Substring(0, rutacompleta.Length - 5) + @"\XMLAgenda.xml";
                    dt.WriteXml(ruta);
                    break;
                }
            }
            MessageBox.Show("¡Los datos de guardaron exitosamente!");
           }
           catch
           {
               MessageBox.Show("A ocurrido un error \n ¡Por favor verifique los datos!");
           }
        }

        public void eliminarPersona()
        {
            string ID = txtid.Text.Trim();
            DataTable dt = listarPersonas();
            int n = dt.Rows.Count;
            try
            {
                for (int i = 0; i < n; i++)
                {
                    if (dt.Rows[i]["ID"].ToString().Trim() == ID.Trim()) ;
                    {
                        dt.Rows[i].Delete();

                        string rutacompleta = Application.StartupPath.ToString();
                        string ruta = rutacompleta.Substring(0, rutacompleta.Length - 5) + @"\XMLAgenda.xml";
                        dt.WriteXml(ruta);
                        break;
                    }
                }
                MessageBox.Show("¡Los datos de Eliminaron exitosamente!");
            }
            catch
            {
                MessageBox.Show("¡A ocurrido un error!");
            }
        }

        public string convertirimagenstring()
        {
            MemoryStream ms = new MemoryStream();
                pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] imageBytes = ms.ToArray();

                //convertir imagen a base64
                string Imagen = Convert.ToBase64String(imageBytes);
                return Imagen;
        }

        public Image recuperarimagen(string imagen)
        {
            byte[] imagebytes = Convert.FromBase64String(imagen);
            MemoryStream ms = new MemoryStream(imagebytes, 0, imagebytes.Length);

            //ms.Write(imagebytes, 0, imagebytes.Length);
            Image image = Image.FromStream(ms, true);
            return image;
        }
        
        public void cargarimagen()
        {
            OpenFileDialog open = new OpenFileDialog();
            open.InitialDirectory = @"C:\user\Public\Pictures";
            open.Filter = "JPEG [*.jpeg]|*.jpeg|PNG[*.png]|*.png|JPG [*.jpg] |*.jpg|BMP|*.bmp";

            if (open.ShowDialog() == DialogResult.OK)
            {
                string rutainicio = open.FileName;
                string nombreimg = Path.GetFileNameWithoutExtension(rutainicio);
                pictureBox1.Image = Image.FromFile(rutainicio);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtid.Clear();
            txtnombre.Clear();
            txtap.Clear();
            txtam.Clear();
            txtedad.Clear();
            txtln.Clear();
            txtfn.Clear();
            txttelefono.Clear();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            agregarPersona();
            this.Close();
        }

        private void btnGuardarSeguir_Click(object sender, EventArgs e)
        {
            agregarPersona();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            modificarPersona();
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            eliminarPersona();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnabririmagen_Click(object sender, EventArgs e)
        {
            cargarimagen();
        }
    }
}
