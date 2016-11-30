using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WSMCTuristic_CentroHistorico.DAO
{
    public class EstablecimientoDAO
    {
        SqlCommand cmd;
        Conexion conn;
        BO.EstablecimientoBO oEstablecimiento;

        public int InsertarEstablecimiento(object obj)
        {
            cmd = new SqlCommand();
            conn = new Conexion();
            oEstablecimiento = (BO.EstablecimientoBO)obj;

            cmd.Connection = conn.Establecer();
            cmd.CommandText = "insertar_establecimiento";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@NomEstable", SqlDbType.VarChar).Value = oEstablecimiento.NombreEstable;
            cmd.Parameters.Add("@Telefono", SqlDbType.VarChar).Value = oEstablecimiento.TelefonoEstable;
            cmd.Parameters.Add("@HoraInicio", SqlDbType.VarChar).Value = oEstablecimiento.HoraInicioEstable;
            cmd.Parameters.Add("@HoraCierre", SqlDbType.VarChar).Value = oEstablecimiento.HoraCierreEstable;
            cmd.Parameters.Add("@PagFacebook", SqlDbType.VarChar).Value = oEstablecimiento.PagFacebook;
            cmd.Parameters.Add("@Longitud", SqlDbType.Decimal).Value = oEstablecimiento.Longitud;
            cmd.Parameters.Add("@Latitud", SqlDbType.Decimal).Value = oEstablecimiento.Latitud;
            cmd.Parameters.Add("@Foto", SqlDbType.Image).Value = oEstablecimiento.Foto;
            cmd.Parameters.Add("@IdUsuario", SqlDbType.Int).Value = oEstablecimiento.IdUsuario;

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

        public int ModificarEstablecimiento(object obj)
        {
            cmd = new SqlCommand();
            conn = new Conexion();
            oEstablecimiento = (BO.EstablecimientoBO)obj;

            cmd.Connection = conn.Establecer();
            cmd.CommandText = "actualizar_establecimiento";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@IdEstablecimiento", SqlDbType.Int).Value = oEstablecimiento.IdEstablecimiento;
            cmd.Parameters.Add("@NomEstable", SqlDbType.VarChar).Value = oEstablecimiento.NombreEstable;
            cmd.Parameters.Add("@Telefono", SqlDbType.VarChar).Value = oEstablecimiento.TelefonoEstable;
            cmd.Parameters.Add("@HoraInicio", SqlDbType.VarChar).Value = oEstablecimiento.HoraInicioEstable;
            cmd.Parameters.Add("@HoraCierre", SqlDbType.VarChar).Value = oEstablecimiento.HoraCierreEstable;
            cmd.Parameters.Add("@PagFacebook", SqlDbType.VarChar).Value = oEstablecimiento.PagFacebook;
            cmd.Parameters.Add("@Longitud", SqlDbType.Decimal).Value = oEstablecimiento.Longitud;
            cmd.Parameters.Add("@Latitud", SqlDbType.Decimal).Value = oEstablecimiento.Latitud;
            cmd.Parameters.Add("@Foto", SqlDbType.Image).Value = oEstablecimiento.Foto;
            cmd.Parameters.Add("@IdUsuario", SqlDbType.Int).Value = oEstablecimiento.IdUsuario;

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

        public int ElimianarEstablecimiento(object obj)
        {
            cmd = new SqlCommand();
            conn = new Conexion();
            oEstablecimiento = (BO.EstablecimientoBO)obj;

            cmd.Connection = conn.Establecer();
            cmd.CommandText = "eliminar_establecimiento";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@IdEstablecimiento", SqlDbType.Int).Value = oEstablecimiento.IdEstablecimiento;

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
        //Agregue el dataser y el metodo de imagen de esta tabla. Diosemir Nah
        public DataSet Establecimiento_UserDS()
        {
            conn = new Conexion();
            string sql;
            sql = "EXEC ver_establecimiento_user";
            return conn.TablaDS(sql);
        }
        public DataSet Establecimiento_AdminDS()
        {
            conn = new Conexion();
            string sql;
            sql = "EXEC ver_establecimiento_admin";
            return conn.TablaDS(sql);
        }
        
        
    }
}