using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Diagnostics;

using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reto1.GUI
{
    public partial class Principal : System.Web.UI.Page
    {
        //------Load----------
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                  RellenarDropDownList();
            }
             
        }
        private void RellenarDropDownList()
        {

            string fileJson = File.ReadAllText(Server.MapPath(@"~/Json/aspnetJSON"));
            DataTable dt = (DataTable)JsonConvert.DeserializeObject(fileJson, typeof(DataTable));
            //GridView1.DataSource = dt;
            //GridView1.DataBind();
            ddlEstados.DataSource = Buscar("1");
            ddlEstados.DataValueField = "c_estado";
            ddlEstados.DataTextField = "d_estado";
            DataBind();
        }

        //Recuperar el archivo Json
        private DataTable Listar()
        {
            string fileJson = File.ReadAllText(Server.MapPath(@"~/Json/aspnetJSON"));
            DataTable dsBibliografia = (DataTable)JsonConvert.DeserializeObject(fileJson, typeof(DataTable));
            return dsBibliografia;
        }
        private DataTable ListarEstados(string idEstado)
        {
            DataTable dsBibliografia = new DataTable();
            string fileJson = "";
            if (idEstado == "01") { fileJson = File.ReadAllText(Server.MapPath(@"~/Json/Aguascalientes-json.json")); }
            if (idEstado == "02") { fileJson = File.ReadAllText(Server.MapPath(@"~/Json/BajaCalifornia-json.json")); }
            if (idEstado == "03") { fileJson = File.ReadAllText(Server.MapPath(@"~/Json/BajaCaliforniaSur-json.json")); }
            if (idEstado == "04") { fileJson = File.ReadAllText(Server.MapPath(@"~/Json/Campeche-json.json")); }
            if (idEstado == "05") { fileJson = File.ReadAllText(Server.MapPath(@"~/Json/Chiapas-json.json")); }
            if (idEstado == "06") { fileJson = File.ReadAllText(Server.MapPath(@"~/Json/Chihuahua-json.json")); }
            if (idEstado == "07") { fileJson = File.ReadAllText(Server.MapPath(@"~/Json/CDMexico-Json.json")); }
            if (idEstado == "08") { fileJson = File.ReadAllText(Server.MapPath(@"~/Json/Coahuila-Json.json")); }
            if (idEstado == "09") { fileJson = File.ReadAllText(Server.MapPath(@"~/Json/Colima-Json.json")); }
            if (idEstado == "10") { fileJson = File.ReadAllText(Server.MapPath(@"~/Json/Durango-Json.json")); }
            if (idEstado == "11") { fileJson = File.ReadAllText(Server.MapPath(@"~/Json/Guanajuato-Json.json")); }
            if (idEstado == "12") { fileJson = File.ReadAllText(Server.MapPath(@"~/Json/Guerrero-Json.json")); }
            if (idEstado == "13") { fileJson = File.ReadAllText(Server.MapPath(@"~/Json/Hidalgo-josn.json")); }
            if (idEstado == "14") { fileJson = File.ReadAllText(Server.MapPath(@"~/Json/Jalisco-json.json")); }
            if (idEstado == "15") { fileJson = File.ReadAllText(Server.MapPath(@"~/Json/Mexico-json.json")); }
            if (idEstado == "16") { fileJson = File.ReadAllText(Server.MapPath(@"~/Json/Michoacan-json.json")); }
            if (idEstado == "17") { fileJson = File.ReadAllText(Server.MapPath(@"~/Json/Morelos-Json.json")); }
            if (idEstado == "18") { fileJson = File.ReadAllText(Server.MapPath(@"~/Json/Nayarit-Json.json")); }
            if (idEstado == "19") { fileJson = File.ReadAllText(Server.MapPath(@"~/Json/NuevoLeon-Json.json")); }
            if (idEstado == "20") { fileJson = File.ReadAllText(Server.MapPath(@"~/Json/Oaxaca-Json.json")); }
            if (idEstado == "21") { fileJson = File.ReadAllText(Server.MapPath(@"~/Json/Puebla-Json.json")); }
            if (idEstado == "22") { fileJson = File.ReadAllText(Server.MapPath(@"~/Json/Queretaro-Json.json")); }
            if (idEstado == "23") { fileJson = File.ReadAllText(Server.MapPath(@"~/Json/Quintana Roo.json")); }
            if (idEstado == "24") { fileJson = File.ReadAllText(Server.MapPath(@"~/Json/Sanluispotosi.json")); }
            if (idEstado == "25") { fileJson = File.ReadAllText(Server.MapPath(@"~/Json/Sinaloa.json")); }
            if (idEstado == "26") { fileJson = File.ReadAllText(Server.MapPath(@"~/Json/Sonora.json")); }
            if (idEstado == "27") { fileJson = File.ReadAllText(Server.MapPath(@"~/Json/Tabasco-json.json")); }
            if (idEstado == "28") { fileJson = File.ReadAllText(Server.MapPath(@"~/Json/Tamaulipas-json.json")); }
            if (idEstado == "29") { fileJson = File.ReadAllText(Server.MapPath(@"~/Json/Tlaxcala-json.json")); }
            if (idEstado == "30") { fileJson = File.ReadAllText(Server.MapPath(@"~/Json/Veracruz-json.json")); }
            if (idEstado == "31") { fileJson = File.ReadAllText(Server.MapPath(@"~/Json/Yucatan-json.json")); }
            if (idEstado == "32") { fileJson = File.ReadAllText(Server.MapPath(@"~/Json/Zacatecas-json.json")); }

            try
            {
                dsBibliografia = (DataTable)JsonConvert.DeserializeObject(fileJson, typeof(DataTable));
            }catch (Exception e) { MessageBox.Show(""+e); }
            return dsBibliografia;
        }


        // ----Recupera el prime Drop Estados
        private DataTable Buscar(string id)
        {
            DataTable dsBibliografia = new DataTable();
            DataTable dsTemporal = new DataTable();
            dsBibliografia = this.Listar();
            try
            {
                dsTemporal = this.Listar();
                dsTemporal.Clear();
            }
            catch
            {

            }
            if (id.Trim().Length > 0)
            {
                foreach (DataRow r in dsBibliografia.Rows)
                {
                        dsTemporal.ImportRow(r);
                }
            }
            else
            {
                dsTemporal = this.Listar();
            }

            return dsTemporal;
        }
        //------- Lista los municipios anidados ----
        private DataTable BuscarMunicipio(string id)
        {
            DataTable dsBibliografia = new DataTable();
            DataTable dsTemporal = new DataTable();
            dsBibliografia = this.ListarEstados(id);
            try
            {
                dsTemporal = this.ListarEstados(id);
                dsTemporal.Clear();
            }
            catch
            {

            }
            int cont = 0, i = 0;
            string[] filas = new string[dsBibliografia.Rows.Count];
            foreach (DataRow r in dsBibliografia.Rows)
            {
                foreach (string cadena in filas)
                {
                    if (r["D_mnpio"].ToString() == cadena)
                    {
                        cont++;
                    }
                }
                if (cont == 0)
                {
                    dsTemporal.ImportRow(r);
                    filas[i] = r["D_mnpio"].ToString();
                    i++;
                }

                cont = 0;
            }
            return dsTemporal;
        }
        private DataTable BuscarLocalidad(string id, string mun)
        {
            DataTable dsBibliografia = new DataTable();
            DataTable dsTemporal = new DataTable();
            dsBibliografia = this.ListarEstados(id);
            
            try
            {
                dsTemporal = this.ListarEstados(id);
                dsTemporal.Clear();
            }
            catch
            {

            }            
            int cont = 0, i = 0, a =0;
            string[] filas = new string[dsBibliografia.Rows.Count];
            foreach (DataRow r in dsBibliografia.Rows)
            {
                if (a == 0)
                {
                    if (r["D_mnpio"].ToString() == mun)
                    {
                        mun = r["c_mnpio"].ToString();
                        a++;
                    }
                }
            }
            foreach (DataRow r in dsBibliografia.Rows)
            {
                
                foreach (string cadena in filas)
                {
                    if (r["d_asenta"].ToString() == cadena)
                    {
                        cont++;
                    }
                }
                if (cont == 0 && r["c_mnpio"].ToString() == mun)
                {
                    dsTemporal.ImportRow(r);
                    filas[i] = r["d_asenta"].ToString();
                    i++;
                }

                cont = 0;
            }
            return dsTemporal;
        }
        protected void ddlEstados_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ID = "";
            string mun = "";
            ID = ddlEstados.SelectedItem.Value;
            mun = ddlEstados.SelectedItem.Text;

            ddlMunicipio.DataSource = BuscarMunicipio(ID);
            ddlMunicipio.DataMember = "c_estado";
            ddlMunicipio.DataValueField = "D_mnpio";
            ddlMunicipio.DataBind();
        }
         //--------Crear Persona------
        //protected void Button1_Click(object sender, EventArgs e)
        //{

        //    persona opersona = new persona
        //    {
        //        Nombre = txtNombre.Text,
        //        edad = Convert.ToInt32(txtEdad.Text),
        //        email = txtEmail.Text
        //    };
        //    Agregar los objetos a la clase
        //    txtNombre.Text = "";
        //    txtEdad.Text = "";
        //    txtEmail.Text = "";

        //    if (Session["ARCHIVOJSON"].ToString() == string.Empty)
        //        Session["ARCHIVOJSON"] = JsonConvert.SerializeObject(opersona);
        //    else
        //        Session["ARCHIVOJSON"] = Session["ARCHIVOJSON"].ToString() + "," + JsonConvert.SerializeObject(opersona);
        //    ListBox1.Items.Add("Nombre: " + opersona.Nombre + "Edad: " + opersona.edad + "Email: " + opersona.email);

            
        //    string fileJSON = File.ReadAllText = 
        //}

        protected void Button2_Click(object sender, EventArgs e)
        {

            File.WriteAllText(@"C:\Users\Luis Puc\Desktop\PracticasMoreno\aspnetJSON", "[" + Session["ARCHIVOJSON"].ToString() + "]");
            Response.Write("<script>alert(' JSON Listo !! ');</script>");
        }

        protected void ddlMunicipio_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ID = "";
            string mun = "";
            ID = ddlEstados.SelectedItem.Value;
            mun = ddlMunicipio.SelectedItem.Value;

                ddlLocalidad.DataSource = BuscarLocalidad(ID, mun);
                ddlLocalidad.DataMember = "D_mnpio";
                ddlLocalidad.DataValueField = "d_asenta";
                DataBind();
           
        }

        //private DataTable Listar()
        //{
        //    DataSet dsBibliografia = new DataSet();
        //    string Rutacompleta =  
        //    string ruta = Rutacompleta.Substring(0, Rutacompleta.Length - 5) + @"\JSONBibliografia.json";
        //    dsBibliografia = JsonConvert.DeserializeObject<DataSet>(File.ReadAllText(ruta));
        //    if (dsBibliografia == null)
        //    {
        //     //   MessageBox.Show("No Existen datos");
        //        return null;

        //    }
        //    else
        //    {
        //        return dsBibliografia.Tables[0];
        //    }

        //}


    }
}