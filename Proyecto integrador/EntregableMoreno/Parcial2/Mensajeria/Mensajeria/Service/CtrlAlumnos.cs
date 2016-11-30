using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mensajeria.DAO;
using System.Data;

namespace Mensajeria.Service
{
    class CtrlAlumnos
    {
        AlumnosDAO alumnos = new AlumnosDAO();

        public DataTable ValidarEntrada(object obj)
        {
            return alumnos.ValidarAlumnos(obj);
        }
        public object Recuperar()
        {
            return alumnos.RecuperarAlumnos();
        }
        public int Agregar(object alumno)
        {
            return alumnos.AgregarAlumnos(alumno);
        }
        public int Eliminar(object alumno)
        {
            return alumnos.EliminarAlumno(alumno);
        }
        public int modificar(object alumno)
        {
            return alumnos.ModificarAlumno(alumno);
        }
        public DataTable Buscar(object alumno)
        {
            return alumnos.BuscarAlumno(alumno);
        }
    }
}
