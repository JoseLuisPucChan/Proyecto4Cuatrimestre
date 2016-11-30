using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mensajeria.Service;
using Mensajeria.BO;

namespace Mensajeria.GUI
{
    public partial class frmMensajesRecibidos : Form
    {
        CtrlMensajes servicio = new CtrlMensajes();
        Alumnos alumno = new Alumnos();
        int id = 0;
        public frmMensajesRecibidos(int ID)
        {
            InitializeComponent();
            id = ID;
        }

        private void frmMensajesRecibidos_Load(object sender, EventArgs e)
        {
            alumno.Matricula = id.ToString();
            try
            {
                dtgMensajes.DataSource = servicio.RegresarMensajes(alumno);
                pic1.Visible = false;
                dtgMensajes.Visible = true;
                dtgMensajes.Columns[0].Visible = false;
                dtgMensajes.Columns[1].Visible = false;
                dtgMensajes.Columns[2].HeaderText = "Mensajes";
                dtgMensajes.Columns[3].Visible = false;
                grbMensaje.Visible = false;



            }
            catch {
                pic1.Visible = true;
                dtgMensajes.Visible = false;
                }
        }

        private void dtgMensajes_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int posicionFila;
            if (e.RowIndex < 0)
            {
                posicionFila = 0;
            }
            else
            {
                posicionFila = e.RowIndex;
            }
            grbMensaje.Text = "De: " + dtgMensajes.Rows[posicionFila].Cells[2].Value.ToString();
            lblAsunto.Text = "Asunto: " + dtgMensajes.Rows[posicionFila].Cells[3].Value.ToString();
            lblMensaje.Text = "Mensaje: \n \n" + dtgMensajes.Rows[posicionFila].Cells[1].Value.ToString();
            grbMensaje.Visible = true;
        }
    }
}
