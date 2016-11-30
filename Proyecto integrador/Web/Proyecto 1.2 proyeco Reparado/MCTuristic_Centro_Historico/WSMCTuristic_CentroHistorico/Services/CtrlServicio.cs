using System;
using System.Collections.Generic;
using System.Data;
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
        public DataSet topServicios_user()
        {
            oServicio = new DAO.ServicioDAO();
            return oServicio.Servicio_userDS();
        }
        public DataSet topServicios_admin()
        {
            oServicio = new DAO.ServicioDAO();
            return oServicio.Servicio_adminDS();
        }
        public byte[] verfoto(int id)
        {
            oServicio = new DAO.ServicioDAO();
            return oServicio.verFoto_User(id);
        }
    }
}