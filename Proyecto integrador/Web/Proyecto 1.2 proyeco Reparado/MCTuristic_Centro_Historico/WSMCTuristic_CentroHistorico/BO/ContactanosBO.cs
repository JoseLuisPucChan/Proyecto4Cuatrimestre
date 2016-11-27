using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WSMCTuristic_CentroHistorico.BO
{
    public class ContactanosBO
    {
        private string _nombreContacto;
        private string _apellidoContacto;
        private string _emailContacto;
        private string _asunto;
        private string _contenido;
        private int _idContactanos;

        public int IdContactanos
        {
            get { return _idContactanos; }
            set { _idContactanos = value; }
        }

        public string Contenido
        {
            get { return _contenido; }
            set { _contenido = value; }
        }

        public string Asunto
        {
            get { return _asunto; }
            set { _asunto = value; }
        }

        public string EmailContacto
        {
            get { return _emailContacto; }
            set { _emailContacto = value; }
        }

        public string ApellidoContacto
        {
            get { return _apellidoContacto; }
            set { _apellidoContacto = value; }
        }

        public string NombreContacto
        {
            get { return _nombreContacto; }
            set { _nombreContacto = value; }
        }

    }
}