using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MCTuristic_Centro_Historico.GUI
{
    public partial class GestionEstablecimientos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnServicios_Click(object sender, EventArgs e)
        {
            Session["IdEstablecimiento"] = txtIdEstablecimiento.Text;
            Response.Redirect("GestionServicios.aspx");
        }

        public static string GuardarEstablecimiento(string nombre, string telefono, string facebook, string abrir, string cerrar, decimal latitud, decimal longitud, Image foto)
        {
            localhost.WsMCTuristic owebService = new localhost.WsMCTuristic();
            localhost.EstablecimientoBO oEstablecimientoBO = new localhost.EstablecimientoBO();
            oEstablecimientoBO.NombreEstable = nombre;
            oEstablecimientoBO.TelefonoEstable = telefono;
            oEstablecimientoBO.PagFacebook = facebook;
            oEstablecimientoBO.HoraInicioEstable = abrir;
            oEstablecimientoBO.HoraCierreEstable = cerrar;
            oEstablecimientoBO.Latitud = latitud;
            oEstablecimientoBO.Longitud = longitud;
            int i = owebService.InsertarEstablecimiento(oEstablecimientoBO);
            if (i > 0)
            {
                return "Operación exitosa";
            }
            return "Fallo la operación";

        }

    }
}