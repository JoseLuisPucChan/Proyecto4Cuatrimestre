using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace WSMCTuristic_CentroHistorico.Services
{
    public class CtrlEvento
    {
        DAO.EventoDAO oEvento;
        public int InsertarEvento(object obj)
        {
            oEvento = new DAO.EventoDAO();
            return oEvento.InsertarEvento(obj);
        }

        public int ModificarEvento(object obj)
        {
            oEvento = new DAO.EventoDAO();
            return oEvento.ModificarEvento(obj);
        }

        public int EliminarEvento(object obj)
        {
            oEvento = new DAO.EventoDAO();
            return oEvento.EliminarEvento(obj);
        }
        public DataSet topEventoDS()
        {
            oEvento = new DAO.EventoDAO();
            return oEvento.EventoDS();
        }
       
    }
}