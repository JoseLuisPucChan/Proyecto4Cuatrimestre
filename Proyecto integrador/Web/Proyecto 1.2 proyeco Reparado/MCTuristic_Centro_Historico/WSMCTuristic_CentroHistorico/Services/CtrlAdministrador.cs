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
<<<<<<< HEAD
        //Agrege el data set a ctrl. Diosemir Nah
        public DataSet topAdministradorDS()
        {
            oAdministrador = new DAO.AdministradorDAO();
            return oAdministrador.AdministradorDS();
        }
=======
        public DataSet ver_admi_admin()
        {
            oAdministrador = new DAO.AdministradorDAO();
            return oAdministrador.ver_administradro_administradro();
        }
<<<<<<< HEAD

        public string id_admin()
        {
            string res = "";
            oAdministrador = new DAO.AdministradorDAO();
            res = oAdministrador.Obtenerid_admin();
            return res;
        }
=======
        
>>>>>>> origin/master
>>>>>>> parent of 46c46a8... Cambios
        
    }
}