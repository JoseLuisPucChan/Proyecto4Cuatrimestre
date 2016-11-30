using System;
using System.Collections.Generic;
using System.Data;
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
        Services.CtrlSitio oSitioCtrl;
        Services.CtrlSoporte oSoporteCTRL;
        Services.CtrlTipoServicio oTipoServicioCTRL;
        Services.CtrlTipoSitio oTipoSitioCtrl;
        Services.CtrlTipoSuscripcion oTipoSuscripcionCTRL;
        Services.CtrlContactanos oContactanosCTRL;
        Services.CtrlAdministrador oAdministradorCTRL;
        Services.CtrlComentario oComentariosCTRL;
        Services.CtrlSuscripcion oSuscripcionCTRL;
        //--------------------------ABC Usuarios-----------------------------
         [WebMethod]
        public int InsertarUsuario( UsuarioBO obj )
        {
            UsuarioBO oUsuario = new UsuarioBO();
            oUsuario = obj;

            oUsuarioCTRL  = new Services.CtrlUsuario();
            return oUsuarioCTRL.InsertarUsuario(oUsuario);
        }
        [WebMethod]

        public int ModificarUsuario(UsuarioBO obj)
        {
            UsuarioBO oUsuario = new UsuarioBO();
            oUsuario = obj;

            oUsuarioCTRL = new Services.CtrlUsuario();
            return oUsuarioCTRL.ModificarUsuario(oUsuario);
        }
        [WebMethod]
        public int EliminarUsuario(UsuarioBO obj)
        {
            UsuarioBO oUsuario = new UsuarioBO();
            oUsuario = obj;

            oUsuarioCTRL = new Services.CtrlUsuario();
            return oUsuarioCTRL.EliminarUsuario(oUsuario);
        }
         [WebMethod]
        public string obtener_usuarioid()
        {
            oUsuarioCTRL = new Services.CtrlUsuario();
            return oUsuarioCTRL.id_usuario();
        }

         [WebMethod]
         public DataTable LoginUsuario(UsuarioBO obj)
         {
             UsuarioBO oUsuario = obj;
             oUsuarioCTRL = new Services.CtrlUsuario();
             return oUsuarioCTRL.LoginUsuario(oUsuario);
         }

         //Nuevo webmethod Diosemir Nah
         public DataSet usuario_adminWS()
         {
             oUsuarioCTRL = new Services.CtrlUsuario();
             return oUsuarioCTRL.topUsuarios_admin();
         }
         //Nuevo webmethod Diosemir Nah
         public DataSet usuario_adminFiltradosWS()
         {
             oUsuarioCTRL = new Services.CtrlUsuario();
             return oUsuarioCTRL.topUsuarios_adminFiltrados();
         }
         //Nuevo webmethod Diosemir Nah
         public DataSet usuario_userWS()
         {
             oUsuarioCTRL = new Services.CtrlUsuario();
             return oUsuarioCTRL.topUsuarios_User();
         }

        //--------------------------ABC Direcciones-----------------------------
        [WebMethod]
        public int EliminarDireccion(DireccionBO obj)
        {
            DireccionBO oDireccion = new DireccionBO();
            oDireccion = obj;
            oDireccionCTRL = new Services.CtrlDireccion();
            return oDireccionCTRL.EliminarDireccion(oDireccion);
        }

        [WebMethod]
        public int InsertarDireccion(DireccionBO obj)
        {
            DireccionBO oDireccion = new DireccionBO();
            oDireccion = obj;

            oDireccionCTRL = new Services.CtrlDireccion();
            return oDireccionCTRL.InsertarDireccion(oDireccion);
        }
        [WebMethod]
        public int ModificarDireccion(DireccionBO obj)
        {
            DireccionBO oDireccion = new DireccionBO();
            oDireccion = obj;

            oDireccionCTRL = new Services.CtrlDireccion();
            return oDireccionCTRL.ModificarDireccion(oDireccion);
        }

        //......Admin
        [WebMethod]
        public int InsertarDireccion_admin(DireccionBO obj)
        {
            DireccionBO oDireccion = new DireccionBO();
            oDireccion = obj;
            oDireccionCTRL = new Services.CtrlDireccion();
            return oDireccionCTRL.InsertarDireccion(oDireccion);
        }
        [WebMethod]
        public int ModificarDireccion_admin(DireccionBO obj)
        {
            DireccionBO oDireccion = new DireccionBO();
            oDireccion = obj;

            oDireccionCTRL = new Services.CtrlDireccion();
            return oDireccionCTRL.ModificarDireccion_admin(oDireccion);
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

        //Nuevo webmethod Diosemir Nah
        public DataSet establecimiento_UserWS()
        {
            oEstablecimiento = new Services.CtrlEstablecimiento();
            return oEstablecimiento.topEstablecimientos_userDS();
        }
        [WebMethod]
        //Nuevo webmethod Diosemir Nah
        public DataSet establecimiento_AdminWS()
        {
            oEstablecimiento = new Services.CtrlEstablecimiento();
            return oEstablecimiento.topEstablecimientos_adminDS();
        }

        //--------------------------ABC Evento-----------------------------


        [WebMethod]
        public int InsertarEvento(BO.EventoBO obj)
        {        
            BO.EventoBO oEventoBO = new BO.EventoBO();
            oEventoBO = obj;
            oEventoCTRL = new Services.CtrlEvento();
            return oEventoCTRL.InsertarEvento(oEventoBO);
        }

        [WebMethod]
        public int ModificarEvento(BO.EventoBO obj)
        {
            BO.EventoBO oEventoBO = new BO.EventoBO();
            oEventoBO = obj;

            oEventoCTRL = new Services.CtrlEvento();
            return oEventoCTRL.ModificarEvento(oEventoBO);
        }
        [WebMethod]
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
        [WebMethod]
        //Nuevo webmethod Diosemir Nah
       public DataSet topServicios()
        {
            oServicioCTRL = new Services.CtrlServicio();
            return oServicioCTRL.topServicios_user();
        }
        [WebMethod]
        //Nuevo webmethod Diosemir Nah
        public DataSet topServicios_admin()
        {
            oServicioCTRL = new Services.CtrlServicio();
            return oServicioCTRL.topServicios_admin();
        }
      [WebMethod]
        public byte[] verFotoSer(int Ser)
        {
            oServicioCTRL = new Services.CtrlServicio();
            return oServicioCTRL.verfoto(Ser);
        }
        //--------------------- ABC Sitio---------------
        [WebMethod]
        public int InsertarSitio(SitioBO obj)
        {
            SitioBO oSitio = new SitioBO();
            oSitio = obj;

            oSitioCtrl = new Services.CtrlSitio();
            return oSitioCtrl.InsertarSitio(oSitio);
        }
        [WebMethod]
        public int ModificarSitio(SitioBO obj)
        {
            SitioBO oSitio = new SitioBO();
            oSitio = obj;

            oSitioCtrl = new Services.CtrlSitio();
            return oSitioCtrl.ModificarSitio(oSitio);
        }
        [WebMethod]
        public int EliminarSitio(SitioBO obj)
        {
            SitioBO oSitio = new SitioBO();
            oSitio = obj;

            oSitioCtrl = new Services.CtrlSitio();
            return oSitioCtrl.EliminarSitio(oSitio);
        }
        //Nuevo webmethod Diosemir Nah
        public DataSet sitio_WS()
        {
            oSitioCtrl = new Services.CtrlSitio();
            return oSitioCtrl.topSitioDS();
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
        //Nuevo webmethod Diosemir Nah
        public DataSet tipoServicioWS()
        {
            oTipoServicioCTRL = new Services.CtrlTipoServicio();
            return oTipoServicioCTRL.topTipoServicios   ();
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
        //---------------------ABC Contactanos --------------

        [WebMethod]
        public int InsertarContactanos(ContactanosBO obj)
        {
            ContactanosBO oContactanos = obj;
            oContactanosCTRL = new Services.CtrlContactanos();
            return oContactanosCTRL.InsertarContactanos(oContactanos);
        }
        [WebMethod]
        public int ModificarContactanos(ContactanosBO obj)
        {
            ContactanosBO oContactanos = obj;
            oContactanosCTRL = new Services.CtrlContactanos();
            return oContactanosCTRL.ModificarContactanos(oContactanos);
        }
        [WebMethod]
        public int EliminarContactanos(ContactanosBO obj)
        {
            ContactanosBO oContactanos = obj;
            oContactanosCTRL = new Services.CtrlContactanos();
            return oContactanosCTRL.EliminarContactanos(oContactanos);
        }

        //---------------------ABC Administrador-----------------

        [WebMethod]
        public DataTable Login(AdministradorBO obj)
        {
            AdministradorBO oAdministrador = obj;
            oAdministradorCTRL = new Services.CtrlAdministrador();
            return oAdministradorCTRL.LoginUsuario(oAdministrador);
        }
        [WebMethod]
        public DataSet ver_Admin_admin()
        {
            oAdministradorCTRL = new Services.CtrlAdministrador();
            return oAdministradorCTRL.ver_admi_admin();
        }

        [WebMethod]
        public int InsertarAdministrador(AdministradorBO obj)
        {
            AdministradorBO oAdministrador = obj;
            oAdministradorCTRL = new Services.CtrlAdministrador();
            return oAdministradorCTRL.InsertarAdministrador(oAdministrador);
        }
        [WebMethod]
        public int ModificarAdministrador(AdministradorBO obj)
        {
            AdministradorBO oAdministrador = obj;
            oAdministradorCTRL = new Services.CtrlAdministrador();
            return oAdministradorCTRL.ModificarAdministrador(oAdministrador);
        }
        [WebMethod]
        public int EliminarAdministrador(AdministradorBO obj)
        {
            AdministradorBO oAdministrador = obj;
            oAdministradorCTRL = new Services.CtrlAdministrador();
            return oAdministradorCTRL.EliminarAdministrador(oAdministrador);
        }

        //------------- ABC Comentarios -----------------------
        [WebMethod]
        public int InsertarComentarios(ComentariosBO obj)
        {
            ComentariosBO oComentarios = obj;
            oComentariosCTRL = new Services.CtrlComentario();
            return oComentariosCTRL.InsertarComentarios(oComentarios);
        }
        [WebMethod]
        public int ModificarComentarios(ComentariosBO obj)
        {
            ComentariosBO oComentarios = obj;
            oComentariosCTRL = new Services.CtrlComentario();
            return oComentariosCTRL.ModificarComentarios(oComentarios);
        }
        [WebMethod]
        public int EliminarComentarios(ComentariosBO obj)
        {
            ComentariosBO oComentarios = obj;
            oComentariosCTRL = new Services.CtrlComentario();
            return oComentariosCTRL.EliminarComentarios(oComentarios);
        }

        //------------- ABC Suscripción -----------------------

        [WebMethod]
        public int InsertarSuscripcion(SuscripcionBO obj)
        {
            SuscripcionBO oSuscripcion = obj;
            oSuscripcionCTRL = new Services.CtrlSuscripcion();
            return oSuscripcionCTRL.InsertarSuscripcion(oSuscripcion);
        }
        [WebMethod]
        public int ModificarSuscripcion(SuscripcionBO obj)
        {
            SuscripcionBO oSuscripcion = obj;
            oSuscripcionCTRL = new Services.CtrlSuscripcion();
            return oSuscripcionCTRL.ModificarSuscripcion(oSuscripcion);
        }
        [WebMethod]
        public int EliminarSuscripcion(SuscripcionBO obj)
        {
            SuscripcionBO oSuscripcion = obj;
            oSuscripcionCTRL = new Services.CtrlSuscripcion();
            return oSuscripcionCTRL.EliminarSuscripcion(oSuscripcion);
        }

    }
}
