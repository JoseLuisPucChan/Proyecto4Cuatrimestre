using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WSMCTuristic_CentroHistorico.BO
{
    public class SoporteBO
    {
        private int _idSoporte;
        private string _comentarioSoporte;
        private string _asunto;
        private int _idUsuario;

        public int IdUsuario
        {
            get { return _idUsuario; }
            set { _idUsuario = value; }
        }


        public string Asunto
        {
            get { return _asunto; }
            set { _asunto = value; }
        }

        public string ComentarioSoporte
        {
            get { return _comentarioSoporte; }
            set { _comentarioSoporte = value; }
        }

        public int IdSoporte
        {
            get { return _idSoporte; }
            set { _idSoporte = value; }
        }
    }
}