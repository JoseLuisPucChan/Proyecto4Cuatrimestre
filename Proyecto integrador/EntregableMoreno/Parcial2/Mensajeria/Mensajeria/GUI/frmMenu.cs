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

namespace Mensajeria.GUI
{
    public partial class frmMenu : MetroForm
    {
        private Form activado = null;
        int id;
        public frmMenu(int ID)
        {
            InitializeComponent();
            id = ID;
        }

        private void Nuevo_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Nuevo frm = new Nuevo();
            AbrirForm(frm);
        }
        public void AbrirForm(Form ofrm)
        {
            ofrm.TopLevel = false;
            ofrm.Location = new Point(0, 20);
            ofrm.Size = new Size(splitContainer1.Panel2.Width + 15, (splitContainer1.Panel2.Height) + 30);
            ofrm.FormBorderStyle = FormBorderStyle.None;
            splitContainer1.Panel2.Controls.Add(ofrm);
            if (activado != null)
            {
                splitContainer1.Panel2.Controls.Remove(activado);
                activado = ofrm;
            }
           
            activado = ofrm;
            ofrm.BackColor = Color.White;
            ofrm.Show();
        }

        private void navBarItem2_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmabcAlumnos frm = new frmabcAlumnos();
            AbrirForm(frm);
        }

        private void Recibidos_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmMensajesRecibidos frm = new frmMensajesRecibidos(id);
            AbrirForm(frm);
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            if(id != 1)
            {
                navBarGroup1.Visible = false;
            }
        }

        private void navBarItem3_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            this.Hide();
            Entrada frm = new Entrada();
            frm.Show();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void nbc1_Click(object sender, EventArgs e)
        {

        }
    }
}
