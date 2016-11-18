using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WSMCTuristic_CentroHistorico.BO
{
    public class SuscripcionBO
    {
        private int _idSuscripcion;
        private DateTime _fechaPago;
        private string _idUsuario;

        public string IdUsuario
        {
            get { return _idUsuario; }
            set { _idUsuario = value; }
        }

        public DateTime FechaPago
        {
            get { return _fechaPago; }
            set { _fechaPago = value; }
        }

        public int IdSuscripcion
        {
            get { return _idSuscripcion; }
            set { _idSuscripcion = value; }
        }


    }
}