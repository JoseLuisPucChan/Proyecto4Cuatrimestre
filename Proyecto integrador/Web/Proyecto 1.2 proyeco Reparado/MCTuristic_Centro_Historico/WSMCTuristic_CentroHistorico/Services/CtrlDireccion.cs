using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

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
<<<<<<< HEAD
        public DataSet topDireccionDS()
        {
            oDireccion = new DAO.DireccionDAO();
            return oDireccion.DireccionDS();
        }
        
=======

        public int InsertarDireccion_admin(object obj)
        {
            oDireccion = new DAO.DireccionDAO();
            return oDireccion.AgregarDireccion_admin(obj);
        }

        public int ModificarDireccion_admin(object obj)
        {
            oDireccion = new DAO.DireccionDAO();
            return oDireccion.ActualizarDireccion_admin(obj);
        }

>>>>>>> origin/master
    }
}