using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WSMCTuristic_CentroHistorico.Services
{
    public class CtrlTipoSuscripcion
    {
        DAO.TipoSuscripcionDAO oTipoSuscripcion;

        public int InsertarTipoSuscripcion(object obj)
        {
            oTipoSuscripcion = new DAO.TipoSuscripcionDAO();
            return oTipoSuscripcion.AgregarTipoSuscripcion(obj);
        }

        public int ModificarTipoSuscripcion(object obj)
        {
            oTipoSuscripcion = new DAO.TipoSuscripcionDAO();
            return oTipoSuscripcion.ActualizarTipoSuscripcion(obj);
        }

        public int EliminarTipoSuscripcion(object obj)
        {
            oTipoSuscripcion = new DAO.TipoSuscripcionDAO();
            return oTipoSuscripcion.EliminarTipoSuscripcion(obj);
        }
    }
}