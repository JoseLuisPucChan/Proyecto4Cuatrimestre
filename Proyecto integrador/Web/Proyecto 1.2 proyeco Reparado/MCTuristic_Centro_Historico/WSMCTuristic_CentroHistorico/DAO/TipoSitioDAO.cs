using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace WSMCTuristic_CentroHistorico.DAO
{
    public class TipoSitioDAO
    {
        SqlCommand cmd;
        Conexion conn;
        BO.TipoSitioBO oTipoSitio;
        public int AgregarTipoSitio(object obj)
        {
            cmd = new SqlCommand();
            conn = new Conexion();
            oTipoSitio = (BO.TipoSitioBO)obj;

            cmd.Connection = conn.Establecer();
            cmd.CommandText = "insertar_tipositio";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@NombreSitio", SqlDbType.VarChar).Value = oTipoSitio.NombreSitio;
            cmd.Parameters.Add("@DescripcionSitio", SqlDbType.VarChar).Value = oTipoSitio.DescripcicionSitio;

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
            oTipoSitio = (BO.TipoSitioBO)obj;

            cmd.Connection = conn.Establecer();
            cmd.CommandText = "actualizar_tipositio";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@idTipoSitio", SqlDbType.Int).Value = oTipoSitio.IdTipoSitio;
            cmd.Parameters.Add("@NombreSitio", SqlDbType.VarChar).Value = oTipoSitio.NombreSitio;
            cmd.Parameters.Add("@DescripcionSitio", SqlDbType.VarChar).Value = oTipoSitio.DescripcicionSitio;


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

        public int EliminarTipoSitio(object obj)
        {
            cmd = new SqlCommand();
            conn = new Conexion();
            oTipoSitio = (BO.TipoSitioBO)obj;

            cmd.Connection = conn.Establecer();
            cmd.CommandText = "eliminar_tipositio";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@idTipoServicio", SqlDbType.Int).Value = oTipoSitio;

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
        //Agregue el dataset y el arreglo de esta tabla. Diosemir Nah
        public DataSet TipoSitioDS()
        {
            conn = new Conexion();
            string sql;
            sql = "EXEC primero12registros";
            return conn.TablaDS(sql);
        }
    }
}