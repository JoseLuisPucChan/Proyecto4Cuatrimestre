using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WSMCTuristic_CentroHistorico.BO
{
    public class DireccionBO
    {
        private int _idDireccion;
        private string _calle;
        private string _cruzamiento;
        private string _numero;
        private string _descripcionDireccion;
        private string _colonia;
        private string _estado;
        private string _codPostal;
        private int _idUsuario;
        private int _idAdministrador;

        public int IdDireccion
        {
            get { return _idDireccion; }
            set { _idDireccion = value; }
        }
        public int IdAdministrador
        {
            get { return _idAdministrador; }
            set { _idAdministrador = value; }
        }

        public int IdUsuario
        {
            get { return _idUsuario; }
            set { _idUsuario = value; }
        }

        public string CodPostal
        {
            get { return _codPostal; }
            set { _codPostal = value; }
        }

        public string Estado
        {
            get { return _estado; }
            set { _estado = value; }
        }

        public string Colonia
        {
            get { return _colonia; }
            set { _colonia = value; }
        }

        public string DescripcionDireccion
        {
            get { return _descripcionDireccion; }
            set { _descripcionDireccion = value; }
        }

        public string Numero
        {
            get { return _numero; }
            set { _numero = value; }
        }

        public string Cruzamiento
        {
            get { return _cruzamiento; }
            set { _cruzamiento = value; }
        }

        public string Calle
        {
            get { return _calle; }
            set { _calle = value; }
        }
    }
}