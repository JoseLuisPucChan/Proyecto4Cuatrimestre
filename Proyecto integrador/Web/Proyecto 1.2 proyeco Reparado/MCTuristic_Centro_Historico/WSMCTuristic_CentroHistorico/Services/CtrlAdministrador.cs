using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace WSMCTuristic_CentroHistorico.Services
{
    public class CtrlAdministrador
    {
        DAO.AdministradorDAO oAdministrador;
        public int InsertarAdministrador(object obj)
        {
            oAdministrador = new DAO.AdministradorDAO();
            return oAdministrador.AgregarAdministrador(obj);
        }

        public int ModificarAdministrador(object obj)
        {
            oAdministrador = new DAO.AdministradorDAO();
            return oAdministrador.ActualizarAdministrador(obj);
        }

        public int EliminarAdministrador(object obj)
        {
            oAdministrador = new DAO.AdministradorDAO();
            return oAdministrador.EliminarAdministrador(obj);
        }


        public DataTable LoginUsuario(object obj)
        {
            oAdministrador = new DAO.AdministradorDAO();
            return oAdministrador.Login(obj);
        }
        
        
    }
}