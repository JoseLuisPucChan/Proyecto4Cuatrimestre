using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Reto3.DAO;
using System.Data;

namespace Reto3.Services
{
    public class AlumnoCTRL
    {
        AlumnoDAO datos = new AlumnoDAO();

        public int AgregarAlumno(object obj)
        {
            return datos.AgregarAlumno(obj);
        }

        public int DefinirCantidad(int cantidad)
        {
            return datos.DefinirCantidad(cantidad);
        }

        public int LeerCantidad()
        {
            return datos.LeerCantidad();
        }

        public DataTable BuscarAlumno()
        {
            return datos.BuscarAlumno();
        }

        public DataTable BuscarAlumno(int inicio, int fin)
        {
            return datos.BuscarAlumno(inicio, fin);
        }

        public DataSet BuscarAlumnoxml()
        {
            return datos.DatosXML();
        }


    }
}