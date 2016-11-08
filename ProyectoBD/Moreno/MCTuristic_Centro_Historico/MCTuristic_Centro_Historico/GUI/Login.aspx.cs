using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MCTuristic_Centro_Historico.GUI
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

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