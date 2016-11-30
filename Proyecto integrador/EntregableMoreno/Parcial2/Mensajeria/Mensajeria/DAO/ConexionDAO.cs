
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Mensajeria.DAO
{
    class ConexionDAO
    {
        SqlConnection conn ;
        string sql;
        public SqlConnection ConexionBD ()
        {
            sql = "Data source = DIOSEMIR\\DIOSEMIRNAH; Initial Catalog=Mensajeria; Integrated Security=True";
            conn = new SqlConnection(sql);
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
    }
}
