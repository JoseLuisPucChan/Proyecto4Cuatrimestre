using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using WSMCTuristic_CentroHistorico.BO;
namespace WSMCTuristic_CentroHistorico.UI
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
        Services.CtrlUsuario oUsuarioCTRL;
        Services.CtrlDireccion oDireccionCTRL;
        Services.CtrlEstablecimiento oEstablecimiento;
        Services.CtrlEvento oEventoCTRL;
        Services.CtrlNotificaciones oNotificacionesCTRL;
        Services.CtrlServicio oServicioCTRL;

        //--------------------------ABC Usuarios-----------------------------
         [WebMethod]
        public int InsertarUsuario( UsuarioBO obj )
        {
            UsuarioBO oUsuario = obj;
            oUsuarioCTRL  = new Services.CtrlUsuario();
            return oUsuarioCTRL.InsertarUsuario(oUsuario);
        }
        [WebMethod]

        public int ModificarUsuario(UsuarioBO obj)
        {
            UsuarioBO oUsuario = obj;
            oUsuarioCTRL = new Services.CtrlUsuario();
            return oUsuarioCTRL.ModificarUsuario(oUsuario);
        }
        [WebMethod]
        public int EliminarUsuario(UsuarioBO obj)
        {
            UsuarioBO oUsuario = obj;
            oUsuarioCTRL = new Services.CtrlUsuario();
            return oUsuarioCTRL.ModificarUsuario(oUsuario);
        }

        //--------------------------ABC Direcciones-----------------------------
        [WebMethod]
        public int EliminarDireccion(DireccionBO obj)
        {
            DireccionBO oDireccion = obj;
            oDireccionCTRL = new Services.CtrlDireccion();
            return oDireccionCTRL.EliminarDireccion(oDireccion);
        }

        [WebMethod]
        public int InsertarDireccion(DireccionBO obj)
        {
            DireccionBO oDireccion = obj;
            oDireccionCTRL = new Services.CtrlDireccion();
            return oDireccionCTRL.EliminarDireccion(oDireccion);
        }
        [WebMethod]
        public int ModificarDireccion(DireccionBO obj)
        {
            DireccionBO oDireccion = obj;
            oDireccionCTRL = new Services.CtrlDireccion();
            return oDireccionCTRL.EliminarDireccion(oDireccion);
        }

        //---------------------ABC Establecimiento-----------------------
        [WebMethod]
        public int InsertarEstablecimiento(BO.EstablecimientoBO obj)
        {
            BO.EstablecimientoBO oEstablecimientoBO = new BO.EstablecimientoBO();
            oEstablecimientoBO = obj;

            oEstablecimiento = new Services.CtrlEstablecimiento();
            return oEstablecimiento.insertarEstablecimiento(oEstablecimientoBO);
        }

        [WebMethod]
        public int ModificarEstablecimiento(BO.EstablecimientoBO obj)
        {
            BO.EstablecimientoBO oEstablecimientoBO = new BO.EstablecimientoBO();
            oEstablecimientoBO = obj;

            oEstablecimiento = new Services.CtrlEstablecimiento();
            return oEstablecimiento.ModificarEstablecimiento(oEstablecimientoBO);
        }

        [WebMethod]
        public int EliminarEstablecimiento(BO.EstablecimientoBO obj)
        {
            BO.EstablecimientoBO oEstablecimientoBO = new BO.EstablecimientoBO();
            oEstablecimientoBO = obj;

            oEstablecimiento = new Services.CtrlEstablecimiento();
            return oEstablecimiento.EliminarEstablecimiento(oEstablecimientoBO);
        }

        //--------------------------ABC Evento-----------------------------


        [WebMethod]
        public int InsertarEvento(BO.EventoBO obj)
        {        
            BO.EventoBO oEventoBO = new BO.EventoBO();
            oEventoBO = obj;

            oEventoCTRL = new Services.CtrlEvento();
            return oEventoCTRL.EliminarEvento(oEventoBO);
        }

        [WebMethod]
        public int ModificarEvento(BO.EventoBO obj)
        {
            BO.EventoBO oEventoBO = new BO.EventoBO();
            oEventoBO = obj;

            oEventoCTRL = new Services.CtrlEvento();
            return oEventoCTRL.ModificarEvento(oEventoBO);
        }

        public int EliminarEvento(BO.EventoBO obj)
        {
            BO.EventoBO oEventoBO = new BO.EventoBO();
            oEventoBO = obj;

            oEventoCTRL = new Services.CtrlEvento();
            return oEventoCTRL.EliminarEvento(oEventoBO);
        }

        //--------------------------ABC Notificaciones-----------------------------

        [WebMethod]
        public int InsertarNotificacion(BO.NotificacionesBO obj)
        {
            BO.NotificacionesBO oNotificacionesBO = new BO.NotificacionesBO();
            oNotificacionesBO = obj;

            oNotificacionesCTRL = new Services.CtrlNotificaciones();
            return oNotificacionesCTRL.InsertarNotificacion(oNotificacionesBO);
        }

        [WebMethod]
        public int ModificarNotificaciones(BO.NotificacionesBO obj)
        {
            BO.NotificacionesBO oNotificacionesBO = new BO.NotificacionesBO();
            oNotificacionesBO = obj;

            oNotificacionesCTRL = new Services.CtrlNotificaciones();
            return oNotificacionesCTRL.ModificarNotificacion(oNotificacionesBO);
        }

        [WebMethod]
        public int EliminarNotificaciones(BO.NotificacionesBO obj)
        {
            BO.NotificacionesBO oNotificacionesBO = new BO.NotificacionesBO();
            oNotificacionesBO = obj;

            oNotificacionesCTRL = new Services.CtrlNotificaciones();
            return oNotificacionesCTRL.EliminarNotificacion(oNotificacionesBO);
        }

        //--------------------------ABC Servicio-----------------------------

        [WebMethod]
        public int InsertarServicio(BO.ServicioBO obj)
        {
            BO.ServicioBO oServicioBO = new BO.ServicioBO();
            oServicioBO = obj;

            oServicioCTRL = new Services.CtrlServicio();
            return oServicioCTRL.InsertarServicio(oServicioBO);
        }


        [WebMethod]
        public int ModificarServicio(BO.ServicioBO obj)
        {
            BO.ServicioBO oServicioBO = new BO.ServicioBO();
            oServicioBO = obj;

            oServicioCTRL = new Services.CtrlServicio();
            return oServicioCTRL.ModificarServicio(oServicioBO);
        }

        [WebMethod]
        public int EliminarServicio(BO.ServicioBO obj)
        {
            BO.ServicioBO oServicioBO = new BO.ServicioBO();
            oServicioBO = obj;
            oServicioCTRL = new Services.CtrlServicio();
            return oServicioCTRL.EliminarServicio(oServicioBO);
        }


    }
}
