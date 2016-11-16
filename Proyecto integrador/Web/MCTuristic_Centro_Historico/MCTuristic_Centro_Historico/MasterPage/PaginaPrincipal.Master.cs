using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MCTuristic_Centro_Historico.MasterPage
{
    public partial class PaginaPrincipal : System.Web.UI.MasterPage
    {
        int id;
        int idUser;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                id = Convert.ToInt32(Session["idDueño"]);
                idUser = Convert.ToInt32(Session["idUser"]);
                if (id > 0 || idUser>0)
                {
                    hyInicioSeción.Visible = false;
                   
                }
                else
                {
                    
                    hyInicioSeción.Visible = true;
                }


            }
        }

      
    }
}