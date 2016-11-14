using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WSMCTuristic_CentroHistorico.DAO
{
    public class NotificacionesDAO
    {

        SqlCommand cmd;
        Conexion conn;
        BO.NotificacionesBO oNotificacionesBO;

        public int InstertarNotificacion(object obj)
        {
            cmd = new SqlCommand();
            conn = new Conexion();
            oNotificacionesBO = (BO.NotificacionesBO)obj;

            cmd.Connection = conn.Establecer();
            cmd.CommandText = "insertar_notificaciones";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@idEvento", SqlDbType.Int).Value = oNotificacionesBO.IdEvento;

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

        public int ModificarNotificacion(object obj)
        {
            cmd = new SqlCommand();
            conn = new Conexion();
            oNotificacionesBO = (BO.NotificacionesBO)obj;

            cmd.Connection = conn.Establecer();
            cmd.CommandText = "actualizar_notificaciones";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@idEvento", SqlDbType.Int).Value = oNotificacionesBO.IdEvento;
            cmd.Parameters.Add("@idNotificaciones", SqlDbType.Int).Value = oNotificacionesBO.IdNotificacion;

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


        public int EliminarNotificacion(object obj)
        {
            cmd = new SqlCommand();
            conn = new Conexion();
            oNotificacionesBO = (BO.NotificacionesBO)obj;

            cmd.Connection = conn.Establecer();
            cmd.CommandText = "eliminar_notificaciones";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@idNotificaciones", SqlDbType.Int).Value = oNotificacionesBO.IdNotificacion;

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