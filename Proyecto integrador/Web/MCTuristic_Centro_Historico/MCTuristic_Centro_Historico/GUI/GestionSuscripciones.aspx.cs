using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MCTuristic_Centro_Historico.localhost;

namespace MCTuristic_Centro_Historico.GUI
{
    public partial class GestionSuscripciones : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public static string GuardarTipoSuscripcion(string nombre, decimal monto, int tiempo)
        {
            localhost.WsMCTuristic owebService = new WsMCTuristic();
            localhost.TipoSuscripcionBO oTipoSuscripcionBO = new TipoSuscripcionBO();
            oTipoSuscripcionBO.NombreTipoSuscri = nombre;
            oTipoSuscripcionBO.MontoSuscripcion = monto;
            oTipoSuscripcionBO.TiempoSuscripcion = tiempo;
            int i = owebService.InsertarTipoSuscripcion(oTipoSuscripcionBO);
            if (i > 0)
            {
                return "Operación exitosa";
            }
            return "Fallo la operación";

        }

        public static string GuardarSuscripcion(int idTipo, string fecha, string usuario)
        {
            localhost.WsMCTuristic owebService = new WsMCTuristic();
            localhost.SuscripcionBO oSuscripcionBO = new SuscripcionBO();
            oSuscripcionBO.IdSuscripcion = idTipo;
            oSuscripcionBO.FechaPago = Convert.ToDateTime(fecha);
            oSuscripcionBO.IdUsuario = usuario;
            int i = owebService.InsertarSuscripcion(oSuscripcionBO);
            if (i > 0)
            {
                return "Operación exitosa";
            }
            return "Fallo la operación";

        }

        protected void ddlSuscripcion_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtIdTipo.Text = ddlSuscripcion.SelectedIndex.ToString();
        }
    }
}