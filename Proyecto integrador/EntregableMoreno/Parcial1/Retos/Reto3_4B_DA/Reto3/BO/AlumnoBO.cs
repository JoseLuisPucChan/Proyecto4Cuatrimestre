using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Reto3.BO
{
    public class AlumnoBO
    {
        int matricula;
        string nombre;
        int semestre;
        string grupo;
        string curp;

        public int Matricula
        {
            get
            {
                return matricula;
            }

            set
            {
                matricula = value;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public int Semestre
        {
            get
            {
                return semestre;
            }

            set
            {
                semestre = value;
            }
        }

        public string Grupo
        {
            get
            {
                return grupo;
            }

            set
            {
                grupo = value;
            }
        }

        public string Curp
        {
            get
            {
                return curp;
            }

            set
            {
                curp = value;
            }
        }
    }
}