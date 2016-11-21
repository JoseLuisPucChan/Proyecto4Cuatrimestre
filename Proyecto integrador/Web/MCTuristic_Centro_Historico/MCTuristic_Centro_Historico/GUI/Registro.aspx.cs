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
            if(FileUpload1.HasFile)
            {
                HttpPostedFile ImgFile = FileUpload1.PostedFile;
                Byte[] byteImage = new Byte[FileUpload1.PostedFile.ContentLength];
                ImgFile.InputStream.Read(byteImage, 0, FileUpload1.PostedFile.ContentLength);
                oUsuariosBO.Foto = byteImage;
            }
            
            if (txtContraseña.Text == txtConfirmarContraseña.Text)
            {
                oUsuariosBO.ContraseñaUsuario = txtConfirmarContraseña.Text.Trim();
            }
            oUsuariosBO.TelefonoUsuario = txtNumero.Text.Trim();
            oUsuariosBO.FecharNacUsuario = Calender.Text;
            return oUsuariosBO;

        }

        //-----------------Botones-----------
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
            oUsuariosBO.FecharNacUsuario = DateTime.Now;
            int i = owebService.InsertarUsuario(oUsuariosBO);
            if (i > 0)
            {
               return "Operación exitosa";   
            }
            return "Fallo la operación";

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            localhost.WsMCTuristic owebService = new WsMCTuristic();
            int i = owebService.InsertarUsuario(RecuperarInformacion());
            if (i > 0)
            {
                Response.Redirect("Suscripciones.aspx");
            }

           
        }

      


      
  
    }
}