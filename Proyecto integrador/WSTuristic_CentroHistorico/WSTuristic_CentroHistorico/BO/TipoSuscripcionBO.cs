using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WSTuristic_CentroHistorico.BO
{
    public class TipoSuscripcionBO
    {
        private int _idTipoSuscripcion;
        private string _nombreTipoSuscri;
        private decimal _montoSuscripcion;
        private int _tiempoSuscripcion;

        public int TiempoSuscripcion
        {
            get { return _tiempoSuscripcion; }
            set { _tiempoSuscripcion = value; }
        }

        public decimal MontoSuscripcion
        {
            get { return _montoSuscripcion; }
            set { _montoSuscripcion = value; }
        }

        public string NombreTipoSuscri
        {
            get { return _nombreTipoSuscri; }
            set { _nombreTipoSuscri = value; }
        }

        public int IdTipoSuscripcion
        {
            get { return _idTipoSuscripcion; }
            set { _idTipoSuscripcion = value; }
        }
    }
}