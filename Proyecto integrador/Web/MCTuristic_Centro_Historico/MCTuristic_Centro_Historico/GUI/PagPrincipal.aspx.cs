using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MCTuristic_Centro_Historico.GUI
{
    public partial class PagPrincipal : System.Web.UI.Page
    {
        int id;
        int idUser;
        protected void Page_Load(object sender, EventArgs e)
        {
           
                id = Convert.ToInt32(Session["idDueño"]);
                idUser = Convert.ToInt32(Session["idUser"]);
                if(id>0 || idUser>0)
                {
                    HyperLink1.Visible = true;
                }
                else
                {
                    HyperLink1.Visible = false;
                }
        }
        protected void btnCerrarSecion_Click1(object sender, EventArgs e)
        {
            Session["idDueño"] = 0;
            Session["idUser"] = 0;
            Server.Transfer("PagPrincipal.aspx");
        }








    }
}