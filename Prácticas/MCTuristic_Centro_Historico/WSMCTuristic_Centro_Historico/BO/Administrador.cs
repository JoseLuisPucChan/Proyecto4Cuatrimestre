using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WSMCTuristic_Centro_Historico.BO
{
    public class Administrador
    {
        private int _idAdministrador;
        private string _nombreadmin;
        private string _apellidosadmin;
        private string _email;
        private string _contraseñaadmin;
        private string _telefonoadmin;
        private DateTime _fechanacimiento;

        public int IdAdministrador
        {
            get { return _idAdministrador; }
            set { _idAdministrador = value; }
        }
        public DateTime Fechanacimiento
        {
            get { return _fechanacimiento; }
            set { _fechanacimiento = value; }
        }

        public string Telefonoadmin
        {
            get { return _telefonoadmin; }
            set { _telefonoadmin = value; }
        }

        public string Contraseñaadmin
        {
            get { return _contraseñaadmin; }
            set { _contraseñaadmin = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public string Apellidosadmin
        {
            get { return _apellidosadmin; }
            set { _apellidosadmin = value; }
        }

        public string Nombreadmin
        {
            get { return _nombreadmin; }
            set { _nombreadmin = value; }
        }

    }
}