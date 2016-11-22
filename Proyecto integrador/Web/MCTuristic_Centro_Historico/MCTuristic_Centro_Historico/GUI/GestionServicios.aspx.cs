using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MCTuristic_Centro_Historico.localhost;

namespace MCTuristic_Centro_Historico.GUI
{
    public partial class GestionServicios : System.Web.UI.Page
    {
        public int establecimiento;
        public int tipoServicio;

        protected void Page_Load(object sender, EventArgs e)
        {
            txtIdEstablecimiento.Text = (string)Session["IdEstablecimiento"];
        }

        public static string GuardarServicio(int establecimiento, int tipoServicio, string nombre, string oferta, string descripcion, decimal precio)
        {
            localhost.WsMCTuristic owebService = new WsMCTuristic();
            localhost.ServicioBO oServicioBO = new ServicioBO();
            oServicioBO.IdEstablecimiento = establecimiento;
            oServicioBO.IdTipoServicio = tipoServicio;
            oServicioBO.DescripcionServicio = descripcion;
            oServicioBO.OfertaServicio = oferta;
            oServicioBO.NombreServicio = nombre;
            oServicioBO.PrecioServicio = precio;
            
            int i = owebService.InsertarServicio(oServicioBO);
            if (i > 0)
            {
                return "Operación exitosa";
            }
            return "Fallo la operación";

        }

        public static string GuardarTipoServicio(string nombre)
        {
            localhost.WsMCTuristic owebService = new WsMCTuristic();
            localhost.TipoServicioBO oTipoServicioBO = new TipoServicioBO();
            oTipoServicioBO.NombreServicio = nombre;
            int i = owebService.InsertarTipoServicio(oTipoServicioBO);
            if (i > 0)
            {
                return "Operación exitosa";
            }
            return "Fallo la operación";

        }

        protected void ddlTipoServicio_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtIdTipoServicio.Text = ddlTipoServicio.SelectedIndex.ToString();
        }
    }
}