using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;
using System.Windows.Forms;



namespace DAO
{
   public class Conexion
    {
        //------------Variables-------------
        SQLiteConnection conn;

        //---------Constructor--------------

        public Conexion() { }
      

        //-----------Metodos----------------

        //-----Nueva Conexion-------
        public SQLiteConnection Establecer()
        {
            try
            {
                string RutaCompleta = Application.StartupPath.ToString();
                string Ruta = RutaCompleta.Substring(0, RutaCompleta.Length - 5) + "BDBiblioteca3.db";
               // string Ruta = RutaCompleta.Substring(0, RutaCompleta.Length - 5 ) + @"Debug\BDEstudiantes.db";
                string cs = "Data Source=" + Ruta + ";Version=3;New=False;Compress=True;";
                //conn = new SQLiteConnection("Data Source = " + Ruta + " ; Version = 3; New = False; Compress = True; ");
                conn = new SQLiteConnection(cs);

            }
            catch (SQLiteException ex)
            { 
               
            }

            return conn;


        }

        //-----Abrir conexion-------
        public void Abrir()
        {
            conn.Open();
        }

        //-----cerrar conexion-------
        public void Cerrar()
        {
            conn.Close();
        }



    }
}
