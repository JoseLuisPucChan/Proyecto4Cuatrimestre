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
        int idUser;
       
        localhost.WsMCTuristic owebService = new WsMCTuristic();
        protected void Page_Load(object sender, EventArgs e)
        {
            idUser = Convert.ToInt32(Session["idUsuario"]);
        }
        protected void btnGratis_Click(object sender, EventArgs e)
        {
            if(idUser==0)
            {
                Response.Redirect("Registro.aspx");
            }
            else
            {
                int idGratis = 1;
                GenerarNuevaSuscripcion(idGratis);
            }
         
        }
        public void GenerarNuevaSuscripcion(int idSus)
        {
            try
            {
                localhost.SuscripcionBO oSuscripcion = new SuscripcionBO();
                //Obtener id Usuario Recien registrado
                oSuscripcion.FechaPago = DateTime.Now.Date;
                oSuscripcion.IdSuscripcion = idSus;
                oSuscripcion.IdUsuario = Convert.ToString(idUser);
                int i = owebService.InsertarSuscripcion(oSuscripcion);
                if (i > 0)
                {
                    Response.Redirect("PagPrincipal.aspx");
                }

            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (idUser == 0)
            {
                Response.Redirect("Registro.aspx");
            }
            else
            {
                int mes = 2;
                GenerarNuevaSuscripcion(mes);
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            if (idUser == 0)
            {
                Response.Redirect("Registro.aspx");
            }
            else
            {
                int seism = 3;
                GenerarNuevaSuscripcion(seism);
            }   
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            if (idUser == 0)
            {
                Response.Redirect("Registro.aspx");
            }
            else
            {
                int Año = 4;
                GenerarNuevaSuscripcion(Año);
            }
        }

    }
}