using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MCTuristic_Centro_Historico.GUI
{
    public partial class GestionAdministrador : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }
        [WebMethod]
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
        public static string GuardarDireccion(string calle, string numero, string estado, string cruz, string cp, string col, string descripcion)
        {
            localhost.WsMCTuristic owebService = new localhost.WsMCTuristic();
            localhost.DireccionBO oDireccionBO = new localhost.DireccionBO();

            oDireccionBO.Calle = calle;
            oDireccionBO.Numero = numero;
            oDireccionBO.Estado = estado;
            oDireccionBO.Cruzamiento = cruz;
            oDireccionBO.CodPostal = cp;
            oDireccionBO.Colonia = col;
            oDireccionBO.DescripcionDireccion = descripcion;
            oDireccionBO.IdAdministrador = Convert.ToInt32(owebService.obtener_adminid());
            int i = owebService.InsertarDireccion_admin(oDireccionBO);
            if (i > 0)
            {
                return "Operación exitosa";
            }
            return "Fallo la operación";

        }
        protected void lbtnGuardar_Click1(object sender, EventArgs e)
        {
            try
            {
                if (txtNumero.Text != string.Empty)
                {
                    GuardarAdmin(txtNombre.Text.Trim(), txtApellidos.Text.Trim(), txtCorreo.Text.Trim(), txtContrasena.Text.Trim(), txtTelefono.Text.Trim(), txtFecha.Text.Trim());
                    GuardarDireccion(txtCalle.Text.Trim(), txtNumero.Text.Trim(), txtEstado.Text.Trim(), txtCruzamiento.Text.Trim(), txtCP.Text.Trim(), txtColonia.Text.Trim(), txtDescripcion.Text.Trim());
                    CargarAdmin();
                }

            }
            catch
            { }
        }
        private void CargarAdmin()
        {
            localhost.WsMCTuristic owebService = new localhost.WsMCTuristic();
            //gvDatos.DataSource = owebService.ver_Admin_admin();
            //gvDatos.DataBind();
            ASPxGridView1.DataSource = owebService.ver_Admin_admin();
            ASPxGridView1.DataBind();
        }

        protected void lbtnModificar_Click(object sender, EventArgs e)
        {
            CargarAdmin();
        }


        protected void ASPxGridView1_RowCommand(object sender, DevExpress.Web.ASPxGridViewRowCommandEventArgs e)
        {
            if (e.CommandArgs.CommandArgument.ToString() == "Editar")
            {
                txtNombre.Text = ASPxGridView1.GetRowValues(e.VisibleIndex, "Nombre").ToString();



            }
        }
        protected void ASPxGridView1_FocusedRowChanged(object sender, EventArgs e)
        {

        }

    }
}