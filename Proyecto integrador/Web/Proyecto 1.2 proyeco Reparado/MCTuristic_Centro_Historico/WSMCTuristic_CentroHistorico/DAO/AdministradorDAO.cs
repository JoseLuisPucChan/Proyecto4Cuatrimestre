using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WSMCTuristic_CentroHistorico.BO;
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

            cmd.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = oAdministrador.Nombreadmin;
            cmd.Parameters.Add("@Apellidos", SqlDbType.VarChar).Value = oAdministrador.Apellidosadmin;
            cmd.Parameters.Add("@Email", SqlDbType.VarChar).Value = oAdministrador.Email;
            cmd.Parameters.Add("@Contrasena", SqlDbType.VarChar).Value = oAdministrador.Contraseñaadmin;
            cmd.Parameters.Add("@TelefonoCelular", SqlDbType.VarChar).Value = oAdministrador.Telefonoadmin;
            cmd.Parameters.Add("@FechaNacimiento", SqlDbType.Date).Value = oAdministrador.Fechanacimiento;


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

            cmd.Parameters.Add("@IdAdminstrador ", SqlDbType.Int).Value = oAdministrador.IdAdministrador;
            cmd.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = oAdministrador.Nombreadmin;
            cmd.Parameters.Add("@Apellidos", SqlDbType.VarChar).Value = oAdministrador.Apellidosadmin;
            cmd.Parameters.Add("@Email", SqlDbType.VarChar).Value = oAdministrador.Email;
            cmd.Parameters.Add("@Contrasena", SqlDbType.VarChar).Value = oAdministrador.Contraseñaadmin;
            cmd.Parameters.Add("@TelefonoCelular", SqlDbType.VarChar).Value = oAdministrador.Telefonoadmin;
            cmd.Parameters.Add("@FechaNacimiento", SqlDbType.Date).Value = oAdministrador.Fechanacimiento;


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

            cmd.Parameters.Add("@IdAdministradoe ", SqlDbType.Int).Value = oAdministrador.IdAdministrador;

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
        public DataTable Login(object obj)
        {
            oAdministrador = (BO.AdministradorBO)obj;
            DataTable DtResultado = new DataTable("Administrador");
            try
            {
                cmd = new SqlCommand();
                conn = new Conexion();

                cmd.Connection = conn.Establecer();
                conn.Abrir();
                cmd.CommandText = "login_administrador";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter Usuario = new SqlParameter();
                Usuario.ParameterName = "@Email";
                Usuario.SqlDbType = SqlDbType.VarChar;
                Usuario.Size = 20;
                Usuario.Value = oAdministrador.Email;
                cmd.Parameters.Add(Usuario);

                SqlParameter Password = new SqlParameter();
                Password.ParameterName = "@Contrasena";
                Password.SqlDbType = SqlDbType.VarChar;
                Password.Size = 20;
                Password.Value = oAdministrador.Contraseñaadmin;
                cmd.Parameters.Add(Password);

                SqlDataAdapter SqlDat = new SqlDataAdapter(cmd);
                SqlDat.Fill(DtResultado);
            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;

        }
    }
}