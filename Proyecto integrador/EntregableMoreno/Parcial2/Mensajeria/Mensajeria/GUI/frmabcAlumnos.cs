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
using MetroFramework;

namespace Mensajeria.GUI
{
    public partial class frmabcAlumnos : Form
    {
        CtrlAlumnos servicio = new CtrlAlumnos();
        Alumnos alumno = new Alumnos();
        int indice = 0;
        public bool usando { get; set; }
        public MetroFramework.Controls.MetroTextBox ID { get; set; }
        public MetroFramework.Controls.MetroTextBox Usuario { get; set; }


        public frmabcAlumnos()
        {
            InitializeComponent();
        }

        private void frmabcAlumnos_Load(object sender, EventArgs e)
        {
            llenarDtg();
      
        }

        private Alumnos LlenarAlumno()
        {

            if (txtID.Text.Trim().Length > 0)
            {
                alumno.Matricula = txtID.Text;
            }
            else { alumno.Matricula = "0"; }
            if (txtNombre.Text.Trim().Length > 0)
            {
                alumno.Nombre = txtNombre.Text;
            }
            //else { alumno.Nombre = "0"; }
            if (txtsemestre.Text.Trim().Length > 0 )
            {
                if (EsNumero(txtsemestre.Text) == true)
                {
                    alumno.Semestre = int.Parse(txtsemestre.Text);
                }
                else {
                    MessageBox.Show("solo se permiten números");
                }
            }
            else
            { alumno.Semestre = 0;
            }
            if (txtUsuario.Text.Trim().Length > 0)
            {
                alumno.Usuario = txtUsuario.Text;
            }
            //else
            //{
            //    alumno.Usuario = "0";
            //}
            if (txtContrasena.Text.Trim().Length > 0)
            {
                alumno.Contra = txtContrasena.Text;
            }
            return alumno;
        }

        public bool EsNumero(string s)
        {
            foreach (char c in s)
            {
                if (!char.IsDigit(c) && c != '.')
                {
                    return false;
                }
            }

            return true;
        }


        private void llenarDtg()
        {
            dtgAlumno.DataSource = servicio.Recuperar();
            dtgAlumno.Columns[4].Visible = false;
        }
        private void btnAgrego_Click(object sender, EventArgs e)
        {
            LlenarAlumno();
            int i = servicio.Agregar(alumno);
            llenarDtg();
            if(i < 0)
            { MessageBox.Show("Ocurrio un error"); }
            else
            {
                MessageBox.Show("Alumno agregado");
            }
        }

        private void btmodificar_Click(object sender, EventArgs e)
        {
            LlenarAlumno();
            if (servicio.modificar(alumno) < 0)
            {
                MessageBox.Show("Ocurrio un error");
            }
            else
            {
                MessageBox.Show("Modificación con éxito");
            }
            llenarDtg();
        }

        private void dtgAlumno_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           
        }

        private void Limpiar()
        {
            txtID.Clear();
            txtContrasena.Clear();
            txtNombre.Clear();
            txtsemestre.Clear();
            txtUsuario.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            LlenarAlumno();
            
           if (MessageBox.Show("Confirmar Eliminación" , "" , MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (servicio.Eliminar(alumno) < 0)
                {
                    MessageBox.Show("Ocurrio un error");
                }
                else
                {
                    MessageBox.Show("Eliminado con éxito");
                }
            }
            llenarDtg();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            LlenarAlumno();
            dtgAlumno.DataSource = servicio.Buscar(alumno);
            dtgAlumno.Columns[4].Visible = false;
            alumno = new Alumnos();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnlistar_Click(object sender, EventArgs e)
        {
            llenarDtg(); 
        }

        public void VolverFormBusqueda()
        {
            btnAgrego.Visible = false;
            btnEliminar.Visible = false;
            btmodificar.Visible = false;
            txtContrasena.Visible = false;
            label4.Visible = false;
            btnBuscar.Location = btnAgrego.Location;
            btnLimpiar.Location = btmodificar.Location;
            btnlistar.Location = btnEliminar.Location;
        }

        private void dtgAlumno_CellMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
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

            try
            {
                indice = int.Parse(dtgAlumno.Rows[posicionFila].Cells[0].Value.ToString());
                txtID.Text = dtgAlumno.Rows[posicionFila].Cells[0].Value.ToString();
                txtNombre.Text = dtgAlumno.Rows[posicionFila].Cells[1].Value.ToString();
                txtsemestre.Text = dtgAlumno.Rows[posicionFila].Cells[2].Value.ToString();
                txtUsuario.Text = dtgAlumno.Rows[posicionFila].Cells[3].Value.ToString();
                txtContrasena.Text = dtgAlumno.Rows[posicionFila].Cells[4].Value.ToString();
                ID = txtID;
                Usuario = txtUsuario;
            }
            catch
            {

            }
       
            if (usando == true)
            {
                this.Hide();
            }

        }
    }
}
