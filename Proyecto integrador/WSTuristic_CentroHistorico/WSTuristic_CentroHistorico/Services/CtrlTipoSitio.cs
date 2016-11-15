using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WSTuristic_CentroHistorico.Services
{
    public class CtrlTipoSitio
    {
        DAO.TipoSitioDAO oTipoSitio;

        public int InsertarTipoSitio(object obj)
        {
            oTipoSitio = new DAO.TipoSitioDAO();
            return oTipoSitio.AgregarTipoSitio(obj);
        }

        public int ModificarTipoSitio(object obj)
        {
            oTipoSitio = new DAO.TipoSitioDAO();
            return oTipoSitio.ActualizarTipoSitio(obj);
        }

        public int EliminarTipoSitio(object obj)
        {
            oTipoSitio = new DAO.TipoSitioDAO();
            return oTipoSitio.EliminarTipoSitio(obj);
        }
    }
}