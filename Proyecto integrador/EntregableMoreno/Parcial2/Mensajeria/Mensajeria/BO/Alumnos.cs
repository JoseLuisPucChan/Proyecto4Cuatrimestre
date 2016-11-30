using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mensajeria.BO
{
    class Alumnos
    {
        string matricula;
        string usuario;
        string nombre;
        int semestre;
        string contra;

        public string Contra
        {
            get
            {
                return contra;
            }

            set
            {
                contra = value;
            }
        }

        public string Usuario
        {
            get
            {
                return usuario;
            }

            set
            {
                usuario = value;
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

    

        public string Matricula
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
    }
}
