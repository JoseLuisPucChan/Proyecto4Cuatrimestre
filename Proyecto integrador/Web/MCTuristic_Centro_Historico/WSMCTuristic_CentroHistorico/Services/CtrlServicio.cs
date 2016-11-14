using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WSMCTuristic_CentroHistorico.Services
{
    public class CtrlServicio
    {
        DAO.ServicioDAO oServicio;

        public int InsertarServicio(object obj)
        {
            oServicio = new DAO.ServicioDAO();
            return oServicio.insertarServicio(obj);
        }


        public int ModificarServicio(object obj)
        {
            oServicio = new DAO.ServicioDAO();
            return oServicio.ModificarServicio(obj);
        }

        public int EliminarServicio(object obj)
        {
            oServicio = new DAO.ServicioDAO();
            return oServicio.EliminarServicio(obj);
        }

    }
}