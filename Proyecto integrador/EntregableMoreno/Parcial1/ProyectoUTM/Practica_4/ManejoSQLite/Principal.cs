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
    public partial class Principal : MetroForm
    {
        DataTable dsReporte;
        string ruta;

        public string Ruta
        {
            get
            {
                return ruta;
            }

            set
            {
                ruta = value;
            }
        }

        //-------------------Constructor-------------------
        public Principal()
        {
            InitializeComponent();
        }

        //--------------------Eventos------------------------

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Services.Libro oLibro = new Services.Libro();
            BO.Libro oLibroBO = new BO.Libro();
            if (txtISBN.Text.Trim().Length > 0)
            {
                oLibroBO.Isbn = txtISBN.Text.Trim();
            }

            if (txtAutor.Text.Trim().Length > 0)
            {
                oLibroBO.Autor = txtAutor.Text.Trim();
            }

            if (txtEditorial.Text.Trim().Length > 0)
            {
                oLibroBO.Editorial = txtEditorial.Text.Trim();
            }

            if (txtNombre.Text.Trim().Length > 0)
            {
                oLibroBO.Titulo = txtNombre.Text.Trim();
            }

            if (txtPrecio.Text.Trim().Length > 0)
            {
                oLibroBO.Precio = Convert.ToDecimal( txtISBN.Text.Trim());
            }

          
            dgListado.DataSource = oLibro.ListarLibro(oLibroBO).Tables[0];
            dsReporte = oLibro.ListarLibro(oLibroBO).Tables[0];
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            ManejoSQLite.Editar frmEditar = new ManejoSQLite.Editar();
            frmEditar.ShowDialog();
        }

        private void repositoryItemButtonEdit1_Click(object sender, EventArgs e)
        {
            BO.Libro olibroBO = new BO.Libro();
            string id = gridView1.GetFocusedRowCellValue("ISBN").ToString();
            olibroBO.Isbn = id;
            Editar frmEditar = new Editar(olibroBO);
            frmEditar.ShowDialog();
            this.Ruta = frmEditar.Ruta;
           // dgListado.DataSource = this.Listar();
        }

        

        private void btnImprimir_Click_1(object sender, EventArgs e)
        {
            rpt rpt = new rpt(dsReporte);
            rpt.ShowDialog();
        }

        private void dgListado_Click(object sender, EventArgs e)
        {

        }



        //---------------------Metodos------------------------



    }
}
