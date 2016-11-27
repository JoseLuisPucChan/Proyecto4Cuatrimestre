using MCTuristic_Centro_Historico.localhost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MCTuristic_Centro_Historico.GUI
{
    public partial class Suscripciones : System.Web.UI.Page
    {
        localhost.WsMCTuristic owebService = new WsMCTuristic();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnGratis_Click(object sender, EventArgs e)
        {
            try
            {
                localhost.SuscripcionBO oSuscripcion = new SuscripcionBO();
                int idGratis = 1;
                int idUser = Convert.ToInt32(Session["idUsuario"]);
                //Obtener id Usuario Recien registrado
                oSuscripcion.FechaPago = DateTime.Now.Date;
                oSuscripcion.IdSuscripcion = idGratis;
                oSuscripcion.IdUsuario = Convert.ToString(idUser);
                int i = owebService.InsertarSuscripcion(oSuscripcion);
                if (i > 0)
                {
                    Response.Write("Exito");
                }

            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }

        }

    }
}