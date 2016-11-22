using System;
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
<<<<<<< HEAD
            sql = "Data source =DESKTOP-KDUDSML\\SQLEXPRESS; Initial Catalog=MCTuristic; Integrated Security=True";
=======
            sql = "Data source =192.168.100.7; Initial Catalog=MCTuristic; Integrated Security=true; user id = sa; password =1234";
>>>>>>> origin/master
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