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
        public static string BuscarUsuario(string email, string contraseña)
        {
            DataTable Datos = new DataTable();
            localhost.WsMCTuristic Services = new localhost.WsMCTuristic();
            localhost.AdministradorBO oAdmin = new localhost.AdministradorBO();
            oAdmin.Email = email;
            oAdmin.Contraseñaadmin = contraseña;
            Datos = Services.Login(oAdmin);
            if (email == "josechan211@gmail.com" && contraseña == "12345")
            {
                Login ologin = new Login();
                //ologin.declararSession(Convert.ToInt32(Datos.Rows[0][1].ToString()));
                ologin.declararSession();
            }
            else
            {
                return "No tiene ecceso al sistema";
            }
            return "";

        }
        private void declararSession()
        {
            Session["idAdmin"] = 2;
            Server.Transfer("GestionUsuariosGUI.aspx");
        }
      
        protected void Button2_Click(object sender, EventArgs e)
        {

            DataTable Datos = new DataTable();
            localhost.WsMCTuristic Services = new localhost.WsMCTuristic();
            localhost.AdministradorBO oAdmin = new localhost.AdministradorBO();
            oAdmin.Email = txtEmail.Text;
            oAdmin.Contraseñaadmin = txtContraseña.Text;
            Datos = Services.Login(oAdmin);
            if (Datos.Rows.Count != 0)
            {
                Session["idAdmin"] = Datos.Rows[0][1].ToString();
                Server.Transfer("Principal.aspx");
            }
            else
            {
               localhost.UsuarioBO oUser = new localhost.UsuarioBO();
               oUser.EmailUsuario = txtEmail.Text;
               oUser.ContraseñaUsuario = txtContraseña.Text;
               Datos = Services.LoginUsuario(oUser);
               if (Datos.Rows.Count != 0)
               {
                   Session["idUser"] = Datos.Rows[0][1].ToString();
                   Server.Transfer("Principal.aspx");
               }
               else
               {
                   Response.Redirect("Registro.aspx");
               }
             }
          
        }
    }
}