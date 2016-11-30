using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTM.SQLite.BO
{
    public class AlumnoBO
    {
        int matricula;
        string nombre;
        string apellidoPaterno;
        string apellidoMaterno;
        string direccion;
        string telefono;
        int grado;
        string grupo;

        public AlumnoBO()
        {
        }

        public int Matricula
        {
            get { return this.matricula; }
            set { this.matricula = value; }
        }

        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        public string Apellidopaterno
        {
            get { return this.apellidoPaterno; }
            set { this.apellidoPaterno = value; }
        }

        public string Apellidomaterno
        {
            get { return this.apellidoMaterno; }
            set { this.apellidoMaterno = value; }
        }

        public string Direccion
        {
            get { return this.direccion; }
            set { this.direccion = value; }
        }

        public string Telefono
        {
            get { return this.telefono; }
            set { this.telefono = value; }
        }

        public int Grado
        {
            get { return this.grado; }
            set { this.grado = value; }
        }

        public string Grupo
        {
            get { return this.grupo; }
            set { this.grupo = value; }
        }


    }
}
