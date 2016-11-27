using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WSMCTuristic_CentroHistorico.BO
{
    public class ServicioBO
    {
        private int _idServicio;
        private string _ofertaServicio;
        private decimal _precioServicio;
        private string _descripcionServicio;
        private int _idEstablecimiento;
        private int _idTipoServicio;
        private string _nombreServicio;
        private byte[] _foto;
        private int _popularidad;

        public int IdTipoServicio
        {
            get { return _idTipoServicio; }
            set { _idTipoServicio = value; }
        }

        public string DescripcionServicio
        {
            get { return _descripcionServicio; }
            set { _descripcionServicio = value; }
        }

        public decimal PrecioServicio
        {
            get { return _precioServicio; }
            set { _precioServicio = value; }
        }

        public string OfertaServicio
        {
            get { return _ofertaServicio; }
            set { _ofertaServicio = value; }
        }

        public int IdServicio
        {
            get { return _idServicio; }
            set { _idServicio = value; }
        }

        public int IdEstablecimiento
        {
            get
            {
                return _idEstablecimiento;
            }

            set
            {
                _idEstablecimiento = value;
            }
        }

        public string NombreServicio
        {
            get
            {
                return _nombreServicio;
            }

            set
            {
                _nombreServicio = value;
            }
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

        public int Popularidad
        {
            get
            {
                return _popularidad;
            }

            set
            {
                _popularidad = value;
            }
        }
    }
}