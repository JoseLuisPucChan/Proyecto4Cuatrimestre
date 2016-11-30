using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Services;

namespace MCTuristic_Centro_Historico.GUI
{
    public partial class GestionEstablecimientos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
        }
        protected void btnServicios_Click(object sender, EventArgs e)
        {
            Session["IdEstablecimiento"] = txtIdEstablecimiento.Text;
            Response.Redirect("GestionServicios.aspx");
        }

        [WebMethod]
        public static string GuardarEstablecimiento(string nombre, string telefono, string facebook, string abrir, string cerrar, decimal latitud, decimal longitud, Image foto)
        {
            localhost.WsMCTuristic owebService = new localhost.WsMCTuristic();
            localhost.EstablecimientoBO oEstablecimientoBO = new localhost.EstablecimientoBO();
            oEstablecimientoBO.NombreEstable = nombre;
            oEstablecimientoBO.TelefonoEstable = telefono;
            oEstablecimientoBO.PagFacebook = facebook;
            oEstablecimientoBO.HoraInicioEstable = abrir;
            oEstablecimientoBO.HoraCierreEstable = cerrar;
            oEstablecimientoBO.Latitud = latitud;
            oEstablecimientoBO.Longitud = longitud;
            int i = owebService.InsertarEstablecimiento(oEstablecimientoBO);
            if (i > 0)
            {
                return "Operación exitosa";
            }
            return "Fallo la operación";

        }

        private bool VerificarArchivoImg()
        {
            if (fuFoto.HasFile)
            {
                string ext = System.IO.Path.GetExtension(fuFoto.FileName);
                if (ext == ".jpeg" || ext == ".jpg" || ext == ".png")
                {
                    //string path = Server.MapPath(@"\Recursos\");
                    //fu.SaveAs(path + fu.FileName);
                    HttpPostedFile imagen = fuFoto.PostedFile;
                    int tamaño = imagen.ContentLength;
                    Byte[] arreglo = new Byte[tamaño];
                    imagen.InputStream.Read(arreglo, 0, tamaño);
                    Session["arreglo"] = arreglo;
                    Session["Url"] = ConvertirImagenStringWebUrl(arreglo, ext);
                }
                return true;
            }
            else
            {
                Response.Write("<h3>Solo puedes seleccionar archivos tipo .jpeg , .jpg o .png</h3>");
            }
            return false;
        }
        public string ConvertirImagenStringWeb(Byte[] arreglo)
        {
            string imagen = Convert.ToBase64String(arreglo, 0, arreglo.Length);
            return imagen;
        }
        public string ConvertirImagenStringWebUrl(Byte[] arreglo,
 string extension)
        {
            string url = Convert.ToBase64String(arreglo, 0, arreglo.Length);
            url = "data:image/" + ".jpeg" + "jpeg;base64," + url;
            return url;
        }
        

        protected void btnSubir_Click(object sender, EventArgs e)
        {
            if (VerificarArchivoImg() == true)
            {
                imgEstablecimiento.ImageUrl = (string)Session["Url"];
            }
        }

        private void Subir_Click(object sender, EventArgs e)
        {
            
        }

        protected void lbtnGuardar_Click(object sender, EventArgs e)
        {
            localhost.WsMCTuristic owebService = new localhost.WsMCTuristic();
            localhost.EstablecimientoBO oEstablecimientoBO = new localhost.EstablecimientoBO();
            oEstablecimientoBO.NombreEstable = txtNombre.Text.Trim();
            oEstablecimientoBO.TelefonoEstable = txtTelefono.Text.Trim();
            oEstablecimientoBO.PagFacebook = txtFacebook.Text.Trim();
            oEstablecimientoBO.HoraInicioEstable = txtAbrir.Text.Trim();
            oEstablecimientoBO.HoraCierreEstable = txtCerrar.Text.Trim();
            oEstablecimientoBO.Latitud = Convert.ToDecimal(27.000);
            oEstablecimientoBO.Longitud = Convert.ToDecimal(68.000);
            oEstablecimientoBO.Foto = (byte[])Session["arreglo"];
            int i = owebService.InsertarEstablecimiento(oEstablecimientoBO);
            if (i > 0)
            {
                
            }
            
        }
    }
}