using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MCTuristic_Centro_Historico.GUI
{
    public partial class GestionAdministrador : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public static string GuardarAdmin(string nombre, string apellido, string correo, string contra, string telefono, string fecha)
        {
            localhost.WsMCTuristic owebService = new localhost.WsMCTuristic();
            localhost.AdministradorBO oAdministradorBO = new localhost.AdministradorBO();
            oAdministradorBO.Nombreadmin = nombre;
            oAdministradorBO.Apellidosadmin = apellido;
            oAdministradorBO.Email = correo;
            oAdministradorBO.Contraseñaadmin = contra;
            oAdministradorBO.Telefonoadmin = telefono;
            oAdministradorBO.Fechanacimiento = fecha;
            int i = owebService.InsertarAdministrador(oAdministradorBO);

            if (i > 0)
            {
                return "Operación exitosa";
            }
            return "Fallo la operación";

        }

        protected void lbtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                GuardarAdmin(txtNombre.Text.Trim(), txtApellidos.Text.Trim(), txtCorreo.Text.Trim(), txtContrasena.Text.Trim(), txtTelefono.Text.Trim(), txtFecha.Text.Trim());
            }
            catch { }

        }
    }
}