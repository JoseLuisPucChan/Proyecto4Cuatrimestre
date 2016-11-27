﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WSMCTuristic_CentroHistorico.BO
{
    public class EventoBO
    {

        private int _idEvento;
        private string _nombreEvento;
        private string _horaInicioEvento;
        private string _horaFinalizacion;
        private string _fechaInicio;
        private string _fechaFinalizacion;
        private byte[] _foto;
        private int _idUsuario;
        private int _idSitio;

        public int IdSitio
        {
            get { return _idSitio; }
            set { _idSitio = value; }
        }

        public int IdUsuario
        {
            get { return _idUsuario; }
            set { _idUsuario = value; }
        }

        public string FechaFinalizacion
        {
            get { return _fechaFinalizacion; }
            set { _fechaFinalizacion = value; }
        }

        public string FechaInicio
        {
            get { return _fechaInicio; }
            set { _fechaInicio = value; }
        }

        public string HoraFinalizacion
        {
            get { return _horaFinalizacion; }
            set { _horaFinalizacion = value; }
        }

        public string HoraInicioEvento
        {
            get { return _horaInicioEvento; }
            set { _horaInicioEvento = value; }
        }

        public string NombreEvento
        {
            get { return _nombreEvento; }
            set { _nombreEvento = value; }
        }

        public int IdEvento
        {
            get { return _idEvento; }
            set { _idEvento = value; }
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