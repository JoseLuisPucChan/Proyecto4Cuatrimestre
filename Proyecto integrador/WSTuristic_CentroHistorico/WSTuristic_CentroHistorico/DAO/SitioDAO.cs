using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace WSTuristic_CentroHistorico.DAO
{
    public class SitioDAO
    {
        SqlCommand cmd;
        Conexion conn;
        BO.SitioBO oSitio;
        public int AgregarSitio(object obj)
        {
            cmd = new SqlCommand();
            conn = new Conexion();
            oSitio = (BO.SitioBO)obj;

            cmd.Connection = conn.Establecer();
            cmd.CommandText = "insertar_sitio";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = oSitio.NombreSitio;
            cmd.Parameters.Add("@Descripcion", SqlDbType.VarChar).Value = oSitio.DescripcionSitio;
            cmd.Parameters.Add("@Historia", SqlDbType.VarChar).Value = oSitio.Historia;
            cmd.Parameters.Add("@Direccion", SqlDbType.VarChar).Value = oSitio.Direccion;
            cmd.Parameters.Add("@Longitud", SqlDbType.Decimal).Value = oSitio.LongitudSitio;
            cmd.Parameters.Add("@Latitud", SqlDbType.Decimal).Value = oSitio.LatitudSitio;
            cmd.Parameters.Add("@Foto", SqlDbType.Image).Value = oSitio.FotoSitio;
            cmd.Parameters.Add("@SucesosImp", SqlDbType.VarChar).Value = oSitio.SucesoImportante;
            cmd.Parameters.Add("@idTipoSitio", SqlDbType.Int).Value = oSitio.IdTipoSitio;

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

        public int ActualizarSitio(object obj)
        {
            cmd = new SqlCommand();
            conn = new Conexion();
            oSitio = (BO.SitioBO)obj;

            cmd.Connection = conn.Establecer();
            cmd.CommandText = "actualizar_sitio";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@IdSitio", SqlDbType.Int).Value = oSitio.IdSitio;
            cmd.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = oSitio.NombreSitio;
            cmd.Parameters.Add("@Descripcion", SqlDbType.VarChar).Value = oSitio.DescripcionSitio;
            cmd.Parameters.Add("@Historia", SqlDbType.VarChar).Value = oSitio.Historia;
            cmd.Parameters.Add("@Direccion", SqlDbType.VarChar).Value = oSitio.Direccion;
            cmd.Parameters.Add("@Longitud", SqlDbType.Decimal).Value = oSitio.LongitudSitio;
            cmd.Parameters.Add("@Latitud", SqlDbType.Decimal).Value = oSitio.LatitudSitio;
            cmd.Parameters.Add("@Foto", SqlDbType.Image).Value = oSitio.FotoSitio;
            cmd.Parameters.Add("@SucesosImp", SqlDbType.VarChar).Value = oSitio.SucesoImportante;
            cmd.Parameters.Add("@idTipoSitio", SqlDbType.Int).Value = oSitio.IdTipoSitio;

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

        public int EliminarSitio(object obj)
        {
            cmd = new SqlCommand();
            conn = new Conexion();
            oSitio = (BO.SitioBO)obj;

            cmd.Connection = conn.Establecer();
            cmd.CommandText = "eliminar_sitio";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@IdSitio", SqlDbType.Int).Value = oSitio.IdSitio;

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