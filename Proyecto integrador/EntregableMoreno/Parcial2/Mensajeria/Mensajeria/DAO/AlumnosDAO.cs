using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Mensajeria.BO;
namespace Mensajeria.DAO
{
    class AlumnosDAO
    {
        ConexionDAO BD = new ConexionDAO();
        string sql;
        
        public DataTable ValidarAlumnos(object obj)
        {
            Alumnos Alumno = (Alumnos)obj;
            sql = "EXEC validarEntrada '" + Alumno.Usuario + "' , '" + Alumno.Contra + "'";
            return BD.Tabla(sql);
        }
        public DataTable RecuperarAlumnos( )
        {
            sql = "EXEC DevolverTablaAlumnos";
            return BD.Tabla(sql);
        }
        public int AgregarAlumnos(object obj)
        {
            Alumnos Alumno = (Alumnos)obj;
            sql = "EXEC AgregarAlumno '"+ Alumno.Usuario+ "','" + Alumno.Nombre+ "'," + Alumno.Semestre + ",'" + Alumno.Contra + "'";
            return BD.Ejecutar(sql);
        }
        public int EliminarAlumno(object obj)
        {
            Alumnos Alumno = (Alumnos)obj;
            sql = "EXEC EliminarAlumno " + Alumno.Matricula + "";
            return BD.Ejecutar(sql);
        }
        public int ModificarAlumno(object obj)
        {
            Alumnos Alumno = (Alumnos)obj;
            sql = "EXEC ModifcarAlumno "+ Alumno.Matricula+", '" + Alumno.Usuario + "','" + Alumno.Nombre + "'," + Alumno.Semestre + ",'" + Alumno.Contra + "'";
            return BD.Ejecutar(sql);
        }
        public DataTable BuscarAlumno(object obj)
        {
            Alumnos Alumno = (Alumnos)obj;
            sql = "EXEC FiltrarAlumno " + Alumno.Matricula + ", '" + Alumno.Usuario + "','" + Alumno.Nombre + "'," + Alumno.Semestre + "";
            return BD.Tabla(sql);
        }

    }
}
