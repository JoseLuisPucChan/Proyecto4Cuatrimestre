using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WSMCTuristic_CentroHistorico.DAO
{
    public class ContactanosDAO
    {
        SqlCommand cmd;
        Conexion conn;
        BO.ContactanosBO oContactanos;
        public int AgregarContactanos(object obj)
        {
            cmd = new SqlCommand();
            conn = new Conexion();
            oContactanos = (BO.ContactanosBO)obj;

            cmd.Connection = conn.Establecer();
            cmd.CommandText = "insertar_contactanos";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = oContactanos.NombreContacto;
            cmd.Parameters.Add("@Apellidos", SqlDbType.VarChar).Value = oContactanos.ApellidoContacto;
            cmd.Parameters.Add("@Email", SqlDbType.VarChar).Value = oContactanos.EmailContacto;
            cmd.Parameters.Add("@Asunto", SqlDbType.VarChar).Value = oContactanos.Asunto;
            cmd.Parameters.Add("@Contenido", SqlDbType.VarChar).Value = oContactanos.Contenido;


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

        public int ActualizarContactanos(object obj)
        {
            cmd = new SqlCommand();
            conn = new Conexion();
            oContactanos = (BO.ContactanosBO)obj;

            cmd.Connection = conn.Establecer();
            cmd.CommandText = "actualizar_contactanos";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@IdContactanos ", SqlDbType.Int).Value = oContactanos.IdContactanos;
            cmd.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = oContactanos.NombreContacto;
            cmd.Parameters.Add("@Apellidos", SqlDbType.VarChar).Value = oContactanos.ApellidoContacto;
            cmd.Parameters.Add("@Email", SqlDbType.VarChar).Value = oContactanos.EmailContacto;
            cmd.Parameters.Add("@Asunto", SqlDbType.VarChar).Value = oContactanos.Asunto;
            cmd.Parameters.Add("@Contenido", SqlDbType.VarChar).Value = oContactanos.Contenido;


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

        public int EliminarContactanos(object obj)
        {
            cmd = new SqlCommand();
            conn = new Conexion();
            oContactanos = (BO.ContactanosBO)obj;

            cmd.Connection = conn.Establecer();
            cmd.CommandText = "eliminar_contantanos";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@IdContactanos ", SqlDbType.Int).Value = oContactanos.IdContactanos;

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