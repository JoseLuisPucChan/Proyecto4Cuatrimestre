using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MCTuristic_Centro_Historico.GUI
{
    public partial class VistaProducto : System.Web.UI.Page
    {
        localhost.WsMCTuristic oServicios = new localhost.WsMCTuristic();
        protected void Page_Load(object sender, EventArgs e)
        {
            BuscarServicios();
        }
        public void BuscarServicios()
        {
            DataSet DtServicios = oServicios.top12Servicios();
            DtlProductos.DataSource = DtServicios;
            DtlProductos.DataBind();
        }
    }
}