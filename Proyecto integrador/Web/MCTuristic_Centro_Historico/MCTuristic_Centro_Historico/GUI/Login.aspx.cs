using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MCTuristic_Centro_Historico.GUI
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        [WebMethod]
        private void BuscarUsuario()
        {
            DataTable Datos = new DataTable();
            Datos = Services.CtrlAdmin.LoginUsuario(this.txtUsuario.Text.Trim(), this.txtContraseña.Text.Trim());

            if (txtUsuario.Text.Trim() != string.Empty || txtContraseña.Text.Trim() != string.Empty)
            {
                if (Datos.Rows.Count == 0)
                {
                    Mensaje("Usted Notiene acceso al Sistema");
                }
                else
                {
                    Session["idDueño"] = Datos.Rows[0][1].ToString();
                    Server.Transfer("Inicio.aspx");
                    Mensaje("Bienvenido");

                }
            }


        }
        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            if(txtEmail.Text=="josechan211@gmail.com" && txtContraseña.Text=="12345")
            {
                Response.Redirect("GestionUsuariosGUI.aspx");
            }
        }
    }
}