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

        public static string GuardarEstablecimiento(string nombre, string telefono, string facebook, string abrir, string cerrar, string ubicacion, decimal latitud, decimal longitud)
        {
            localhost.WsMCTuristic owebService = new WsMCTuristic();
            localhost.EstablecimientoBO oEstablecimientoBO = new EstablecimientoBO();
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