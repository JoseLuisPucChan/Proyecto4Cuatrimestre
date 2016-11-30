using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MCTuristic_Centro_Historico.GUI
{
    public partial class GetImagen : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            localhost.WsMCTuristic oservicios = new localhost.WsMCTuristic();
            string id = Request.QueryString["id"];
            byte[] imgData = oservicios.verFotoSer(Convert.ToInt32(id));
            Response.BinaryWrite(imgData);
        }
    }
}