﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WSMCTuristic_CentroHistorico.Services
{
    public class CtrlUsuario
    {
        DAO.UsuarioDAO oUsuario;
        public int InsertarUsuario(object obj)
        {
            oUsuario = new DAO.UsuarioDAO();
            return oUsuario.InsertarUsuario(obj);
        }

        public int ModificarUsuario(object obj)
        {
            oUsuario = new DAO.UsuarioDAO();
            return oUsuario.ModificarUsuario(obj);
        }

        public int EliminarUsuario(object obj)
        {
            oUsuario = new DAO.UsuarioDAO();
            return oUsuario.EliminarUsuario(obj);
        }
    }
}