using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WSMCTuristic_CentroHistorico.Services
{
    public class CtrlSoporte
    {
        DAO.SoporteDAO oSoporte;

        public int InsertarSoporte(object obj)
        {
            oSoporte = new DAO.SoporteDAO();
            return oSoporte.AgregarSoporte(obj);
        }

        public int ModificarSoporte(object obj)
        {
            oSoporte = new DAO.SoporteDAO();
            return oSoporte.ActualizarSoporte(obj);
        }

        public int EliminarSoporte(object obj)
        {
            oSoporte = new DAO.SoporteDAO();
            return oSoporte.EliminarSoporte(obj);
        }
    }
}