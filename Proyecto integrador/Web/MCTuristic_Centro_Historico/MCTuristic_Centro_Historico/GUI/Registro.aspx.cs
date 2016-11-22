﻿using MCTuristic_Centro_Historico.localhost;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;
using System.Drawing.Imaging;

namespace MCTuristic_Centro_Historico.GUI
{
    public partial class Registro : System.Web.UI.Page
    {
        localhost.WsMCTuristic owebService = new WsMCTuristic();
        protected void Page_Load(object sender, EventArgs e)
        {
            localhost.DireccionBO odireccio = new DireccionBO();
            localhost.UsuarioBO oUsuario = new UsuarioBO();
        }
        [WebMethod]
        public static int Sumar(int n1, int n2)
        {
            return n1 + n2;
        }
       
        //--------------------Recolección de Información-----------------------------------
        private localhost.UsuarioBO RecuperarInformacion()
        {
            localhost.UsuarioBO oUsuariosBO = new UsuarioBO();
            oUsuariosBO.NombreUsuario = txtNombre.Text.Trim();
            oUsuariosBO.ApellidosUsuario = txtApellidos.Text.Trim();
            oUsuariosBO.EmailUsuario = txtDireccionCorreo.Text.Trim();
            //HttpPostedFile ImgFile = FileUpload1.PostedFile;
            //Byte[] byteImage = new Byte[FileUpload1.PostedFile.ContentLength];
            //ImgFile.InputStream.Read(byteImage, 0, FileUpload1.PostedFile.ContentLength);
            if (txtContraseña.Text == txtConfirmarContraseña.Text)
            {
                oUsuariosBO.ContraseñaUsuario = txtConfirmarContraseña.Text.Trim();
            }
            oUsuariosBO.TelefonoUsuario = txtNumero.Text.Trim();

            //Fecha Nacimiento es un string se cambio en las clases 
            oUsuariosBO.FecharNacUsuario = Calender.Text;
            return oUsuariosBO;
        }

        //-----------------Botones-----------Con javaScrip

        [System.Web.Services.WebMethod]
        public static string Guardar(string nombre, string apellido, string email, string contraseña, string numero)
        {
            localhost.WsMCTuristic owebService = new WsMCTuristic();
            localhost.UsuarioBO oUsuariosBO = new UsuarioBO();
            oUsuariosBO.NombreUsuario = nombre;
            oUsuariosBO.ApellidosUsuario = apellido;
            oUsuariosBO.EmailUsuario = email;
            oUsuariosBO.ContraseñaUsuario = contraseña;
            oUsuariosBO.TelefonoUsuario = numero;
          
           
            int i = owebService.InsertarUsuario(oUsuariosBO);
            if (i > 0)
            {
               return "Operación exitosa";   
            }
            return "Fallo la operación";

        }


        //Agregar Usuario *
        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                int i = owebService.InsertarUsuario(RecuperarInformacion());
                if (i > 0)
                {
                    Response.Redirect("Suscripciones.aspx");
                }

            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }

    

        
    //    //public Image RecuperarImagen(string Imagen)
    //    //{
    //    //    // Convert Base64 String to byte[]
    //    //    byte[] imageBytes = Convert.FromBase64String(Imagen);
    //    //    MemoryStream ms = new MemoryStream(imageBytes, 0,
    //    //      imageBytes.Length);
    //    //    // Convert byte[] to Image
    //    //    ms.Write(imageBytes, 0, imageBytes.Length);
    //    //    Image image = Image.FromStream(ms, true);
    //    //    return image;
    //    //}

    //    public string ConvertirImagenStringWeb(Byte[] arreglo)
    //    {
    //        string imagen = Convert.ToBase64String(arreglo, 0, arreglo.Length);
    //        return imagen;
    //    }
    //    public string RecuperarImagenWebUrl(string Imagen)
    //    {
    //        // Convert Base64 String to byte[]
    //        byte[] imageBytes = Convert.FromBase64String(Imagen);
    //        string image = Convert.ToBase64String(imageBytes, 0, imageBytes.Length);
    //        image = "data:image/.jpeg" + "jpeg;base64," + image;
    //        return image;
    //    }
    //    public string ConvertirImagenStringWebUrl(Byte[] arreglo,
    //string extension)
    //    {
    //        string url = Convert.ToBase64String(arreglo, 0, arreglo.Length);
    //        url = "data:image/" + extension + "jpeg;base64," + url;
    //        return url;
    //    }
    //    private bool VerificarArchivoImg()
    //    {
    //        if (fuFoto.HasFile)
    //        {
    //            string ext = System.IO.Path.GetExtension(fuFoto.FileName);
    //            if (ext == ".jpeg" || ext == ".jpg" || ext == ".png")
    //            {
    //                //string path = Server.MapPath(@"\Recursos\");
    //                //fu.SaveAs(path + fu.FileName);
    //                HttpPostedFile imagen = fuFoto.PostedFile;
    //                int tamaño = imagen.ContentLength;
    //                Byte[] arreglo = new Byte[tamaño];
    //                imagen.InputStream.Read(arreglo, 0, tamaño);
    //                Session["NombreImg"] = fuFoto.FileName;
    //                Session["Arreglo"] = arreglo;
    //                //Session["Imagen"] = datosV.ConvertirImagenStringWeb(arreglo).ToString();
    //                Session["Url"] = ConvertirImagenStringWebUrl(arreglo, ext);
    //            }
    //            return true;
    //        }
    //        else
    //        {
    //            Response.Write("<h3>Solo puedes seleccionar archivos tipo .jpeg , .jpg o .png</h3>");
    //        }
    //        return false;
    //    }

      
  
    }
}