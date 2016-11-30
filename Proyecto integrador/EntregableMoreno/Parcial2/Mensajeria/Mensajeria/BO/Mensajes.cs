
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mensajeria.BO
{
    class Mensajes
    {
        int mensajeID;
        string mensaje;
       string destinatario;
        string asunto;
        public int MensajeID
        {
            get
            {
                return mensajeID;
            }

            set
            {
                mensajeID = value;
            }
        }

        public string Mensaje
        {
            get
            {
                return mensaje;
            }

            set
            {
                mensaje = value;
            }
        }

        public string Destinatario
        {
            get
            {
                return destinatario;
            }

            set
            {
                destinatario = value;
            }
        }

        public string Asunto
        {
            get
            {
                return asunto;
            }

            set
            {
                asunto = value;
            }
        }
    }
}
