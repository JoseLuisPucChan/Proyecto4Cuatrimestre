using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace WSMCTuristic_CentroHistorico.Services
{
    public class CtrlTipoServicio
    {
        DAO.TipoServicioDAO oTipoServicio;

        public int InsertarTipoServicio(object obj)
        {
            oTipoServicio = new DAO.TipoServicioDAO();
            return oTipoServicio.AgregarTipoServicio(obj);
        }

        public int ModificarTipoServicio(object obj)
        {
            oTipoServicio = new DAO.TipoServicioDAO();
            return oTipoServicio.ActualizarTipoSitio(obj);
        }

        public int EliminarTipoServicio(object obj)
        {
            oTipoServicio = new DAO.TipoServicioDAO();
            return oTipoServicio.EliminarTipoServicio(obj);
        }
        public DataSet topTipoServicios()
        {
            oTipoServicio = new DAO.TipoServicioDAO();
            return oTipoServicio.TipoServicioDS();
        }
       
    }
}