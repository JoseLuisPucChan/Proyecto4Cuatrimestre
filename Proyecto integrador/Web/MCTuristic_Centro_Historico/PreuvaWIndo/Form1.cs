using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Web.Services;
namespace PreuvaWIndo
{
    public partial class Form1 : Form
    {
        localhost.WsMCTuristic owebService = new localhost.WsMCTuristic(); 
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = owebService.InsertarUsuario(RecuperarInformacion());
            if (i > 0)
            {
                MessageBox.Show("Algo paso");
            }
        }
        private localhost.UsuarioBO RecuperarInformacion()
        {
            localhost.UsuarioBO oUsuariosBO = new localhost.UsuarioBO();
            oUsuariosBO.NombreUsuario = txtNombre.Text.Trim();
            oUsuariosBO.ApellidosUsuario = txtApellido.Text.Trim();
            oUsuariosBO.EmailUsuario = txtCorreo.Text.Trim();
            oUsuariosBO.ContraseñaUsuario =txtContraseña.Text.Trim();
            oUsuariosBO.TelefonoUsuario = txtTelefono.Text.Trim();
            oUsuariosBO.FecharNacUsuario = DateTime.Now;
            return oUsuariosBO;

        }
    }
}
