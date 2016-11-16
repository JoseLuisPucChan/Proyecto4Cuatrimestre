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
        public static string BuscarUsuario(string email,string contraseña)
        {
            DataTable Datos = new DataTable();
            localhost.WsMCTuristic Services = new localhost.WsMCTuristic();
            localhost.AdministradorBO oAdmin = new localhost.AdministradorBO();
            oAdmin.Email = email;
            oAdmin.Contraseñaadmin = contraseña;
            Datos = Services.Login(oAdmin);
            if (Datos.Rows.Count != 0)
            {
                return "Usted No tiene acceso";
            }
            else
            {
                Login ologin = new Login();
                ologin.declararSession(Convert.ToInt32(Datos.Rows[0][1].ToString()));

            }
            return "Birnvenido";
          
        }
        private void declararSession(int ID )
        {
            Session["idDueño"] = ID ;
            Server.Transfer("Inicio.aspx");
          
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