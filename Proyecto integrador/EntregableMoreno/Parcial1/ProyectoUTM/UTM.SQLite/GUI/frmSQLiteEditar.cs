using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UTM.SQLite.BO;
using UTM.SQLite.Service;
namespace UTM.SQLite.GUI
{
    public partial class frmSQLiteEditar : Form
    {
        public frmSQLiteEditar()
        {
            InitializeComponent();
        }
        public frmSQLiteEditar(string operacion, AlumnoBO oAlumno)
        {
            InitializeComponent();
            if(operacion=="Nuevo")
            {
                limpiar();
                btnEliminar.Visible = false;
                btnModificar.Visible = false;
            }
            else if (operacion == "Edicion")
            {
                btnGuardar.Visible = false;
                btnGuardarSeguir.Visible = false;
                this.buscar(oAlumno);
            }

           

        }

        public void buscar(AlumnoBO oAlumno) 
        {
            //AlumnoBO oAlumnoBO = new AlumnoBO();
            AlumnoCtrl oAlumnoCtrl = new AlumnoCtrl();
            DataTable dt = oAlumnoCtrl.devuelveAlumno(oAlumno).Tables[0];
            if (dt.Rows.Count != 0)
            {
                txtAM.Text = dt.Rows[0]["ApellidoMaterno"].ToString();
                txtAP.Text = dt.Rows[0]["ApellidoPaterno"].ToString();
                txtDireccion.Text = dt.Rows[0]["Direccion"].ToString();
                txtGrado.Text = dt.Rows[0]["Grado"].ToString();
                txtGrupo.Text = dt.Rows[0]["Grupo"].ToString();
                txtMatricula.Text = dt.Rows[0]["Matricula"].ToString();
                txtNombre.Text = dt.Rows[0]["Nombre"].ToString();
                txtTelefono.Text = dt.Rows[0]["Telefono"].ToString();
            }
            else 
            {
                this.Close();
            }
        }
        public void limpiar() 
        {
            txtAM.Clear();
            txtAP.Clear();
            txtDireccion.Clear();
            txtGrado.Clear();
            txtGrupo.Clear();
            txtMatricula.Clear();
            txtNombre.Clear();
            txtTelefono.Clear();
        }
        public void agregar()
        {
            string mensaje = "";
            if (txtNombre.Text.Trim().Length == 0)
            {
                mensaje = mensaje + "Introduce el Nombre \n";
            }
            if (txtAM.Text.Trim().Length == 0)
            {
                mensaje = mensaje + "Introduce el Apellido Materno \n";
            }
            if (txtAP.Text.Trim().Length == 0)
            {
                mensaje = mensaje + "Introduce el Apellido Paterno \n";
            }
            if (txtDireccion.Text.Trim().Length == 0)
            {
                mensaje = mensaje + "Introduce la Dirección \n";
            }
            if (txtTelefono.Text.Trim().Length == 0)
            {
                mensaje = mensaje + "Introduce el Teléfono \n";
            }
            if (txtGrado.Text.Trim().Length == 0)
            {
                mensaje = mensaje + "Introduce el Grado \n";
            }
            if (txtGrupo.Text.Trim().Length == 0)
            {
                mensaje = mensaje + "Introduce el Grupo \n";
            }
            
            if (mensaje.Trim().Length == 0)
            {
                AlumnoBO oAlumnoBO = new AlumnoBO();
                AlumnoCtrl oAlumnoCtrl = new AlumnoCtrl();
                oAlumnoBO.Nombre = txtNombre.Text.Trim();
                oAlumnoBO.Apellidopaterno = txtAP.Text.Trim();
                oAlumnoBO.Apellidomaterno = txtAM.Text.Trim();
                oAlumnoBO.Direccion = txtDireccion.Text.Trim();
                oAlumnoBO.Telefono = txtTelefono.Text.Trim();
                oAlumnoBO.Grado = Convert.ToInt32(txtGrado.Text.Trim());
                oAlumnoBO.Grupo = txtGrupo.Text.Trim();
                oAlumnoCtrl.creaAlumno(oAlumnoBO);
                MessageBox.Show("El alumno se guardo correctamete");
            }
            else 
            {
                MessageBox.Show("Favor de ingresar los siguientes datos:\n"+mensaje);
            }
           
      
        }
        public void modificar()
        {
            string mensaje = "";
            if (txtNombre.Text.Trim().Length == 0)
            {
                mensaje = mensaje + "Introduce el Nombre \n";
            }
            if (txtAM.Text.Trim().Length == 0)
            {
                mensaje = mensaje + "Introduce el Apellido Materno \n";
            }
            if (txtAP.Text.Trim().Length == 0)
            {
                mensaje = mensaje + "Introduce el Apellido Paterno \n";
            }
            if (txtDireccion.Text.Trim().Length == 0)
            {
                mensaje = mensaje + "Introduce la Dirección \n";
            }
            if (txtTelefono.Text.Trim().Length == 0)
            {
                mensaje = mensaje + "Introduce el Teléfono \n";
            }
            if (txtGrado.Text.Trim().Length == 0)
            {
                mensaje = mensaje + "Introduce el Grado \n";
            }
            if (txtGrupo.Text.Trim().Length == 0)
            {
                mensaje = mensaje + "Introduce el Grupo \n";
            }

            if (mensaje.Trim().Length == 0)
            {
                AlumnoBO oAlumnoBO = new AlumnoBO();
                AlumnoCtrl oAlumnoCtrl = new AlumnoCtrl();
                oAlumnoBO.Matricula = Convert.ToInt32(txtMatricula.Text.Trim());
                oAlumnoBO.Nombre = txtNombre.Text.Trim();
                oAlumnoBO.Apellidopaterno = txtAP.Text.Trim();
                oAlumnoBO.Apellidomaterno = txtAM.Text.Trim();
                oAlumnoBO.Direccion = txtDireccion.Text.Trim();
                oAlumnoBO.Telefono = txtTelefono.Text.Trim();
                oAlumnoBO.Grado = Convert.ToInt32(txtGrado.Text.Trim());
                oAlumnoBO.Grupo = txtGrupo.Text.Trim();
                oAlumnoCtrl.modificaAlumno(oAlumnoBO);
                MessageBox.Show("El alumno se modifico correctamete");
            }
            else
            {
                MessageBox.Show("Favor de ingresar los siguientes datos:\n" + mensaje);
            }


        }
        public void eliminar() 
        {
            AlumnoBO oAlumnoBO = new AlumnoBO();
            AlumnoCtrl oAlumnoCtrl = new AlumnoCtrl();
            oAlumnoBO.Matricula = Convert.ToInt32(txtMatricula.Text.Trim());
            int i=oAlumnoCtrl.eliminaAlumno(oAlumnoBO);
            if (i == 1)
            {
                MessageBox.Show("Los datos se eliminaron correctamente");
            }
            else 
            {
                MessageBox.Show("Los datos no se eliminaron, intenta de nuevo");
            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            agregar();
            this.Close();
        }

        private void frmSQLiteEditar_Load(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btnGuardarSeguir_Click(object sender, EventArgs e)
        {
            agregar();
            limpiar();

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            modificar();
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            eliminar();
            this.Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        ~frmSQLiteEditar() 
        { 
        }
    }
}
