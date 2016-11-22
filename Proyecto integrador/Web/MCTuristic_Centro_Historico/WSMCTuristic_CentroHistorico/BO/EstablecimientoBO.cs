using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WSMCTuristic_CentroHistorico.BO
{
    public class EstablecimientoBO
    {
        private int _idEstablecimiento;
        private string _nombreEstable;
        private string _telefonoEstable;
        private string _horaInicioEstable;
        private string _horaCierreEstable;
        private string _pagFacebook;
        private decimal _longitud;
        private decimal _latitud;
        private byte[] _foto;
        private int _idUsuario;
        


        public int IdEstablecimiento
        {
            get { return _idEstablecimiento; }
            set { _idEstablecimiento = value; }
        }

        public int IdUsuario
        {
            get { return _idUsuario; }
            set { _idUsuario = value; }
        }

        public decimal Latitud
        {
            get { return _latitud; }
            set { _latitud = value; }
        }

        public decimal Longitud
        {
            get { return _longitud; }
            set { _longitud = value; }
        }

        public string PagFacebook
        {
            get { return _pagFacebook; }
            set { _pagFacebook = value; }
        }

        public string HoraCierreEstable
        {
            get { return _horaCierreEstable; }
            set { _horaCierreEstable = value; }
        }

        public string HoraInicioEstable
        {
            get { return _horaInicioEstable; }
            set { _horaInicioEstable = value; }
        }

        public string TelefonoEstable
        {
            get { return _telefonoEstable; }
            set { _telefonoEstable = value; }
        }

        public string NombreEstable
        {
            get { return _nombreEstable; }
            set { _nombreEstable = value; }
        }

        public byte[] Foto
        {
            get
            {
                return _foto;
            }

            set
            {
                _foto = value;
            }
        }
    }
}