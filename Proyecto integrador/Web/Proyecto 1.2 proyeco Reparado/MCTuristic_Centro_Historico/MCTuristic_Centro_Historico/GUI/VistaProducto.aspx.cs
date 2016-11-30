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
            DataSet DtServicios = oServicios.topServicios();
            DtlProductos.DataSource = DtServicios;
            DtlProductos.DataBind();
            GridView1.DataSource = DtServicios;
            GridView1.DataBind();
        }
        public string RecuperarImagenWebUrl(string Imagen)
        {
            // Convert Base64 String to byte[]
            byte[] imageBytes = Convert.FromBase64String(Imagen);
            string image = Convert.ToBase64String(imageBytes, 0, imageBytes.Length);
            image = "data:image/.jpeg" + "jpeg;base64," + image;
            return image;
        }
        public string RecuperarImagen(object img)
        {
            return RecuperarImagenWebUrl(img.ToString());
        }
    }
}