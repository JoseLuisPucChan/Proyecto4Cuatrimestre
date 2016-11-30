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
using Newtonsoft.Json;
using System.IO;
namespace Practica2
{
    public partial class Principal : MetroForm
    {
        //-----------------------------Variables----------------------------
        DataTable dsReporte;

        //-----------------------------Constructor---------------------------
        public Principal()
        {
            InitializeComponent();
        }
        //--------------------------------Eventos---------------------------
        private void Principal_Load(object sender, EventArgs e)
        {
            dgListado.DataSource = this.Listar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgListado.DataSource = this.Buscar(txtNombre.Text.Trim(), txtISBN.Text.Trim());
           
            dsReporte = this.Buscar(txtNombre.Text.Trim(), txtISBN.Text.Trim());
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            GUI.Editar frmEditar = new GUI.Editar();
            frmEditar.ShowDialog();
            dgListado.DataSource = this.Listar();
        }

        private void repositoryItemButtonEdit1_Click(object sender, EventArgs e)
        {
            string id = gridView1.GetFocusedRowCellValue("ISBN").ToString();            
            GUI.Editar frmEditar = new GUI.Editar(this.Buscar("", id));
            frmEditar.ShowDialog();
            dgListado.DataSource = this.Listar();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            GUI.rpt rpt = new GUI.rpt(dsReporte);
            rpt.ShowDialog();
        }

        //-------------------------------Metodos----------------------------


        //-------------Listar------------
        private DataTable Listar()
        {
            
            
                DataSet dsBibliografia = new DataSet();
                string Rutacompleta = Application.StartupPath.ToString();
                string ruta = Rutacompleta.Substring(0, Rutacompleta.Length - 5) + @"\JSONBibliografia.json";
                dsBibliografia = JsonConvert.DeserializeObject<DataSet>(File.ReadAllText(ruta));
            if (dsBibliografia == null)
            {
                MessageBox.Show("No Existen datos");
                return null;
              
            }
            else
            {
                return dsBibliografia.Tables[0];
            }
                                      
        }


        //-------------Buscar------------
        private DataTable Buscar(string Nombre, string isbn)
        {
            DataTable dsBibliografia = new DataTable();
            DataTable dsTemporal = new DataTable();
            dsBibliografia = this.Listar();
            try
            {
                dsTemporal = this.Listar();
                dsTemporal.Clear();
            }
            catch
            {

            }
           

            if (Nombre.Trim().Length > 0 || isbn.Trim().Length > 0)
            {
                foreach (DataRow r in dsBibliografia.Rows)
                {
                    if (r["Nombre"].ToString() == Nombre || r["ISBN"].ToString() == isbn)
                    {
                        dsTemporal.ImportRow(r);
                    }
                }
            }
            else
            {
                dsTemporal = this.Listar();
            }

            return dsTemporal;
        }

       
        //-------------Limpiar------------
        private void Limpiar()
        {
            foreach (Control c in this.Controls)
            {
                if (c is MetroFramework.Controls.MetroTextBox)
                {
                    c.Text = string.Empty;
                }
            }
        }

       
    }
}
