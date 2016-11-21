using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MCTuristic_Centro_Historico.localhost;
using System.Web.Services;

namespace MCTuristic_Centro_Historico.GUI
{
    public partial class GestionUsuarios : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        [WebMethod]
        public static string GuardarDireccion(string calle, string numero, string estado, string cruz, string cp, string col, string descripcion)
        {
            localhost.WsMCTuristic owebService = new WsMCTuristic();
            localhost.DireccionBO oDireccionBO = new DireccionBO();
            oDireccionBO.Calle = calle;
            oDireccionBO.Numero = numero;
            oDireccionBO.Estado = estado;
            oDireccionBO.Cruzamiento = cruz;
            oDireccionBO.CodPostal = cp;
            oDireccionBO.Colonia = col;
            oDireccionBO.DescripcionDireccion = descripcion;
            int i = owebService.InsertarDireccion(oDireccionBO);
            if (i > 0)
            {
                return "Operación exitosa";
            }
            return "Fallo la operación";

        }

        [WebMethod]
        public static string GuardarUsuario(string nombre, string apellido, string correo, string direccion, string contra, string telefono, string fecha, FileUpload fu)
        {
            localhost.WsMCTuristic owebService = new WsMCTuristic();
            localhost.UsuarioBO oUsuarioBO = new UsuarioBO();
            oUsuarioBO.NombreUsuario = nombre;
            oUsuarioBO.ApellidosUsuario = apellido;
            oUsuarioBO.EmailUsuario = correo;
            oUsuarioBO.ContraseñaUsuario = contra;
            oUsuarioBO.TelefonoUsuario = telefono;
            oUsuarioBO.FecharNacUsuario = fecha;
            if (fu.HasFile)
            {
                oUsuarioBO.Foto = new Byte[fu.PostedFile.ContentLength];
            }
            int i = owebService.InsertarUsuario(oUsuarioBO);
            
            if (i > 0)
            {
                return "Operación exitosa";
            }
            return "Fallo la operación";

        }

        protected void lbtnModificar_Click(object sender, EventArgs e)
        {
            
        }
    }
}