using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using WSTuristic_CentroHistorico.BO;

namespace WSTuristic_CentroHistorico.UI
{
    /// <summary>
    /// Descripción breve de WsMCTuristic
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WsMCTuristic : System.Web.Services.WebService
    {
        Services.CtrlSitio oSitioCtrl;
        Services.CtrlSoporte oSoporteCTRL;
        Services.CtrlTipoServicio oTipoServicioCTRL;
        Services.CtrlTipoSitio oTipoSitioCtrl;
        Services.CtrlTipoSuscripcion oTipoSuscripcionCTRL;
        

        [WebMethod]
        public string HelloWorld()
        {
            return "Hola a todos";
        }

        //--------------------- ABC Sitio---------------
        [WebMethod]
        public int InsertarSitio(SitioBO obj)
        {
            SitioBO oSitio = obj;
            oSitioCtrl = new Services.CtrlSitio();
            return oSitioCtrl.InsertarSitio(oSitio);
        }
        [WebMethod]
        public int ModificarSitio(SitioBO obj)
        {
            SitioBO oSitio = obj;
            oSitioCtrl = new Services.CtrlSitio();
            return oSitioCtrl.ModificarSitio(oSitio);
        }
        [WebMethod]
        public int EliminarSitio(SitioBO obj)
        {
            SitioBO oSitio = obj;
            oSitioCtrl = new Services.CtrlSitio();
            return oSitioCtrl.EliminarSitio(oSitio);
        }
        //------------ABC Soporte-------------------
        [WebMethod]
        public int InsertarSoporte(SoporteBO obj)
        {
            SoporteBO oSoporte = obj;
            oSoporteCTRL = new Services.CtrlSoporte();
            return oSoporteCTRL.InsertarSoporte(oSoporte);
        }
        [WebMethod]
        public int ModificarSoporte(SoporteBO obj)
        {
            SoporteBO oSoporte = obj;
            oSoporteCTRL = new Services.CtrlSoporte();
            return oSoporteCTRL.ModificarSoporte(oSoporte);
        }
        [WebMethod]
        public int EliminarSoporte(SoporteBO obj)
        {
            SoporteBO oSoporte = obj;
            oSoporteCTRL = new Services.CtrlSoporte();
            return oSoporteCTRL.EliminarSoporte(oSoporte);
        }
        //----------------ABC TipoServicio -----------
        [WebMethod]
        public int InsertarTipoServicio(TipoServicioBO obj)
        {
            TipoServicioBO oTipoServicio = obj;
            oTipoServicioCTRL = new Services.CtrlTipoServicio();
            return oTipoServicioCTRL.InsertarTipoServicio(oTipoServicio);
        }
        [WebMethod]
        public int ModificarTipoServicio(TipoServicioBO obj)
        {
            TipoServicioBO oTipoServicio = obj;
            oTipoServicioCTRL = new Services.CtrlTipoServicio();
            return oTipoServicioCTRL.ModificarTipoServicio(oTipoServicio);
        }
        [WebMethod]
        public int EliminarTipoServicio(TipoServicioBO obj)
        {
            TipoServicioBO oTipoServicio = obj;
            oTipoServicioCTRL = new Services.CtrlTipoServicio();
            return oTipoServicioCTRL.EliminarTipoServicio(oTipoServicio);
        }
        //------------- ABC TipoSitio -----------------
        [WebMethod]
        public int InsertarTipoSitio(TipoSitioBO obj)
        {
            TipoSitioBO oTipoSitio = obj;
            oTipoSitioCtrl = new Services.CtrlTipoSitio();
            return oTipoSitioCtrl.InsertarTipoSitio(oTipoSitio);
        }
        [WebMethod]
        public int ModificarTipoSitio(TipoSitioBO obj)
        {
            TipoSitioBO oTipoSitio = obj;
            oTipoSitioCtrl = new Services.CtrlTipoSitio();
            return oTipoSitioCtrl.ModificarTipoSitio(oTipoSitio);
        }
        [WebMethod]
        public int EliminarTipoSitio(TipoSitioBO obj)
        {
            TipoSitioBO oTipoSitio = obj;
            oTipoSitioCtrl = new Services.CtrlTipoSitio();
            return oTipoSitioCtrl.EliminarTipoSitio(oTipoSitio);
        }
        //------------ ABC TipoSuscripcion --------------
        [WebMethod]
        public int InsertarTipoSuscripcion(TipoSuscripcionBO obj)
        {
            TipoSuscripcionBO oTipoSuscripcion = obj;
            oTipoSuscripcionCTRL = new Services.CtrlTipoSuscripcion();
            return oTipoSuscripcionCTRL.InsertarTipoSuscripcion(oTipoSuscripcion);
        }
        [WebMethod]
        public int ModificarTipoSuscripcion(TipoSuscripcionBO obj)
        {
            TipoSuscripcionBO oTipoSuscripcion = obj;
            oTipoSuscripcionCTRL = new Services.CtrlTipoSuscripcion();
            return oTipoSuscripcionCTRL.ModificarTipoSuscripcion(oTipoSuscripcion);
        }
        [WebMethod]
        public int EliminarTipoSuscripcion(TipoSuscripcionBO obj)
        {
            TipoSuscripcionBO oTipoSuscripcion = obj;
            oTipoSuscripcionCTRL = new Services.CtrlTipoSuscripcion();
            return oTipoSuscripcionCTRL.EliminarTipoSuscripcion(oTipoSuscripcion);
        }
    }
}
