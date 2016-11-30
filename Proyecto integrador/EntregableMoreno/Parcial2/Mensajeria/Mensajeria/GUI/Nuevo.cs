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
    public partial class Nuevo : Form
    {
        CtrlMensajes Servicios = new CtrlMensajes();
        Mensajes mensaje = new Mensajes();
        Alumnos alumno = new Alumnos();
        string mensajeEnvio = "";
        bool enviar = false;
        string Id = "";
        public Nuevo()
        {
            InitializeComponent();
          
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (txtMensaje.Text.Trim().Length > 0)
            {
                mensaje.Mensaje = txtMensaje.Text;
                enviar = true;
            }
            else { mensajeEnvio += " \n Campo de mensaje vacío";
                enviar = false;
            }

            if (txtPara.Text.Trim().Length > 0)
            {
                mensaje.Destinatario = txtDe.Text;
                enviar = true;
            }
            else { mensajeEnvio += " \n Campo de Destinatario vacío";
                enviar = false;
            }

            if (txtAsunto.Text.Trim().Length > 0)
            {
                mensaje.Asunto = txtAsunto.Text;
            }
            else { mensajeEnvio += " \n Campo de Asunto vacío";
                txtAsunto.Text = "< Sin asunto >";
            }
            alumno.Matricula = Id;
            if (enviar == true)
            {
                int i = Servicios.EnviarMensaje(mensaje, alumno);
                if (i < 0)
                {
                    MessageBox.Show("Ocurrio un error");
                }
                else
                {
                    MessageBox.Show("mensaje Enviado");
                    Limpiar();
                }
            }
            else
            {
                MessageBox.Show("Campos faltantes: " + mensajeEnvio);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Limpiar()
        {
            txtAsunto.Clear();
            txtDe.Clear();
            txtMensaje.Clear();
            txtPara.Clear();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                frmabcAlumnos frm = new frmabcAlumnos();
                frm.VolverFormBusqueda();
                frm.usando = true;
                frm.ShowDialog();
                Id = frm.ID.Text;
                this.txtPara.Text = frm.Usuario.Text;
            }
            catch { }
            
        }

        private void Nuevo_Load(object sender, EventArgs e)
        {

        }
    }
}
