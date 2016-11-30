using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mensajeria.BO;
using Mensajeria.Service;
using Mensajeria.GUI;
using MetroFramework;

namespace Mensajeria
{
    public partial class Entrada : Form
    {
        CtrlAlumnos servicio = new CtrlAlumnos();
        
        public Entrada()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Alumnos usuario = new Alumnos();
            usuario.Contra = txtContraseña.Text;
            usuario.Usuario = txtUsuario.Text;

            data.DataSource = servicio.ValidarEntrada(usuario);
            if ( data.RowCount > 1)
            { 
                int id = Convert.ToInt32(data.Rows[0].Cells[0].Value.ToString());
                frmMenu frm = new frmMenu(id);
                this.Hide();
                frm.Show();
            }
            else
            {
                MetroMessageBox.Show(this, "Error, Contraseña y/o usario incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Entrada_Load(object sender, EventArgs e)
        {

        }
    }
}
