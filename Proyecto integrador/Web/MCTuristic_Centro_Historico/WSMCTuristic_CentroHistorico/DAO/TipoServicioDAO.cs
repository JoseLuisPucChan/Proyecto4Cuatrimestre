using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace WSMCTuristic_CentroHistorico.DAO
{
    public class TipoServicioDAO
    {
        SqlCommand cmd;
        Conexion conn;
        BO.TipoServicioBO oTipoServicio;
        public int AgregarTipoServicio(object obj)
        {
            cmd = new SqlCommand();
            conn = new Conexion();
            oTipoServicio = (BO.TipoServicioBO)obj;

            cmd.Connection = conn.Establecer();
            cmd.CommandText = "insertar_tiposervicio";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@NombreServicio", SqlDbType.VarChar).Value = oTipoServicio.NombreServicio;

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

        public int ActualizarTipoSitio(object obj)
        {
            cmd = new SqlCommand();
            conn = new Conexion();
            oTipoServicio = (BO.TipoServicioBO)obj;

            cmd.Connection = conn.Establecer();
            cmd.CommandText = "actualizar_tiposervicio";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@idTipoServ", SqlDbType.Int).Value = oTipoServicio.IdTipoServicio;
            cmd.Parameters.Add("@NombreServicio", SqlDbType.VarChar).Value = oTipoServicio.NombreServicio;


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

        public int EliminarTipoServicio(object obj)
        {
            cmd = new SqlCommand();
            conn = new Conexion();
            oTipoServicio = (BO.TipoServicioBO)obj;

            cmd.Connection = conn.Establecer();
            cmd.CommandText = "eliminar_tiposervicio";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@idTipoServ", SqlDbType.Int).Value = oTipoServicio.IdTipoServicio;

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