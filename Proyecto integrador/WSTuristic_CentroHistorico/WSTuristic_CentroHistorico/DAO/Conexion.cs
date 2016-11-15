using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace WSTuristic_CentroHistorico.DAO
{
    public class Conexion
    {
        string sql;
        SqlConnection conn = new SqlConnection();

        public SqlConnection Establecer()
        {
            sql = "Data source = DESKTOP-CPUP8RH\\SQLEXPRESS; Initial Catalog=BDMCTuristic; Integrated Security=True";
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