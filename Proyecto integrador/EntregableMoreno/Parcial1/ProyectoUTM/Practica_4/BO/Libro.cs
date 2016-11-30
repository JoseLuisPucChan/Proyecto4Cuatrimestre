using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
   public class Libro
    {
        //---------------Variables-----------
        string isbn;
        string autor;
        string titulo;
        decimal precio;
        string editorial;
        string imagen;

      

        //-------------Constructor-------------
        public Libro() { }

        //------------Propiedades---------------

        public string Isbn
        {
            get
            {
                return isbn;
            }

            set
            {
                isbn = value;
            }
        }

        public string Autor
        {
            get
            {
                return autor;
            }

            set
            {
                autor = value;
            }
        }

        public string Titulo
        {
            get
            {
                return titulo;
            }

            set
            {
                titulo = value;
            }
        }

        public decimal Precio
        {
            get
            {
                return precio;
            }

            set
            {
                precio = value;
            }
        }

        public string Editorial
        {
            get
            {
                return editorial;
            }

            set
            {
                editorial = value;
            }
        }

        public string Imagen
        {
            get
            {
                return imagen;
            }

            set
            {
                imagen = value;
            }
        }






    }
}
