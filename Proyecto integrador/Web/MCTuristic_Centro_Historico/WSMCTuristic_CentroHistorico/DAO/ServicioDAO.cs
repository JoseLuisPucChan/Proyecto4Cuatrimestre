﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WSMCTuristic_CentroHistorico.DAO
{
    public class ServicioDAO
    {
        SqlCommand cmd;
        Conexion conn;
        BO.ServicioBO oServicio;
        public int insertarServicio(object obj)
        {
            cmd = new SqlCommand();
            conn = new Conexion();
            oServicio = (BO.ServicioBO)obj;

            cmd.Connection = conn.Establecer();
            cmd.CommandText = "insertar_servicios";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@OfertaServicio", SqlDbType.VarChar).Value = oServicio.OfertaServicio;
            cmd.Parameters.Add("@PrecioServicio", SqlDbType.Decimal).Value = oServicio.PrecioServicio;
            cmd.Parameters.Add("@DescripServicio", SqlDbType.VarChar).Value = oServicio.DescripcionServicio;
            cmd.Parameters.Add("@idEstablecimiento", SqlDbType.Int).Value = oServicio.IdEstablecimiento;
            cmd.Parameters.Add("@idTipoServi", SqlDbType.Int).Value = oServicio.IdTipoServicio;


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

        public int ModificarServicio(object obj)
        {
            cmd = new SqlCommand();
            conn = new Conexion();
            oServicio = (BO.ServicioBO)obj;

            cmd.Connection = conn.Establecer();
            cmd.CommandText = "actualizar_servicios";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@idServicio", SqlDbType.Int).Value = oServicio.IdServicio;
            cmd.Parameters.Add("@OfertaServicio", SqlDbType.VarChar).Value = oServicio.OfertaServicio;
            cmd.Parameters.Add("@PrecioServicio", SqlDbType.Decimal).Value = oServicio.PrecioServicio;
            cmd.Parameters.Add("@DescripServicio", SqlDbType.VarChar).Value = oServicio.DescripcionServicio;
            cmd.Parameters.Add("@idEstablecimiento", SqlDbType.Int).Value = oServicio.IdEstablecimiento;
            cmd.Parameters.Add("@idTipoServi", SqlDbType.Int).Value = oServicio.IdTipoServicio;


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

        public int EliminarServicio(object obj)
        {
            cmd = new SqlCommand();
            conn = new Conexion();
            oServicio = (BO.ServicioBO)obj;

            cmd.Connection = conn.Establecer();
            cmd.CommandText = "eliminar_servicios";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@idServicio", SqlDbType.Int).Value = oServicio.IdServicio;

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