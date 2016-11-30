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
                cmd.CommandText = "login_admin";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter Usuario = new SqlParameter();
                Usuario.ParameterName = "@email";
                Usuario.SqlDbType = SqlDbType.VarChar;
                Usuario.Size = 50;
                Usuario.Value = oAdministrador.Email;
                cmd.Parameters.Add(Usuario);

                SqlParameter Password = new SqlParameter();
                Password.ParameterName = "@password";
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

        //Agregue el dataset y el arreglo de esta tabla. Diosemir Nah
        public DataSet AdministradorDS()
        {
            conn = new Conexion();
            string sql;
            sql = "EXEC primero12registros";
            return conn.TablaDS(sql);
        }
        public DataSet ver_administradro_administradro()
        {
            conn = new Conexion();
            string sql;
            sql = "EXEC ver_admin_admin";
            return conn.TablaDS(sql);
        }

        public string Obtenerid_user()
        {
            string id = "";
            cmd = new SqlCommand();
            conn = new Conexion();
            cmd.Connection = conn.Establecer();
            cmd.CommandText = "usuario_reciente";
            cmd.CommandType = CommandType.StoredProcedure;
            conn.Abrir();
            SqlDataReader Leer = cmd.ExecuteReader();
            if (Leer.Read() == true)
            {
                id = Leer["Maximo"].ToString();
            }
            return id;
        }





    }
}