﻿using System;

using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WSMCTuristic_CentroHistorico.DAO
{
    public class Conexion
    {
        string sql;
        SqlConnection conn = new SqlConnection();

        public SqlConnection Establecer()
        {
            //sql = "Data source = ANDRE-PC\\SQLSERVER; Initial Catalog=MCTuristic; Integrated Security=True";
            sql = "Data source =192.168.100.4; Initial Catalog=MCTuristic;User id=user;password=1234";
            conn = new SqlConnection(sql);
            return conn;
        }

        public void Abrir()
        {
            conn.Open();
        }

        public void Cerrar()
        {
            conn.Close();
        }
    }
}