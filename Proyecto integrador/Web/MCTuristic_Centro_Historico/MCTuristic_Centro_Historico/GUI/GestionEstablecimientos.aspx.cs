using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MCTuristic_Centro_Historico.GUI;
using MCTuristic_Centro_Historico.localhost;

namespace MCTuristic_Centro_Historico.GUI
{
    public partial class GestionEstablecimientos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnServicios_Click(object sender, EventArgs e)
        {
            Response.Redirect("GestionServicios.aspx");
        }

        public static string Guardar(string nombre, string apellido, string email, string contraseña, string numero)
        {
            localhost.WsMCTuristic owebService = new WsMCTuristic();
            localhost.UsuarioBO oUsuariosBO = new UsuarioBO();
            oUsuariosBO.NombreUsuario = nombre;
            oUsuariosBO.ApellidosUsuario = apellido;
            oUsuariosBO.EmailUsuario = email;
            oUsuariosBO.ContraseñaUsuario = contraseña;
            oUsuariosBO.TelefonoUsuario = numero;
            oUsuariosBO.FecharNacUsuario = DateTime.Now;
            int i = owebService.InsertarUsuario(oUsuariosBO);
            if (i > 0)
            {
                return "Operación exitosa";
            }
            return "Fallo la operación";

        }


    }
}