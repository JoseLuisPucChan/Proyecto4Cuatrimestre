using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UTM.XML.GUI
{
    public partial class frmXML : Form
    {
        public frmXML()
        {
            InitializeComponent();
        }

        private void frmXML_Load(object sender, EventArgs e)
        {

        }
        public DataTable listarAlumnos()
        {
            DataSet dsAlumnos = new DataSet();
            string rutaCompleta = Application.StartupPath.ToString();
            string ruta = rutaCompleta.Substring(0, rutaCompleta.Length - 16) + @"UTM.XML\bin\XMLAlumno.xml";
            dsAlumnos.ReadXml(ruta);
            return dsAlumnos.Tables[0];
        }
        public DataTable buscarAlumnoNombre(string nombre, string ap, string am,string clave, string edad)
        {
            DataTable dsTemporal = new DataTable();
            DataTable dsAlumnos = new DataTable();
            dsAlumnos = listarAlumnos();
            dsTemporal = listarAlumnos();
            dsTemporal.Clear();
            //BUSCAR CON UN VALOR
            if (nombre.Length > 0 || ap.Length > 0 || am.Length >0 || edad.Length > 0)
            {
                foreach (DataRow i in dsAlumnos.Rows)
                {
                    if (i["Nombre"].ToString() == nombre || i["ApellidoPaterno"].ToString() == ap || i["ApellidoMaterno"].ToString() == am || i["Edad"].ToString() == edad)
                    {
                        dsTemporal.ImportRow(i);
                    }
                }
            }
            else//BUSCAR CON DOS VALORES
                if (nombre.Length > 0 && ap.Length > 0 || nombre.Length > 0 && am.Length > 0 || nombre.Length > 0 && edad.Length > 0 )
                {
                    foreach (DataRow i in dsAlumnos.Rows)
                    {
                        if (i["Nombre"].ToString() == nombre && i["ApellidoPaterno"].ToString() == ap)
                        {
                            dsTemporal.ImportRow(i);
                        }
                        else
                            if (i["Nombre"].ToString() == nombre && i["ApellidoMaterno"].ToString() == am)
                            {
                                dsTemporal.ImportRow(i);
                            }
                            else if (i["Nombre"].ToString() == nombre && i["Edad"].ToString() == edad)
                            {
                                dsTemporal.ImportRow(i);
                            }
                    }
                }
                else//BUSCAR CON DOS VALORES
                    if (ap.Length > 0 && am.Length > 0 || ap.Length > 0 && edad.Length > 0)
                    {
                        foreach (DataRow i in dsAlumnos.Rows)
                        {
                            if (i["ApellidoPaterno"].ToString() == ap && i["ApellidoMaterno"].ToString() == am)
                            {
                                dsTemporal.ImportRow(i);
                            }
                            else
                                if (i["ApellidoPaterno"].ToString() == ap && i["Edad"].ToString() == edad)
                                {
                                    dsTemporal.ImportRow(i);
                                }
                        }
                    }
                    else//BUSCAR CON DOS VALORES
                        if (am.Length > 0 && edad.Length > 0 )
                        {
                            foreach (DataRow i in dsAlumnos.Rows)
                            {
                                if (i["ApellidoMaterno"].ToString() == am && i["Edad"].ToString() == edad)
                                {
                                    dsTemporal.ImportRow(i);
                                }
                                else
                                    if (i["ApellidoPaterno"].ToString() == ap && i["Edad"].ToString() == edad)
                                    {
                                        dsTemporal.ImportRow(i);
                                    }
                            }
                        }
                        else//BUSCAR CON 3 VALORES
                        if (nombre.Length > 0 && ap.Length > 0 && am.Length > 0 || nombre.Length >0 && ap.Length >0 && edad.Length >0 || nombre.Length > 0 && am.Length > 0 && edad.Length >0)
                        {
                            foreach (DataRow i in dsAlumnos.Rows)
                            {
                                if (i["Nombre"].ToString() == nombre && i["ApellidoPaterno"].ToString() == ap && i["ApellidoMaterno"].ToString() == am)
                                {
                                    dsTemporal.ImportRow(i);
                                }
                                else
                                    if (i["Nombre"].ToString() == nombre && i["ApellidoPaterno"].ToString() == ap && i["Edad"].ToString() == edad)
                                {
                                    dsTemporal.ImportRow(i);
                                }
                                    else
                                        if (i["Nombre"].ToString() == nombre && i["ApellidoMaterno"].ToString() == am && i["Edad"].ToString() == edad)
                                        {
                                            dsTemporal.ImportRow(i);
                                        }
                            }
                        }
                        else//BUSCAR CON 3 VALORES
                            if (ap.Length > 0 && am.Length > 0 && edad.Length > 0 || nombre.Length > 0 && ap.Length > 0 && edad.Length > 0 || nombre.Length > 0 && am.Length > 0 && edad.Length > 0)
                            {
                                foreach (DataRow i in dsAlumnos.Rows)
                                {
                                    if (i["ApellidoPaterno"].ToString() == ap && i["ApellidoMaterno"].ToString() == am && i["Edad"].ToString() == edad)
                                    {
                                        dsTemporal.ImportRow(i);
                                    }
                                }
                            }
            else//BUSCAR CON CUATRO VALORES
                                if (nombre.Length > 0 && ap.Length > 0 && am.Length > 0 && edad.Length > 0)
                            {
                                foreach (DataRow i in dsAlumnos.Rows)
                                {
                                    if (i["Nombre"].ToString() == nombre && i["ApellidoPaterno"].ToString() == ap && i["ApellidoMaterno"].ToString() == am && i["Edad"].ToString() == edad)
                                    {
                                        dsTemporal.ImportRow(i);
                                    }
                                }
                            }

            return dsTemporal;
            
        }

        public void agregarAlumnos()
        {
            DataSet dsAlumnos = new DataSet();
            dsAlumnos.Tables.Add(listarAlumnos().Copy());
            DataRow dr;
            try
            {
                dr = dsAlumnos.Tables[0].NewRow();
                dr["ClaveAlumno"] = txtClave.Text.Trim();
                dr["Nombre"] = txtNombre.Text.Trim();
                dr["ApellidoPaterno"] = txtAP.Text.Trim();
                dr["ApellidoMaterno"] = txtAM.Text.Trim();
                dr["Edad"] = txtEdad.Text.Trim();
                dsAlumnos.Tables[0].Rows.Add(dr);
                string rutaCompleta = Application.StartupPath.ToString();
                string ruta = rutaCompleta.Substring(0, rutaCompleta.Length - 16) + @"UTM.XML\bin\XMLAlumno.xml";
                dsAlumnos.WriteXml(ruta);
                listarAlumnos();
            }
            catch
            {
                MessageBox.Show("Error de verificar los datos");
            }
        }

        public void modificarAlumno()
        {
            string id = txtClave.Text.Trim();
            DataTable dt = listarAlumnos();
            int numero = dt.Rows.Count;
            for (int i = 0; i < numero; i++)
            {
                if (dt.Rows[i]["ClaveAlumno"].ToString().Trim() == id.Trim())
                {
                    dt.Rows[i]["Nombre"] = txtNombre.Text.Trim();
                    dt.Rows[i]["ApellidoPaterno"] = txtAP.Text.Trim();
                    dt.Rows[i]["ApellidoMaterno"] = txtAM.Text.Trim();
                    dt.Rows[i]["Edad"] = txtEdad.Text.Trim();

                    string rutaCompleta = Application.StartupPath.ToString();
                    string ruta = rutaCompleta.Substring(0, rutaCompleta.Length - 16) + @"UTM.XML\bin\XMLAlumno.xml";
                    dt.WriteXml(ruta);
                    break;
                }
            }
            dgResultado.DataSource = listarAlumnos();
        }

        public void eliminarAlumno()
        {
            string id = txtClave.Text.Trim();
            DataTable dt = listarAlumnos();
            int numero = dt.Rows.Count;
            for (int i = 0; i < numero; i++)
            {
                if (dt.Rows[i]["ClaveAlumno"].ToString().Trim() == id.Trim())
                {

                    dt.Rows[i].Delete();
                    //dt.Rows[i]["Nombre"] = txtNombre.Text.Trim();
                    //dt.Rows[i]["ApellidoPaterno"] = txtAP.Text.Trim();
                    //dt.Rows[i]["ApellidoMaterno"] = txtAM.Text.Trim();
                    //dt.Rows[i]["Edad"] = txtEdad.Text.Trim();

                    string rutaCompleta = Application.StartupPath.ToString();
                    string ruta = rutaCompleta.Substring(0, rutaCompleta.Length - 16) + @"UTM.XML\bin\XMLAlumno.xml";
                    dt.WriteXml(ruta);
                    break;
                }
            }
            dgResultado.DataSource = listarAlumnos();
        }
        public void Borrar()
        {
            txtClave.Clear();
            txtNombre.Clear();
            txtAP.Clear();
            txtAM.Clear();
            txtEdad.Clear();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            dgResultado.DataSource = listarAlumnos();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgResultado.DataSource = buscarAlumnoNombre(txtNombre.Text.Trim(),txtAP.Text.Trim(),txtAM.Text.Trim(),txtClave.Text.Trim(), txtEdad.Text.Trim());
            Borrar();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            agregarAlumnos();
            dgResultado.DataSource = listarAlumnos();
            Borrar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            modificarAlumno();
            Borrar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            eliminarAlumno();
            Borrar();
        }
    }
}
