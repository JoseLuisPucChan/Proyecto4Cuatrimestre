using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WSTuristic_CentroHistorico.BO
{
    public class TipoServicioBO
    {
        private int _idTipoServicio;
        private string _nombreServicio;

        public string NombreServicio
        {
            get { return _nombreServicio; }
            set { _nombreServicio = value; }
        }

        public int IdTipoServicio
        {
            get { return _idTipoServicio; }
            set { _idTipoServicio = value; }
        }
    }
}