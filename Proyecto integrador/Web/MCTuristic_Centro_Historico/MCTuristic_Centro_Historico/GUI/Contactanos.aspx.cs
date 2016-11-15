using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MCTuristic_Centro_Historico.GUI
{
    public partial class Contactanos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        [System.Web.Services.WebMethod]
        public static string GuardarContactanos(string nombre, string apellido, string email, string asunto, string contenido)
        {
            localhost.WsMCTuristic owebService = new localhost.WsMCTuristic();
            localhost.ContactanosBO oContactanos = new localhost.ContactanosBO();
            oContactanos.NombreContacto = nombre;
            oContactanos.ApellidoContacto = apellido;
            oContactanos.EmailContacto = email;
            oContactanos.Asunto = asunto;
            oContactanos.Contenido = contenido;

            int i = owebService.InsertarContactanos(oContactanos);
            if (i > 0)
            {
                return "Operación exitosa";
            }
            return "Fallo la operación";

        }
        

    }
}