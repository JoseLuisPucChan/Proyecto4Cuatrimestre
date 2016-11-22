using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace WSMCTuristic_CentroHistorico.DAO
{
    public class SuscripcionDAO
    {
        SqlCommand cmd;
        Conexion conn;
        BO.SuscripcionBO oSuscripcion;
        public int AgregarSuscripcion(object obj)
        {
            cmd = new SqlCommand();
            conn = new Conexion();
            oSuscripcion = (BO.SuscripcionBO)obj;

            cmd.Connection = conn.Establecer();
            cmd.CommandText = "insertar_Suscripcion";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@idSuscripcion ", SqlDbType.Int).Value = oSuscripcion.IdSuscripcion;
            cmd.Parameters.Add("@FechaPago", SqlDbType.Date).Value = oSuscripcion.FechaPago;
            cmd.Parameters.Add("@IdUsuario", SqlDbType.Int).Value = oSuscripcion.IdUsuario;




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

        public int ActualizarSuscripcion(object obj)
        {
            cmd = new SqlCommand();
            conn = new Conexion();
            oSuscripcion = (BO.SuscripcionBO)obj;

            cmd.Connection = conn.Establecer();
            cmd.CommandText = "actualizar_Suscripcion";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@idSuscripcion ", SqlDbType.Int).Value = oSuscripcion.IdSuscripcion;
            cmd.Parameters.Add("@FechaPago", SqlDbType.Date).Value = oSuscripcion.FechaPago;
            cmd.Parameters.Add("@IdUsuario", SqlDbType.Int).Value = oSuscripcion.IdUsuario;


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

        public int EliminarSuscripcion(object obj)
        {
            cmd = new SqlCommand();
            conn = new Conexion();
            oSuscripcion = (BO.SuscripcionBO)obj;

            cmd.Connection = conn.Establecer();
            cmd.CommandText = "eliminar_suscripcion";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@idSuscripcion ", SqlDbType.Int).Value = oSuscripcion.IdSuscripcion;

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