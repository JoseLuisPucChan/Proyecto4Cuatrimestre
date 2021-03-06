﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WSMCTuristic_Centro_Historico.DAO
{
    public class Usuario
    {
        SqlCommand cmd;
        conexion conn;
        BO.Usuario oUsuario;

        public int InsertarUsuario(object obj)
        {
            cmd = new SqlCommand();
            conn = new conexion();
            oUsuario = (BO.Usuario)obj;

            cmd.Connection = conn.Establecer();
            cmd.CommandText = "insertar_usuario";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = oUsuario.NombreUsuario;
            cmd.Parameters.Add("@Apellidos", SqlDbType.VarChar).Value = oUsuario.ApellidosUsuario;
            cmd.Parameters.Add("@Email", SqlDbType.VarChar).Value = oUsuario.EmailUsuario;
            cmd.Parameters.Add("@Contrasena", SqlDbType.VarChar).Value = oUsuario.ContraseñaUsuario;
            cmd.Parameters.Add("@TelefonoCelular", SqlDbType.VarChar).Value = oUsuario.TelefonoUsuario;
            cmd.Parameters.Add("@FechaNacimiento", SqlDbType.Date).Value = oUsuario.FecharNacUsuario;

            conn.Abrir();
            int retorno = cmd.ExecuteNonQuery();

            if (retorno <= 0)
            {
                retorno = 0;
            }
            else
            {
                retorno = 1;
            }

            return retorno;
        }

        public int ModificarUsuario(object obj)
        {
            cmd = new SqlCommand();
            conn = new conexion();
            oUsuario = (BO.Usuario)obj;

            cmd.Connection = conn.Establecer();
            cmd.CommandText = "actualizar_usuario";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@IdUsuario", SqlDbType.Int).Value = oUsuario.IdUsuario;
            cmd.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = oUsuario.NombreUsuario;
            cmd.Parameters.Add("@Apellidos", SqlDbType.VarChar).Value = oUsuario.ApellidosUsuario;
            cmd.Parameters.Add("@Email", SqlDbType.VarChar).Value = oUsuario.EmailUsuario;
            cmd.Parameters.Add("@Contrasena", SqlDbType.VarChar).Value = oUsuario.ContraseñaUsuario;
            cmd.Parameters.Add("@TelefonoCelular", SqlDbType.VarChar).Value = oUsuario.TelefonoUsuario;
            cmd.Parameters.Add("@FechaNacimiento", SqlDbType.Date).Value = oUsuario.FecharNacUsuario;

            conn.Abrir();
            int retorno = cmd.ExecuteNonQuery();

            if (retorno <= 0)
            {
                retorno = 0;
            }
            else
            {
                retorno = 1;
            }

            return retorno;
        }

        public int EliminarUsuario(object obj)
        {
            cmd = new SqlCommand();
            conn = new conexion();
            oUsuario = (BO.Usuario)obj;

            cmd.Connection = conn.Establecer();
            cmd.CommandText = "actualizar_usuario";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@IdUsuario", SqlDbType.Int).Value = oUsuario.IdUsuario;

            conn.Abrir();
            int retorno = cmd.ExecuteNonQuery();

            if (retorno <= 0)
            {
                retorno = 0;
            }
            else
            {
                retorno = 1;
            }

            return retorno;
        }

    }
}