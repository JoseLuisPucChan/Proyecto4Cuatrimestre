using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WSMCTuristic_CentroHistorico.DAO
{
    public class AdministradorDAO
    {
        SqlCommand cmd;
        Conexion conn;
        BO.AdministradorBO oAdministrador;
        public int AgregarAdministrador(object obj)
        {
            cmd = new SqlCommand();
            conn = new Conexion();
            oAdministrador = (BO.AdministradorBO)obj;

            cmd.Connection = conn.Establecer();
            cmd.CommandText = "insertar_administrador";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = oAdministrador.NombreAdmin;
            cmd.Parameters.Add("@Apellidos", SqlDbType.VarChar).Value = oAdministrador.ApellidoAdmin;
            cmd.Parameters.Add("@Email", SqlDbType.VarChar).Value = oAdministrador.Email;
            cmd.Parameters.Add("@Contraseña", SqlDbType.VarChar).Value = oAdministrador.Contraseña;
            cmd.Parameters.Add("@TelefonoCelular", SqlDbType.VarChar).Value = oAdministrador.Telefono;
            cmd.Parameters.Add("@FechaNacimiento", SqlDbType.Date).Value = oAdministrador.FechaNacimiento;


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

        public int ActualizarAdministrador(object obj)
        {
            cmd = new SqlCommand();
            conn = new Conexion();
            oAdministrador = (BO.AdministradorBO)obj;

            cmd.Connection = conn.Establecer();
            cmd.CommandText = "actualizar_administrador";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@IdAdminstrador ", SqlDbType.Int).Value = oAdministrador.IdAdmin;
            cmd.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = oAdministrador.NombreAdmin;
            cmd.Parameters.Add("@Apellidos", SqlDbType.VarChar).Value = oAdministrador.ApellidoAdmin;
            cmd.Parameters.Add("@Email", SqlDbType.VarChar).Value = oAdministrador.Email;
            cmd.Parameters.Add("@Contraseña", SqlDbType.VarChar).Value = oAdministrador.Contraseña;
            cmd.Parameters.Add("@TelefonoCelular", SqlDbType.VarChar).Value = oAdministrador.Telefono;
            cmd.Parameters.Add("@FechaNacimiento", SqlDbType.Date).Value = oAdministrador.FechaNacimiento;


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

        public int EliminarAdministrador(object obj)
        {
            cmd = new SqlCommand();
            conn = new Conexion();
            oAdministrador = (BO.AdministradorBO)obj;

            cmd.Connection = conn.Establecer();
            cmd.CommandText = "eliminar_administrador";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@IdAdministradoe ", SqlDbType.Int).Value = oAdministrador.IdAdmin;

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