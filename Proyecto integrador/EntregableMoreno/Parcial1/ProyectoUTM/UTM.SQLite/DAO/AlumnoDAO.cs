using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using UTM.SQLite.BO;

namespace UTM.SQLite.DAO
{
    public class AlumnoDao
    {
        Conexion con;
        DataSet dsAlumno = null;
        string sql;
        SQLiteCommand cmd;
        SQLiteDataAdapter da;

        public AlumnoDao()
        {

        }
        public DataSet devuelveAlumno(object obj)
        {
            string cadenaWhere = "";
            bool edo = false;
            AlumnoBO data = (AlumnoBO)obj;
            cmd = new SQLiteCommand();
            dsAlumno = new DataSet();
            da = new SQLiteDataAdapter();
            con = new Conexion();
            cmd.Connection = con.establecerConexion();
            con.abrirConexion();


            if (data.Matricula > 0)
            {
                cadenaWhere = cadenaWhere + " matricula=" + data.Matricula + " and";
                edo = true;
            }
            if (data.Nombre != null)
            {
                cadenaWhere = cadenaWhere + " Nombre='" + data.Nombre.Trim() + "' and";
                edo = true;
            }
            if (data.Apellidopaterno != null)
            {

                cadenaWhere = cadenaWhere + " Apellidopaterno='" + data.Apellidopaterno.Trim() + "' and";
                edo = true;
            }
            if (data.Apellidomaterno != null)
            {

                cadenaWhere = cadenaWhere + " Apellidomaterno='" + data.Apellidomaterno.Trim() + "' and";
                edo = true;
            }
            if (data.Direccion != null)
            {

                cadenaWhere = " Direccion='" + data.Direccion.Trim() + "' and";
                edo = true;
            }
            if (data.Telefono != null)
            {

                cadenaWhere = " Telefono='" + data.Telefono.Trim() + "' and";
                edo = true;
            }
            if (data.Grado > 0)
            {

                cadenaWhere = cadenaWhere + " Grado=" + data.Grado + " and";
                edo = true;
            }
            if (data.Grupo != null)
            {

                cadenaWhere = cadenaWhere + " Grupo='" + data.Grupo.Trim() + "' and";
                edo = true;


            }

            if (edo == true)
            {
                cadenaWhere = " WHERE " + cadenaWhere.Remove(cadenaWhere.Length - 3, 3);
            }
            sql = " SELECT * FROM Alumno " + cadenaWhere;
            cmd.CommandText = sql;
            DataSet ds = new DataSet();
            da.SelectCommand = cmd;
            da.Fill(dsAlumno);
            con.cerrarConexion();
            return dsAlumno;
        }
        public int creaAlumno(object obj)
        {

            AlumnoBO data = (AlumnoBO)obj;
            cmd = new SQLiteCommand();
            dsAlumno = new DataSet();
            da = new SQLiteDataAdapter();
            con = new Conexion();
            cmd.Connection = con.establecerConexion();
            con.abrirConexion();

            sql = "INSERT INTO Alumno(Nombre,ApellidoPaterno,ApellidoMaterno,Direccion,Telefono,Grado,Grupo)" +
            "VALUES('" +
            data.Nombre.Trim() + "','" +
            data.Apellidopaterno.Trim() + "','" +
            data.Apellidomaterno.Trim() + "','" +
            data.Direccion.Trim() + "','" +
            data.Telefono.ToString() + "','" +
            data.Grado.ToString() + "','" +
            data.Grupo.Trim() + "')";
            cmd.CommandText = sql;

            int i = cmd.ExecuteNonQuery();

            if (i <= 0)
            {
                return 0;
            }
            return 1;
        }
       
        public int eliminaAlumno(object obj)
        {

            AlumnoBO data = (AlumnoBO)obj;
            cmd = new SQLiteCommand();
            dsAlumno = new DataSet();
            da = new SQLiteDataAdapter();
            con = new Conexion();
            cmd.Connection = con.establecerConexion();
            con.abrirConexion();
            sql = "DELETE FROM Alumno WHERE Matricula=" + data.Matricula.ToString();
            cmd.CommandText = sql;
            int i = cmd.ExecuteNonQuery();
            if (i <= 0)
            {
                return 0;
            }
            return 1;
        }
        public int modificaAlumno(object obj)
        {
            AlumnoBO data = (AlumnoBO)obj;
            cmd = new SQLiteCommand();
            dsAlumno = new DataSet();
            da = new SQLiteDataAdapter();
            con = new Conexion();
            cmd.Connection = con.establecerConexion();
            con.abrirConexion();


            sql = "UPDATE Alumno SET Nombre='" + data.Nombre.Trim() + 
                "',ApellidoPaterno='" + data.Apellidopaterno.Trim() + 
                "',ApellidoMaterno='" + data.Apellidomaterno.Trim() + 
                "',Direccion='" + data.Direccion.Trim() + 
                "',Telefono='" + data.Telefono.Trim() + 
                "',Grado='" + data.Grado.ToString() + 
                "',Grupo='" + data.Grupo.Trim() + 
                "' WHERE Matricula='" + data.Matricula.ToString() + "'";
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
