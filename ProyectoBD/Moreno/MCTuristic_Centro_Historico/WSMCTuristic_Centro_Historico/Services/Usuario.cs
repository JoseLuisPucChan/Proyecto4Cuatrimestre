using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WSMCTuristic_Centro_Historico.Services
{
    public class Usuario
    {
        DAO.Usuario oUsuario;
        public int InsertarUsuario(object obj)
        {
            oUsuario = new DAO.Usuario();
            return oUsuario.InsertarUsuario(obj);
        }

        public int ModificarUsuario(object obj)
        {
            oUsuario = new DAO.Usuario();
            return oUsuario.ModificarUsuario(obj);
        }

        public int EliminarUsuario(object obj)
        {
            oUsuario = new DAO.Usuario();
            return oUsuario.EliminarUsuario(obj);
        }

    }
}