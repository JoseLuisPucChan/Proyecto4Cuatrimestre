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

namespace ManejoSQLite
{
    public partial class Editar : MetroForm
    {
        //-------------------Variables--------------------
        OpenFileDialog open;
        public string Ruta;

        //-------------------Constructor-------------------

        public Editar()
        {
            InitializeComponent();
            btnEliminar.Visible = false;
            btnModificar.Visible = false;
        }
            //---Sobrecarga constructor---
        public Editar(BO.Libro dt)
        {
            InitializeComponent();
            this.Edit(dt);
            btnGuardar.Visible = false;

            btnModificar.Location = new Point(260, 87);
            btnEliminar.Location = new Point(260, 134);
        }
        //--------------------Eventos------------------------

        private void Editar_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this.Insertar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            this.Eliminar();
        }

        private void btnBuscarIMG_Click(object sender, EventArgs e)
        {
            open = new OpenFileDialog();
            open.ShowDialog();
            pbImagen.Image = Image.FromFile(open.FileName);
            Ruta = open.FileName;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            this.Modificar();
        }
        //---------------------Metodos------------------------

        //-------cargarLibro-----
        private void Edit(BO.Libro obj)
        {
            Services.Libro oLibro = new Services.Libro();
            DataTable dt =  oLibro.ListarLibro(obj).Tables[0];

            if (dt.Rows.Count != 0)
            {
                txtAutor.Text = dt.Rows[0]["Autor"].ToString();
                txtEditorial.Text = dt.Rows[0]["Editorial"].ToString();
                txtISBN.Text = dt.Rows[0]["ISBN"].ToString();
                txtNombre.Text = dt.Rows[0]["Titulo"].ToString();
                txtPrecio.Text = dt.Rows[0]["Precio"].ToString();
                this.cargar(dt.Rows[0]["Imgen"].ToString());
            }
        }
            //-----insertar----
        private void Insertar()
        {
            BO.Libro oLibroBO = new BO.Libro();
            Services.Libro oLibroCTRL = new Services.Libro();
            bool opc = false;
            if (txtAutor.Text.Trim().Length == 0)
            {
                opc = true;
            }
            if (txtISBN.Text.Trim().Length == 0)
            {
                opc = true;
            }

            if (txtEditorial.Text.Trim().Length == 0)
            {
                opc = true;
            }

            if (txtNombre.Text.Trim().Length == 0)
            {
                opc = true;
            }

            if (txtPrecio.Text.Trim().Length == 0)
            {
                opc = true;
            }

            if (opc == false)
            {
                oLibroBO.Isbn = txtISBN.Text.Trim();
                oLibroBO.Autor = txtAutor.Text.Trim();
                oLibroBO.Editorial = txtEditorial.Text.Trim();
                oLibroBO.Precio = Convert.ToDecimal(txtPrecio.Text.Trim());
                oLibroBO.Titulo = txtNombre.Text.Trim();
                oLibroBO.Imagen = this.GuardarImagen();        
                int i = oLibroCTRL.creaLibro(oLibroBO);
                if (i > 0)
                {
                    MessageBox.Show("EL Libro ha sido creado con exito ");
                    this.Close();
                }     
            }
            else
            {
                MessageBox.Show("por fávor llénar todos los campos");
            }

        }// ---- fin insertar

        //----- Eliminar--------
        private void Eliminar()
        {
            BO.Libro oLiroBO = new BO.Libro();
            Services.Libro oLibroCtrl = new Services.Libro();
            oLiroBO.Isbn = txtISBN.Text.Trim();
            int i = oLibroCtrl.eliminaLibro(oLiroBO);
            if (i == 1)
            {
                MessageBox.Show("Los dátos se eliminaron correctamente");
            }
            else
            {
                MessageBox.Show("Los datos no se eliminaron, intenta de nuevo");
            }

        }

        //--------modificar----------
        private void Modificar()
        {
            BO.Libro oLibroBO = new BO.Libro();
            Services.Libro oLibroCTRL = new Services.Libro();
            bool opc = false;
            if (txtAutor.Text.Trim().Length == 0)
            {
                opc = true;
            }
            if (txtISBN.Text.Trim().Length == 0)
            {
                opc = true;
            }

            if (txtEditorial.Text.Trim().Length == 0)
            {
                opc = true;
            }

            if (txtNombre.Text.Trim().Length == 0)
            {
                opc = true;
            }

            if (txtPrecio.Text.Trim().Length == 0)
            {
                opc = true;
            }

            if (opc == false)
            {
                oLibroBO.Isbn = txtISBN.Text.Trim();
                oLibroBO.Autor = txtAutor.Text.Trim();
                oLibroBO.Editorial = txtEditorial.Text.Trim();
                oLibroBO.Precio = Convert.ToDecimal(txtPrecio.Text.Trim());
                oLibroBO.Titulo = txtNombre.Text.Trim();
                oLibroBO.Imagen = pbImagen.ImageLocation;      
                int i = oLibroCTRL.modificaLibro(oLibroBO);
                if (i > 0)
                {
                    MessageBox.Show("EL Libro ha sido modificado con exito ");
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("por fávor llénar todos los campos");
            }
        }      

       private string GuardarImagen()
        {            
            string retorno = open.FileName;
            return retorno;        
        }

        private void cargar(string ruta)
        {
            pbImagen.Image = Image.FromFile(ruta);
        }
    }
}
