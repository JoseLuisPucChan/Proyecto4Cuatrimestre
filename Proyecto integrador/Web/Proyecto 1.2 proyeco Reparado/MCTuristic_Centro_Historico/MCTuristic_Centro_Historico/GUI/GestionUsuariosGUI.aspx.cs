using MCTuristic_Centro_Historico.localhost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MCTuristic_Centro_Historico.GUI
{
    public partial class GestionUsuariosGUI : System.Web.UI.Page
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
        public static string GuardarUsuario(string nombre, string apellido, string correo, string direccion, string contra, string telefono, string fecha, Byte[] fu)
        {
            localhost.WsMCTuristic owebService = new WsMCTuristic();
            localhost.UsuarioBO oUsuarioBO = new UsuarioBO();
            oUsuarioBO.NombreUsuario = nombre;
            oUsuarioBO.ApellidosUsuario = apellido;
            oUsuarioBO.EmailUsuario = correo;
            oUsuarioBO.ContraseñaUsuario = contra;
            oUsuarioBO.TelefonoUsuario = telefono;
            oUsuarioBO.FecharNacUsuario = fecha;
            oUsuarioBO.Foto = fu;
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

        protected void lbtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                GuardarUsuario(txtNombre.Text.Trim(), txtApellidos.Text.Trim(), txtCorreo.Text.Trim(), txtDireccion.Text.Trim(), txtContrasena.Text.Trim(), txtTelefono.Text.Trim(), txtFecha.Text.Trim(), (Byte[])Session["arreglo"]);
            }
            catch { }
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

        protected void btnVer_Click(object sender, EventArgs e)
        {
            if (VerificarArchivoImg() == true)
            {
                imgFoto.ImageUrl = (string)Session["Url"];
            }
        }

        //public Image RecuperarImagen(string Imagen)
        //{
        //    // Convert Base64 String to byte[]
        //    byte[] imageBytes = Convert.FromBase64String(Imagen);
        //    MemoryStream ms = new MemoryStream(imageBytes, 0,
        //      imageBytes.Length);

        //    // Convert byte[] to Image
        //    ms.Write(imageBytes, 0, imageBytes.Length);
        //    Image image = Image.FromStream(ms, true);
        //    return image;
        //}

        public string ConvertirImagenStringWeb(Byte[] arreglo)
        {
            string imagen = Convert.ToBase64String(arreglo, 0, arreglo.Length);
            return imagen;
        }

        public string RecuperarImagenWebUrl(string Imagen)
        {
            // Convert Base64 String to byte[]
            byte[] imageBytes = Convert.FromBase64String(Imagen);
            string image = Convert.ToBase64String(imageBytes, 0, imageBytes.Length);
            image = "data:image/.jpeg" + "jpeg;base64," + image;
            return image;
        }

        public string ConvertirImagenStringWebUrl(Byte[] arreglo,
    string extension)
        {
            string url = Convert.ToBase64String(arreglo, 0, arreglo.Length);
            url = "data:image/" + extension + "jpeg;base64," + url;
            return url;
        }

    }
}