using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace Reto3.DAO
{
    public class ConexionDAO
    {
        SqlConnection conn;

        public SqlConnection ConexionBD()
        {
            string cadena = "Data source=ANDRE-PC\\SQLSERVER; Initial Catalog=Reto3_DA;Integrated Security=true ";
            conn = new SqlConnection(cadena);
            return conn;
        }

        public void abrirConex()
        {
            conn.Open();
        }

        public void CerrarConex()
        {
            conn.Close();
        }

        public int Ejecutar(string sql)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = ConexionBD();
            abrirConex();
            cmd.CommandText = sql;

            int i = cmd.ExecuteNonQuery();
            if (i <= 0)
            {
                return 0;
            }
            return 1;
        }

        public DataTable Tabla(string sql)
        {
            SqlDataAdapter Da = new SqlDataAdapter(sql, ConexionBD());
            DataTable nueva = new DataTable();
            Da.Fill(nueva);
            return nueva;
        }

        public DataSet Tablaxml(string sql)
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = sql;
            command.CommandType = CommandType.Text;
            command.Connection = ConexionBD();
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataSet ds = new DataSet();
            da.Fill(ds, "Alumnos");
            return ds;
        }

        public int RecuperarValores(string sql)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = ConexionBD();
            abrirConex();
            cmd.CommandText = sql;
            SqlDataReader sdr = cmd.ExecuteReader();
            if (sdr.Read())
            {
                return Convert.ToInt32(sdr[0].ToString());
            }
            return 0;
        }


    }
}