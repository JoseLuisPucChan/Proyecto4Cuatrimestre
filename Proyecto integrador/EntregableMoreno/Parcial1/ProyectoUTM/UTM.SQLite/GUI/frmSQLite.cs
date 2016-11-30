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
    public partial class frmSQLite : Form
    {
        DataSet dsReporte;
        public frmSQLite()
        {
            InitializeComponent();
            //buscar();
        }
        public void buscar()
        {
            AlumnoBO oAlumnoBO = new AlumnoBO();
            AlumnoCtrl oAlumnoCtrl = new AlumnoCtrl();
            if (txtMatricula.Text.Trim().Length != 0)
            {
                oAlumnoBO.Matricula = Convert.ToInt32(txtMatricula.Text.Trim());
            }
            if (txtAP.Text.Trim().Length != 0)
            {
                oAlumnoBO.Apellidopaterno = txtAP.Text.Trim();
            }
            if (txtAM.Text.Trim().Length != 0)
            {
                oAlumnoBO.Apellidomaterno = txtAM.Text.Trim();
            }
            if (txtGrado.Text.Trim().Length != 0)
            {
                oAlumnoBO.Grado = Convert.ToInt32(txtGrado.Text.Trim());
            }
            if (txtGrupo.Text.Trim().Length != 0)
            {
                oAlumnoBO.Grupo = txtGrupo.Text.Trim();
            }
            dsReporte=oAlumnoCtrl.devuelveAlumno(oAlumnoBO);
            dgvAlumno.AutoGenerateColumns = false;
            dgvAlumno.DataSource = dsReporte.Tables[0];
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            buscar();
        }

        private void dgvAlumno_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                if (this.dgvAlumno.Columns[e.ColumnIndex].Name == "editar")
                {
                    AlumnoBO oAlumnoBO = new AlumnoBO();

                    oAlumnoBO.Matricula = Convert.ToInt32( this.dgvAlumno.Rows[e.RowIndex].Cells["Matricula"].Value);
                    frmSQLiteEditar ofrmSQLiteEditar = new frmSQLiteEditar("Edicion", oAlumnoBO);
                    ofrmSQLiteEditar.ShowDialog();
                    dgvAlumno.DataSource = null;
                    
                }
            
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.limpiar();
        }
        public void limpiar() 
        {
            txtAM.Clear();
            txtAP.Clear();
            txtGrado.Clear();
            txtGrupo.Clear();
            txtMatricula.Clear();
            txtNombre.Clear();
        }

        private void toolStripButton4_Click_1(object sender, EventArgs e)
        {
            AlumnoBO oAlumnoBO=new AlumnoBO();
            frmSQLiteEditar ofrmSQLiteEditar = new frmSQLiteEditar("Nuevo", oAlumnoBO);
            ofrmSQLiteEditar.ShowDialog();
            dgvAlumno.DataSource = null;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (dsReporte.Tables[0].Rows.Count != 0)
            {
                ReporteAlumno oReporteAlumno = new ReporteAlumno(dsReporte.Tables[0]);
                oReporteAlumno.ShowDialog();
            }
            else {
                MessageBox.Show("Favor de realizar una busqueda");
            }

           
        }
    }
}
