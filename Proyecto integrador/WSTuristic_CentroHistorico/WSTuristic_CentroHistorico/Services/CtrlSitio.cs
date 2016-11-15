using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WSTuristic_CentroHistorico.Services
{
    public class CtrlSitio
    {
        DAO.SitioDAO oSitio;
        public int InsertarSitio(object obj)
        {
            oSitio = new DAO.SitioDAO();
            return oSitio.AgregarSitio(obj);
        }

        public int ModificarSitio(object obj)
        {
            oSitio = new DAO.SitioDAO();
            return oSitio.ActualizarSitio(obj);
        }

        public int EliminarSitio(object obj)
        {
            oSitio = new DAO.SitioDAO();
            return oSitio.EliminarSitio(obj);
        }
    }
}