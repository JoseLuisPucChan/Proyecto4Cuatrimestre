using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace WSMCTuristic_CentroHistorico.Services
{
    public class CtrlEstablecimiento
    {
        DAO.EstablecimientoDAO oEstablecimiento;
        public int insertarEstablecimiento(object obj)
        {
            oEstablecimiento = new DAO.EstablecimientoDAO();
            return oEstablecimiento.InsertarEstablecimiento(obj);
        }

        public int EliminarEstablecimiento(object obj)
        {
            oEstablecimiento = new DAO.EstablecimientoDAO();
            return oEstablecimiento.ElimianarEstablecimiento(obj);
        }

        public int ModificarEstablecimiento(object obj)
        {
            oEstablecimiento = new DAO.EstablecimientoDAO();
            return oEstablecimiento.ModificarEstablecimiento(obj);
        }
        public DataSet topEstablecimientos_userDS()
        {
            oEstablecimiento = new DAO.EstablecimientoDAO();
            return oEstablecimiento.Establecimiento_UserDS();
        }
        public DataSet topEstablecimientos_adminDS()
        {
            oEstablecimiento = new DAO.EstablecimientoDAO();
            return oEstablecimiento.Establecimiento_AdminDS();
        }
        
    }
}