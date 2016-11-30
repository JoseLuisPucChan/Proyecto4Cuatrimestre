using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Reto3.BO;
using System.Data;

namespace Reto3.DAO
{
    public class AlumnoDAO
    {
        ConexionDAO Conexion = new ConexionDAO();
        string sql;

        public int AgregarAlumno(object obj)
        {
            AlumnoBO oAlumno = (AlumnoBO)obj;
            sql = "exec AgregarAlumno '" + oAlumno.Nombre + "', " + oAlumno.Semestre + ", '" + oAlumno.Grupo + "', '" + oAlumno.Curp + "'";
            return Conexion.Ejecutar(sql);
        }

        public int DefinirCantidad(int cantidad)
        {
            sql = "exec DefinirCantidad " + cantidad;
            return Conexion.Ejecutar(sql);
        }

        public int LeerCantidad()
        {
            sql = "exec LeerCantidad";
            return Conexion.RecuperarValores(sql);
        }

        public DataTable BuscarAlumno()
        {
            sql = "exec BuscarAlumno";
            return Conexion.Tabla(sql);
        }

        public DataTable BuscarAlumno(int inicio, int fin)
        {
            sql = "exec BuscarAlumnoRango " + inicio + ", " + fin;
            return Conexion.Tabla(sql);
        }

        public DataSet DatosXML()
        {
            sql = "exec BuscarAlumno";
            return Conexion.Tablaxml(sql);

        }

    }
}