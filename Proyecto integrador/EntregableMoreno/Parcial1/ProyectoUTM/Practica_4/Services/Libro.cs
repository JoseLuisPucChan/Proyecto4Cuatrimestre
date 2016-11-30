using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Services
{

   public class Libro
    {
        DAO.Libro oLibroDAO ;

        //------------constructor--------
        public Libro() { }

        //-------------Metodos------------

        public DataSet ListarLibro(object obj)
        {
            DataSet ds = new DataSet();
            oLibroDAO = new DAO.Libro();
            ds = oLibroDAO.Listar(obj);
            return ds;           
        }


        public int creaLibro(object obj)
        {
            oLibroDAO = new DAO.Libro();

            int i = oLibroDAO.creaLibro(obj);
            if (i <= 0)
            {
                return 0;
            }
            return 1;
        }

        public int modificaLibro(object obj)
        {
            oLibroDAO = new DAO.Libro();

            int i = oLibroDAO.modificaLibro(obj);
            if (i <= 0)
            {
                return 0;
            }
            return 1;
        }

        public int eliminaLibro(object obj)
        {
            oLibroDAO = new DAO.Libro();

            int i = oLibroDAO.eliminaLibro(obj);
            if (i <= 0)
            {
                return 0;
            }
            return 1;
        }

    }
}
