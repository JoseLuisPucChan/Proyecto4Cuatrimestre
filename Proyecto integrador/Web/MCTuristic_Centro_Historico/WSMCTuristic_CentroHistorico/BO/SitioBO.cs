using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WSMCTuristic_CentroHistorico.BO
{
    public class SitioBO
    {
        private int _idSitio;
        private string _nombreSitio;
        private string _descripcionSitio;
        private string _historia;
        private string _direccion;
        private decimal _longitudSitio;
        private decimal _latitudSitio;
        private byte[] _fotoSitio;
        private string _sucesoImportante;
        private int _idTipoSitio;

        public int IdTipoSitio
        {
            get { return _idTipoSitio; }
            set { _idTipoSitio = value; }
        }

        public string SucesoImportante
        {
            get { return _sucesoImportante; }
            set { _sucesoImportante = value; }
        }

        public byte[] FotoSitio
        {
            get { return _fotoSitio; }
            set { _fotoSitio = value; }
        }

        public decimal LatitudSitio
        {
            get { return _latitudSitio; }
            set { _latitudSitio = value; }
        }

        public decimal LongitudSitio
        {
            get { return _longitudSitio; }
            set { _longitudSitio = value; }
        }

        public string Direccion
        {
            get { return _direccion; }
            set { _direccion = value; }
        }

        public string Historia
        {
            get { return _historia; }
            set { _historia = value; }
        }

        public string DescripcionSitio
        {
            get { return _descripcionSitio; }
            set { _descripcionSitio = value; }
        }

        public string NombreSitio
        {
            get { return _nombreSitio; }
            set { _nombreSitio = value; }
        }

        public int IdSitio
        {
            get { return _idSitio; }
            set { _idSitio = value; }
        }
    }
}