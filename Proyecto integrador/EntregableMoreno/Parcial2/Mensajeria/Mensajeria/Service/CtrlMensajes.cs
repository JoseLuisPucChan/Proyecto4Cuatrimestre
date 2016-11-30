using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Mensajeria.DAO;
namespace Mensajeria.Service
{
    class CtrlMensajes
    {
        MensajesDAO Mensajes = new MensajesDAO();
        public int EnviarMensaje (object mensaje, object alumno)
        {
            return Mensajes.Eviarmensaje(mensaje , alumno);
        }

        public DataTable RegresarMensajes( object alumno)
        {
            return Mensajes.RegresarMensajes(alumno);
        }

    }
}
