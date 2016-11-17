using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WSMCTuristic_CentroHistorico.BO
{
    public class ComentariosBO
    {
        private int _idComentario;
        private string _nombre;
        private string _contenido;
        private int _status;
        private int _idUsuario;

        public int IdUsuario
        {
            get { return _idUsuario; }
            set { _idUsuario = value; }
        }

        public int Status
        {
            get { return _status; }
            set { _status = value; }
        }

        public string Contenido
        {
            get { return _contenido; }
            set { _contenido = value; }
        }

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public int IdComentario
        {
            get { return _idComentario; }
            set { _idComentario = value; }
        }
    }
}