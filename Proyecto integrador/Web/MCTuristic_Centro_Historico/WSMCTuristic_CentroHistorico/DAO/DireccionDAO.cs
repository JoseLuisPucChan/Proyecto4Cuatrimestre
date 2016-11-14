using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WSMCTuristic_CentroHistorico.DAO
{
    public class DireccionDAO
    {

        SqlCommand cmd;
        Conexion conn;
        BO.DireccionBO oDireccion;
        public int AgregarDireccion(object obj)
        {
            cmd = new SqlCommand();
            conn = new Conexion();
            oDireccion = (BO.DireccionBO)obj;

            cmd.Connection = conn.Establecer();
            cmd.CommandText = "insertar_direccion";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@Calle", SqlDbType.VarChar).Value = oDireccion.Calle;
            cmd.Parameters.Add("@Cruzamiento", SqlDbType.VarChar).Value = oDireccion.Cruzamiento;
            cmd.Parameters.Add("@Numero", SqlDbType.VarChar).Value = oDireccion.Numero;
            cmd.Parameters.Add("@Descripcion", SqlDbType.VarChar).Value = oDireccion.DescripcionDireccion;
            cmd.Parameters.Add("@Colonia", SqlDbType.VarChar).Value = oDireccion.Colonia;
            cmd.Parameters.Add("@Estado", SqlDbType.VarChar).Value = oDireccion.Estado;
            cmd.Parameters.Add("@CodPostal", SqlDbType.VarChar).Value = oDireccion.CodPostal;
            cmd.Parameters.Add("@IdUsuario", SqlDbType.Int).Value = oDireccion.IdUsuario;
            cmd.Parameters.Add("@IdAdministrador", SqlDbType.Int).Value = oDireccion.IdAdministrador;

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

        public int ActualizarDireccion(object obj)
        {
            cmd = new SqlCommand();
            conn = new Conexion();
            oDireccion = (BO.DireccionBO)obj;

            cmd.Connection = conn.Establecer();
            cmd.CommandText = "insertar_direccion";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@idDireccion", SqlDbType.Int).Value = oDireccion.Calle;
            cmd.Parameters.Add("@Calle", SqlDbType.VarChar).Value = oDireccion.Calle;
            cmd.Parameters.Add("@Cruzamiento", SqlDbType.VarChar).Value = oDireccion.Cruzamiento;
            cmd.Parameters.Add("@Numero", SqlDbType.VarChar).Value = oDireccion.Numero;
            cmd.Parameters.Add("@Descripcion", SqlDbType.VarChar).Value = oDireccion.DescripcionDireccion;
            cmd.Parameters.Add("@Colonia", SqlDbType.VarChar).Value = oDireccion.Colonia;
            cmd.Parameters.Add("@Estado", SqlDbType.VarChar).Value = oDireccion.Estado;
            cmd.Parameters.Add("@CodPostal", SqlDbType.VarChar).Value = oDireccion.CodPostal;
            cmd.Parameters.Add("@IdUsuario", SqlDbType.Int).Value = oDireccion.IdUsuario;
            cmd.Parameters.Add("@IdAdministrador", SqlDbType.Int).Value = oDireccion.IdAdministrador;

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

        public int EliminarDireccion(object obj)
        {
            cmd = new SqlCommand();
            conn = new Conexion();
            oDireccion = (BO.DireccionBO)obj;

            cmd.Connection = conn.Establecer();
            cmd.CommandText = "insertar_direccion";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@idDireccion", SqlDbType.Int).Value = oDireccion.Calle;

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