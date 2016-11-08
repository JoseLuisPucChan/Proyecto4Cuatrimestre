using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using WSMCTuristic_Centro_Historico.BO;
namespace WSMCTuristic_Centro_Historico.UI
{
    /// <summary>
    /// Descripción breve de WebServiceMCTuristic
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServiceMCTuristic : System.Web.Services.WebService
    {
        Services.Usuario oUsuarioCTRL;
        Services.Direccion oDireccionCTRL;
       

        [WebMethod]
        public string HelloWorld()
        {
            return "Hola a todos";
        }
        //--------------------------ABC Usuarios-----------------------------
        [WebMethod]
        public int InsertarUsuario(object obj)
        {
            oUsuarioCTRL = new Services.Usuario();
            return oUsuarioCTRL.InsertarUsuario(obj);
        }
        [WebMethod]
        public int ModificarUsuario(object obj)
        {
            oUsuarioCTRL = new Services.Usuario();
            return oUsuarioCTRL.ModificarUsuario(obj);
        }
        [WebMethod]
        public int EliminarUsuario(object obj)
        {
            oUsuarioCTRL = new Services.Usuario();
            return oUsuarioCTRL.EliminarUsuario(obj);
        }

        //--------------------------ABC Direcciones-----------------------------
        [WebMethod]
        public int EliminarDireccion(object obj)
        {
            oDireccionCTRL = new Services.Direccion();
            return oDireccionCTRL.EliminarDireccion(obj);
        }

        [WebMethod]
        public int InsertarDireccion(object obj)
        {
            oDireccionCTRL = new Services.Direccion();
            return oDireccionCTRL.InsertarDireccion(obj);
        }
        [WebMethod]
        public int ModificarDireccion(object obj)
        {
            oDireccionCTRL = new Services.Direccion();
            return oDireccionCTRL.ModificarDireccion(obj);
        }

    }
}
