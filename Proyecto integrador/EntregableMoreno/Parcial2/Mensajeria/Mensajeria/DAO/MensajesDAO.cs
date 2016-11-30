using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Mensajeria.BO;
namespace Mensajeria.DAO
{
    public class MensajesDAO
    {
        ConexionDAO BD = new ConexionDAO();
        string sql;
        public int Eviarmensaje(object Mensaje, object Alum)
        {
            Alumnos Alumno = (Alumnos)Alum;
            Mensajes mensaje = (Mensajes)Mensaje;

            sql = "exec EnviarMensaje " + Alumno.Matricula  + ", '" +mensaje. Mensaje+ "','" + mensaje.Destinatario + "' , '" + mensaje.Asunto + "' ";
            return BD.Ejecutar(sql);   
        }
        public DataTable RegresarMensajes(object Alum)
        {
            Alumnos Alumno = (Alumnos)Alum;
            sql = "exec FiltrarMesaje " + Alumno.Matricula +" ";
            return BD.Tabla(sql);
        }

    }
}
