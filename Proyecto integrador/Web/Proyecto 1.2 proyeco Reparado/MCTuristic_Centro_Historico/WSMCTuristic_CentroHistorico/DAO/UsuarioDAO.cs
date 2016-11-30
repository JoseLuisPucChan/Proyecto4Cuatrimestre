using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
namespace WSMCTuristic_CentroHistorico.DAO
{
    public class UsuarioDAO
    {
        SqlCommand cmd;
        Conexion conn;
        BO.UsuarioBO oUsuario;

        public int InsertarUsuario(object obj)
        {
            cmd = new SqlCommand();
            conn = new Conexion();
            oUsuario = (BO.UsuarioBO)obj;

            cmd.Connection = conn.Establecer();
            cmd.CommandText = "insertar_usuario";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = oUsuario.NombreUsuario;
            cmd.Parameters.Add("@Apellidos", SqlDbType.VarChar).Value = oUsuario.ApellidosUsuario;
            cmd.Parameters.Add("@Email", SqlDbType.VarChar).Value = oUsuario.EmailUsuario;
            cmd.Parameters.Add("@Contrasena", SqlDbType.VarChar).Value = oUsuario.ContraseñaUsuario;
            cmd.Parameters.Add("@TelefonoCelular", SqlDbType.VarChar).Value = oUsuario.TelefonoUsuario;
            cmd.Parameters.Add("@FechaNacimiento", SqlDbType.Date).Value = oUsuario.FecharNacUsuario;
            cmd.Parameters.Add("@Foto", SqlDbType.Image).Value = oUsuario.Foto;
            
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
            conn = new Conexion();
            oUsuario = (BO.UsuarioBO)obj;

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
            cmd.Parameters.Add("@Foto", SqlDbType.Image).Value = oUsuario.Foto;


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
            conn = new Conexion();
            oUsuario = (BO.UsuarioBO)obj;

            cmd.Connection = conn.Establecer();
            cmd.CommandText = "eliminar_usaurio";
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
        //Obtener el usuario que se acaba de agregar en la base de datos
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

        public DataTable Login(object obj)
        {
            BO.UsuarioBO oUsuario = (BO.UsuarioBO)obj;
            DataTable DtResultado = new DataTable("Usuario");
            try
            {
                cmd = new SqlCommand();
                conn = new Conexion();

                cmd.Connection = conn.Establecer();
                conn.Abrir();
                cmd.CommandText = "login_user";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter Usuario = new SqlParameter();
                Usuario.ParameterName = "@email";
                Usuario.SqlDbType = SqlDbType.VarChar;
                Usuario.Size = 50;
                Usuario.Value = oUsuario.EmailUsuario;
                cmd.Parameters.Add(Usuario);

                SqlParameter Password = new SqlParameter();
                Password.ParameterName = "@password";
                Password.SqlDbType = SqlDbType.VarChar;
                Password.Size = 20;
                Password.Value = oUsuario.ContraseñaUsuario;
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
        public DataSet Usuario_adminDS()
        {
            conn = new Conexion();
            string sql;
            sql = "EXEC ver_usuarios_admin";
            return conn.TablaDS(sql);
        }
        public DataSet Usuario_adminfiltradoDS()
        {
            conn = new Conexion();
            string sql;
            sql = "EXEC ver_usuario_admin_filtrado";
            return conn.TablaDS(sql);
        }
        public DataSet Usuario_userDS()
        {
            conn = new Conexion();
            string sql;
            sql = "EXEC ver_usuarios_user";
            return conn.TablaDS(sql);
        }
    }
}