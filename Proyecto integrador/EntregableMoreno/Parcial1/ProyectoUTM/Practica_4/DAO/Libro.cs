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

    public class Libro
    {
        //------------Variables-------------
        DataSet ds;
        Conexion conn;
        string sql;
        SQLiteCommand cmd;
        SQLiteDataAdapter da;


        //---------Constructor--------------
        public Libro() { }
        
        //-----------Metodos----------------
    
            //-----Listar------
        public DataSet Listar(object obj)
        {
            BO.Libro LibroBO = (BO.Libro)obj;
            bool busqueda = false;
            string cadenaWhere = "";
            ds = new DataSet();
            conn = new Conexion();
            cmd = new SQLiteCommand();
            da = new SQLiteDataAdapter();

            if (LibroBO.Isbn != null)
            {
                cadenaWhere += " ISBN = '" + LibroBO.Isbn + "' and";
                busqueda = true;
            }

            if (LibroBO.Autor != null)
            {
                cadenaWhere += " Autor = '" + LibroBO.Autor + "' and";
                busqueda = true;
            }


            if (LibroBO.Editorial != null)
            {
                cadenaWhere += " Editorial = '" + LibroBO.Editorial + "' and";
                busqueda = true;
            }


            if (LibroBO.Precio > 0)
            {
                cadenaWhere += "Precio = '" + LibroBO.Precio + "' and";
                busqueda = true;
            }


            if (LibroBO.Imagen != null)
            {
                cadenaWhere += "Imagen = '" + LibroBO.Imagen + "' and";
                busqueda = true;
            }

            if (busqueda == true)
            {
                cadenaWhere = " WHERE " + cadenaWhere.Remove(cadenaWhere.Length - 3, 3);
            }

            
           
            try
            {
                sql = "SELECT * FROM Libro" + cadenaWhere ;
                cmd.CommandText = sql;
                cmd.Connection = conn.Establecer();
                conn.Abrir();              
                da.SelectCommand = cmd;
                da.Fill(ds);
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Cerrar();
            }
            

            return ds;
        }

        //-----Crear------

        public int creaLibro(object obj)
        {
            BO.Libro data = new BO.Libro();
            data = (BO.Libro)obj;
            cmd = new SQLiteCommand();
            ds = new DataSet();
            da = new SQLiteDataAdapter();
            conn = new Conexion();
            cmd.Connection = conn.Establecer();
            conn.Abrir();

            sql = "INSERT INTO Libro " +
            "VALUES('" +
            data.Isbn + "','" +
            data.Titulo + "','" +
            data.Autor.Trim() + "','" +
            data.Editorial + "','" +
            data.Precio.ToString() + "','" +
            data.Imagen + "')";
           
            cmd.CommandText = sql;

            int i = cmd.ExecuteNonQuery();

            if (i <= 0)
            {
                return 0;
            }
            return 1;
        }

        public int eliminaLibro(object obj)
        {

            BO.Libro data = (BO.Libro)obj;
            cmd = new SQLiteCommand();
            ds = new DataSet();
            da = new SQLiteDataAdapter();
            conn = new Conexion();
            cmd.Connection = conn.Establecer();
            conn.Abrir();
            sql = "DELETE FROM Libro WHERE ISBN = '" + data.Isbn.ToString() + "'";
            cmd.CommandText = sql;
            int i = cmd.ExecuteNonQuery();
            if (i <= 0)
            {
                return 0;
            }
            return 1;
        }

        public int modificaLibro(object obj)
        {
            BO.Libro data = (BO.Libro)obj;
            cmd = new SQLiteCommand();
            ds = new DataSet();
            da = new SQLiteDataAdapter();
            conn = new Conexion();
            cmd.Connection = conn.Establecer();
            conn.Abrir();


            sql = "UPDATE Libro SET Titulo ='" + data.Titulo.Trim() +
                "',Autor = '" + data.Autor.Trim() +
                "',Editorial = '" + data.Editorial.Trim() +
                "',Precio = '" + data.Precio +
                "',Imagen = '" + data.Imagen +                
                "' WHERE ISBN='" + data.Isbn + "'";
            cmd.CommandText = sql;
            int i = cmd.ExecuteNonQuery();
            if (i <= 0)
            {
                return 0;
            }
            return 1;
        }




    }








}
