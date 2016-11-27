using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MCTuristic_Centro_Historico.GUI
{
    public partial class GestionSitios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public static string GuardarTipoSitio(string nombre, string descripcion)
        {
            localhost.WsMCTuristic owebService = new localhost.WsMCTuristic();
            localhost.TipoSitioBO oTipoSitioBO = new localhost.TipoSitioBO();
            oTipoSitioBO.NombreSitio = nombre;
            oTipoSitioBO.DescripcicionSitio = descripcion;
            int i = owebService.InsertarTipoSitio(oTipoSitioBO);
            if (i > 0)
            {
                return "Operación exitosa";
            }
            return "Fallo la operación";

        }

        public static string GuardarSitio(string nombre, int idTipo, string direccion, decimal latitud, decimal longitud, string historia, string suceso, string descripcion)
        {
            localhost.WsMCTuristic owebService = new localhost.WsMCTuristic();
            localhost.SitioBO oSitioBO = new localhost.SitioBO();
            oSitioBO.NombreSitio = nombre;
            oSitioBO.IdTipoSitio = idTipo;
            oSitioBO.Direccion = direccion;
            oSitioBO.LatitudSitio = latitud;
            oSitioBO.LongitudSitio = longitud;
            oSitioBO.Historia = historia;
            oSitioBO.SucesoImportante = suceso;
            oSitioBO.DescripcionSitio = descripcion;
            int i = owebService.InsertarSitio(oSitioBO);
            if (i > 0)
            {
                return "Operación exitosa";
            }
            return "Fallo la operación";

        }


    }
}