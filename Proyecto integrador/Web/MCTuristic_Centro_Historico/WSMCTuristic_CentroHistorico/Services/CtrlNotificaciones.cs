using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WSMCTuristic_CentroHistorico.Services
{
    public class CtrlNotificaciones
    {
        DAO.NotificacionesDAO oNotificaciones;
        public int InsertarNotificacion(object obj)
        {
            oNotificaciones = new DAO.NotificacionesDAO();
            return oNotificaciones.InstertarNotificacion(obj);
        }

        public int ModificarNotificacion(object obj)
        {
            oNotificaciones = new DAO.NotificacionesDAO();
            return oNotificaciones.ModificarNotificacion(obj);
        }

        public int EliminarNotificacion(object obj)
        {
            oNotificaciones = new DAO.NotificacionesDAO();
            return oNotificaciones.EliminarNotificacion(obj);
        }
    }
}