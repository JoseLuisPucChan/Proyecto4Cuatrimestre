using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WSTuristic_CentroHistorico.BO
{
    public class TipoSitioBO
    {
        private int _idTipoSitio;
        private string _nombreSitio;
        private string _descripcicionSitio;

        public string DescripcicionSitio
        {
            get { return _descripcicionSitio; }
            set { _descripcicionSitio = value; }
        }

        public string NombreSitio
        {
            get { return _nombreSitio; }
            set { _nombreSitio = value; }
        }

        public int IdTipoSitio
        {
            get { return _idTipoSitio; }
            set { _idTipoSitio = value; }
        }
    }
}