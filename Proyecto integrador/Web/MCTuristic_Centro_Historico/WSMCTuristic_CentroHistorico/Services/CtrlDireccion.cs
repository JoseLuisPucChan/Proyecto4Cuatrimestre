using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WSMCTuristic_CentroHistorico.Services
{
    public class CtrlDireccion
    {
        DAO.DireccionDAO oDireccion;

        public int InsertarDireccion(object obj)
        {
            oDireccion = new DAO.DireccionDAO();
            return oDireccion.AgregarDireccion(obj);
        }

        public int ModificarDireccion(object obj)
        {
            oDireccion = new DAO.DireccionDAO();
            return oDireccion.ActualizarDireccion(obj);
        }

        public int EliminarDireccion(object obj)
        {
            oDireccion = new DAO.DireccionDAO();
            return oDireccion.EliminarDireccion(obj);
        }
    }
}