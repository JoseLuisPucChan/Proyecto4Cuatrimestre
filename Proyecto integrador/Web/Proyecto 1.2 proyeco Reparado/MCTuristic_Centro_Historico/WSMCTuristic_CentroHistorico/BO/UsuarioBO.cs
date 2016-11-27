using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WSMCTuristic_CentroHistorico.BO
{
    public class UsuarioBO
    {
        private int _idUsuario;
        private string _nombreUsuario;
        private string _apellidosUsuario;
        private string _emailUsuario;
        private string _contraseñaUsuario;
        private string _telefonoUsuario;
        private string _fecharNacUsuario;
        private byte[] _foto;

        public int IdUsuario
        {
            get { return _idUsuario; }
            set { _idUsuario = value; }
        }
        public string FecharNacUsuario
        {
            get { return _fecharNacUsuario; }
            set { _fecharNacUsuario = value; }
        }

        public string TelefonoUsuario
        {
            get { return _telefonoUsuario; }
            set { _telefonoUsuario = value; }
        }

        public string ContraseñaUsuario
        {
            get { return _contraseñaUsuario; }
            set { _contraseñaUsuario = value; }
        }

        public string EmailUsuario
        {
            get { return _emailUsuario; }
            set { _emailUsuario = value; }
        }

        public string ApellidosUsuario
        {
            get { return _apellidosUsuario; }
            set { _apellidosUsuario = value; }
        }

        public string NombreUsuario
        {
            get { return _nombreUsuario; }
            set { _nombreUsuario = value; }
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