using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTM.SQLite.DAO;

namespace UTM.SQLite.Service
{
    public class AlumnoCtrl
    {
        AlumnoDao oAlumnoDao = new AlumnoDao();

        public DataSet devuelveAlumno(object obj)
        {
            DataSet ds = new DataSet();
            ds = oAlumnoDao.devuelveAlumno(obj);
            return ds;
        }

        public int creaAlumno(object obj)
        {
            int i = oAlumnoDao.creaAlumno(obj);
            if (i <= 0)
            {
                return 0;
            }
            return 1;
        }

        public int modificaAlumno(object obj)
        {
            int i = oAlumnoDao.modificaAlumno(obj);
            if (i <= 0)
            {
                return 0;
            }
            return 1;
        }

        public int eliminaAlumno(object obj)
        {
            int i = oAlumnoDao.eliminaAlumno(obj);
            if (i <= 0)
            {
                return 0;
            }
            return 1;
        }
       
    }

}
