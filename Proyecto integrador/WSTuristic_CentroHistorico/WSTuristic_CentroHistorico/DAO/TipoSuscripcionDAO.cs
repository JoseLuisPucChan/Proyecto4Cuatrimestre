using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace WSTuristic_CentroHistorico.DAO
{
    public class TipoSuscripcionDAO
    {
        SqlCommand cmd;
        Conexion conn;
        BO.TipoSuscripcionBO oTipoSuscripcion;
        public int AgregarTipoSuscripcion(object obj)
        {
            cmd = new SqlCommand();
            conn = new Conexion();
            oTipoSuscripcion = (BO.TipoSuscripcionBO)obj;

            cmd.Connection = conn.Establecer();
            cmd.CommandText = "insertar_tiposuscripcion";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = oTipoSuscripcion.NombreTipoSuscri;
            cmd.Parameters.Add("@Monto", SqlDbType.Decimal).Value = oTipoSuscripcion.MontoSuscripcion;
            cmd.Parameters.Add("@TiempoSuscripcion", SqlDbType.Int).Value = oTipoSuscripcion.TiempoSuscripcion;

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

        public int ActualizarTipoSuscripcion(object obj)
        {
            cmd = new SqlCommand();
            conn = new Conexion();
            oTipoSuscripcion = (BO.TipoSuscripcionBO)obj;

            cmd.Connection = conn.Establecer();
            cmd.CommandText = "actualizar_tiposuscripcion";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@idSuscripcion", SqlDbType.Int).Value = oTipoSuscripcion.IdTipoSuscripcion;
            cmd.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = oTipoSuscripcion.NombreTipoSuscri;
            cmd.Parameters.Add("@Monto", SqlDbType.Decimal).Value = oTipoSuscripcion.MontoSuscripcion;
            cmd.Parameters.Add("@TiempoSuscripcion", SqlDbType.Int).Value = oTipoSuscripcion.TiempoSuscripcion;

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

        public int EliminarTipoSuscripcion(object obj)
        {
            cmd = new SqlCommand();
            conn = new Conexion();
            oTipoSuscripcion = (BO.TipoSuscripcionBO)obj;

            cmd.Connection = conn.Establecer();
            cmd.CommandText = "eliminar_tiposuscripcion";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@idSuscripcion", SqlDbType.Int).Value = oTipoSuscripcion.IdTipoSuscripcion;

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