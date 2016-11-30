using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Reto3.BO;
using Reto3.Services;
using System.Data;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using Reto3.GUI;
using Newtonsoft.Json;
using System.Data.SQLite;
using System.IO;

namespace Reto3.GUI
{
    public partial class Principal : System.Web.UI.Page
    {
        AlumnoCTRL servicio = new AlumnoCTRL();
        DataSet tabla = new DataSet();
        int inicio = 0, fin = 0, cantidad = 0, paginas = 0, seleccionP = 1;

        protected void gvDatos_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvDatos.PageIndex = e.NewPageIndex;
            RecuperarDatos();
        }

        protected void btnImprimirTodo_Click(object sender, EventArgs e)
        {
            imprimirReporteTodo();
        }

        protected void btnImprimirActual_Click(object sender, EventArgs e)
        {
            imprimirReporteActual();
        }

        protected void ddlCantidad_SelectedIndexChanged(object sender, EventArgs e)
        { 
            RecuperarDatos();
            servicio.DefinirCantidad(cantidad);
        }

        protected void btnImprimirPaginas_Click(object sender, EventArgs e)
        {
            try
            {
                int pagina = 0, paginaAct = gvDatos.PageIndex;
                string cadena = "";
                DataTable dt = new DataTable();
                for (int i = 0; i < txtPaginas.Text.Length; i++)
                {
                    cadena += txtPaginas.Text.Substring(i, 1);
                    if (i == txtPaginas.Text.Length - 1)
                    {
                        pagina = Convert.ToInt32(cadena.Substring(0, cadena.Length).Trim());
                        cadena = "";
                        gvDatos.PageIndex = pagina;
                        cantidad = Convert.ToInt32(ddlCantidad.SelectedValue);
                        gvDatos.PageSize = cantidad;
                        fin = pagina * cantidad;
                        inicio = cantidad * (pagina - 1);
                        dt.Merge(servicio.BuscarAlumno(inicio, fin));
                    }
                    if (txtPaginas.Text.Substring(i, 1) == ",")
                    {
                        pagina = Convert.ToInt32(cadena.Substring(0, cadena.Length - 1).Trim());
                        cadena = "";
                        gvDatos.PageIndex = pagina;
                        cantidad = Convert.ToInt32(ddlCantidad.SelectedValue);
                        gvDatos.PageSize = cantidad;
                        fin = pagina * cantidad;
                        inicio = cantidad * (pagina - 1);
                        dt.Merge(servicio.BuscarAlumno(inicio, fin));
                    }
                }
                imprimirReportePaginas(dt);
                gvDatos.PageIndex = paginaAct;
            }
            catch
            {

            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddlCantidad.SelectedValue = Convert.ToString(servicio.LeerCantidad());
                RecuperarDatos();
            }
        }

        private void RecuperarDatos()
        {
            seleccionP = gvDatos.PageIndex + 1;
            cantidad = Convert.ToInt32(ddlCantidad.SelectedValue);
            gvDatos.PageSize = cantidad;
            gvDatos.DataSource = servicio.BuscarAlumno();
            gvDatos.DataBind();
        }

        protected void btnJSON_Click(object sender, EventArgs e)
        {
            CrearArchivoJson();
        }

        protected void btnXML_Click(object sender, EventArgs e)
        {
            CrearXML();
        }

        public void CrearXML()
        {
            DataSet dt = servicio.BuscarAlumnoxml();
            string Rutacompleta1 = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\RPBDAlumnos.xml";
            StreamWriter xmlDoc = new StreamWriter(Rutacompleta1, false);
            dt.WriteXml(xmlDoc);
            xmlDoc.Close();
        }
        private void CrearArchivoJson()
        {
            DataSet dsBibliografia = new DataSet();
            string Rutacompleta = Server.MapPath("JsonAlumnos.json");
            dsBibliografia = JsonConvert.DeserializeObject<DataSet>(File.ReadAllText(Rutacompleta));
            dsBibliografia.Clear();
            DataSet dt = servicio.BuscarAlumnoxml();
            dsBibliografia = dt;
            string JSON = JsonConvert.SerializeObject(dsBibliografia);
            string Rutacompleta1 = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\JsonAlumnos1.json";
            File.WriteAllText(Rutacompleta1, JSON);
        }

        private void imprimirReporteTodo()
        {
            DataTable dt = servicio.BuscarAlumno();
            string ruta = Server.MapPath("CRAlumnos.rpt");
            ReportDocument doc = new ReportDocument();
            doc.Load(ruta);
            doc.SetDataSource(dt);
            Response.Buffer = false;
            Response.ClearContent();
            Response.ClearHeaders();
            doc.ExportToHttpResponse(ExportFormatType.PortableDocFormat, Response, false, "Alumno");
        }

        private void imprimirReportePaginas(DataTable dt)
        {
            string ruta = Server.MapPath("CRAlumnos.rpt");
            ReportDocument doc = new ReportDocument();
            doc.Load(ruta);
            doc.SetDataSource(dt);
            Response.Buffer = false;
            Response.ClearContent();
            Response.ClearHeaders();
            doc.ExportToHttpResponse(ExportFormatType.PortableDocFormat, Response, false, "Alumno");
        }

        private void imprimirReporteActual()
        {
            seleccionP = gvDatos.PageIndex + 1;
            cantidad = Convert.ToInt32(ddlCantidad.SelectedValue);
            gvDatos.PageSize = cantidad;
            paginas = 100000 / cantidad;
            fin = seleccionP * cantidad;
            inicio = cantidad * (seleccionP - 1);
            DataTable dt = servicio.BuscarAlumno(inicio, fin);
            string ruta = Server.MapPath("CRAlumnos.rpt");
            ReportDocument doc = new ReportDocument();
            doc.Load(ruta);
            doc.SetDataSource(dt);
            Response.Buffer = false;
            Response.ClearContent();
            Response.ClearHeaders();
            doc.ExportToHttpResponse(ExportFormatType.PortableDocFormat, Response, false, "Alumno");

        }
        

    }
}