using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WSMCTuristic_CentroHistorico.Services
{
    public class CtrlContactanos
    {
        DAO.ContactanosDAO oContactanos;
        public int InsertarContactanos(object obj)
        {
            oContactanos = new DAO.ContactanosDAO();
            return oContactanos.AgregarContactanos(obj);
        }

        public int ModificarContactanos(object obj)
        {
            oContactanos = new DAO.ContactanosDAO();
            return oContactanos.ActualizarContactanos(obj);
        }

        public int EliminarContactanos(object obj)
        {
            oContactanos = new DAO.ContactanosDAO();
            return oContactanos.EliminarContactanos(obj);
        }
    }
}