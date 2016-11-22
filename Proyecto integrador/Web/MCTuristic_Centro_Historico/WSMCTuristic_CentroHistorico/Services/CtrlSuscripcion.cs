using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WSMCTuristic_CentroHistorico.Services
{
    public class CtrlSuscripcion
    {
        DAO.SuscripcionDAO oSuscripcion;
        public int InsertarSuscripcion(object obj)
        {
            oSuscripcion = new DAO.SuscripcionDAO();
            return oSuscripcion.AgregarSuscripcion(obj);
        }

        public int ModificarSuscripcion(object obj)
        {
            oSuscripcion = new DAO.SuscripcionDAO();
            return oSuscripcion.ActualizarSuscripcion(obj);
        }

        public int EliminarSuscripcion(object obj)
        {
            oSuscripcion = new DAO.SuscripcionDAO();
            return oSuscripcion.EliminarSuscripcion(obj);
        }
    }
}