using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using WebCentroTuristico.BO;
namespace WebCentroTuristico
{
    /// <summary>
    /// Descripción breve de WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
   
        Services.CtrlUsuarios oUsuarioCTRL;

        [WebMethod]
        public string HelloWorld()
        {
            return "Hola a todos";
        }
         [WebMethod]
        public int InsertarUsuario(UsuarioBO obj)
        {
            UsuarioBO oUsuario = new UsuarioBO();
            oUsuarioCTRL = new Services.CtrlUsuarios();
            return oUsuarioCTRL.InsertarUsuario(oUsuario);
        }

        [WebMethod]
        public int ModificarUsuario(object obj)
        {
            oUsuarioCTRL = new Services.CtrlUsuarios();
            return oUsuarioCTRL.ModificarUsuario(obj);
        }
        [WebMethod]
        public int EliminarUsuario(object obj)
        {
            oUsuarioCTRL = new Services.CtrlUsuarios();
            return oUsuarioCTRL.EliminarUsuario(obj);
        }
    }
}
