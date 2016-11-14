using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WSMCTuristic_CentroHistorico.BO
{
    public class NotificacionesBO
    {
        private int _idNotificacion;
        private int _idEvento;

        public int IdEvento
        {
            get { return _idEvento; }
            set { _idEvento = value; }
        }

        public int IdNotificacion
        {
            get { return _idNotificacion; }
            set { _idNotificacion = value; }
        }
    }
}