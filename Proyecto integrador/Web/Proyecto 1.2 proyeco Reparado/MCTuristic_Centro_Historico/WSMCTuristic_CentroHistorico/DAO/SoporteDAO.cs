using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace WSMCTuristic_CentroHistorico.DAO
{
    public class SoporteDAO
    {
        SqlCommand cmd;
        Conexion conn;
        BO.SoporteBO oSoporte;
        public int AgregarSoporte(object obj)
        {
            cmd = new SqlCommand();
            conn = new Conexion();
            oSoporte = (BO.SoporteBO)obj;

            cmd.Connection = conn.Establecer();
            cmd.CommandText = "insertar_soporte";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@Comentario", SqlDbType.VarChar).Value = oSoporte.ComentarioSoporte;
            cmd.Parameters.Add("@Asunto", SqlDbType.VarChar).Value = oSoporte.Asunto;
            cmd.Parameters.Add("@IdUsuario", SqlDbType.Int).Value = oSoporte.IdUsuario;


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

        public int ActualizarSoporte(object obj)
        {
            cmd = new SqlCommand();
            conn = new Conexion();
            oSoporte = (BO.SoporteBO)obj;

            cmd.Connection = conn.Establecer();
            cmd.CommandText = "actualizar_soporte";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@idSoporte", SqlDbType.Int).Value = oSoporte.IdSoporte;
            cmd.Parameters.Add("@comentario", SqlDbType.VarChar).Value = oSoporte.ComentarioSoporte;
            cmd.Parameters.Add("@Asunto", SqlDbType.VarChar).Value = oSoporte.Asunto;
            cmd.Parameters.Add("@IdUsuario", SqlDbType.Int).Value = oSoporte.IdUsuario;

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

        public int EliminarSoporte(object obj)
        {
            cmd = new SqlCommand();
            conn = new Conexion();
            oSoporte = (BO.SoporteBO)obj;

            cmd.Connection = conn.Establecer();
            cmd.CommandText = "eliminar_soporte";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@idSoporte", SqlDbType.Int).Value = oSoporte.IdSoporte;

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