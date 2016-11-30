using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AgendaContactos
{
    public partial class Agenda : Form
    {
        public Agenda()
        {
            InitializeComponent();
            dgvResultado.DataSource = listarPersonas();
        }

        public DataTable listarPersonas()
        {
            DataSet dsPersona = new DataSet();
            string rutacompleta = Application.StartupPath.ToString();
            string ruta = rutacompleta.Substring(0, rutacompleta.Length - 5) + @"\XMLAgenda.xml";
            dgvResultado.AutoGenerateColumns = false;
            dgvResultado.DataSource = null;
            dsPersona.ReadXml(ruta);
            return dsPersona.Tables[0];
        }

        public DataTable buscarPersona(string ID, string N, string AP, string AM, string E, string LN, string FN, string Tel)
        {
            DataTable dstemporal = new DataTable();
            DataTable dsPersona = new DataTable();
            dsPersona = listarPersonas();
            dstemporal = listarPersonas();
            dstemporal.Clear();

            if (ID.Length > 0 || N.Length > 0 || AP.Length > 0 || AM.Length > 0 || E.Length > 0 || LN.Length > 0 || Tel.Length > 0)
            {
                foreach (DataRow i in dsPersona.Rows)
                {
                    if (i["ID"].ToString() == ID || i["Nombre"].ToString() == N || i["AP"].ToString() == AP || i["AM"].ToString() == AM || i["Edad"].ToString() == E || i["LugarNacimiento"].ToString() == LN || i["FechaNacimiento"].ToString() == LN || i["Telefono"].ToString() == Tel)
                    {
                        dstemporal.ImportRow(i);
                    }
                }
            }
            return dstemporal;
        }

        public DataTable buscarPersonfecha(string FN)
        {
            DataTable dstemporal = new DataTable();
            DataTable dsPersona = new DataTable();
            dsPersona = listarPersonas();
            dstemporal = listarPersonas();
            dstemporal.Clear();

            if (FN.Length > 0)
            {
                foreach (DataRow i in dsPersona.Rows)
                {
                    if (i["FechaNacimiento"].ToString().Remove(12, 8) == FN)
                    {
                        dstemporal.ImportRow(i);
                    }
                }
            }
            return dstemporal;
        }

        public DataTable felicitar(string N)
        {
            DataTable dstemporal = new DataTable();
            DataTable dsPersona = new DataTable();
            dsPersona = listarPersonas();
            dstemporal = listarPersonas();
            dstemporal.Clear();

            if (N.Length > 0)
            {
                foreach (DataRow i in dsPersona.Rows)
                {
                    if (i["Nombre"].ToString() == N)
                    {
                        dstemporal.ImportRow(i);
                    }
                }
            }
            return dstemporal;
        }

        public string convertirimagenstring()
        {
            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            byte[] imageBytes = ms.ToArray();

            //convertir imagen a base64
            string Imagen = Convert.ToBase64String(imageBytes);
            return Imagen;
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            dgvResultado.DataSource = buscarPersona(txtid.Text.Trim(), txtnombre.Text.Trim(), txtap.Text.Trim(), txtam.Text.Trim(), txtedad.Text.Trim(), txttelefono.Text.Trim(), txtln.Text.Trim(), txtfn.Text.Trim());
        }

        private void btnlistar_Click(object sender, EventArgs e)
        {
            dgvResultado.DataSource = listarPersonas();
        }

        private void dgvResultado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                if (this.dgvResultado.Columns[e.ColumnIndex].Name == "Editar")
                {
                    {
                        string dato1;
                        dato1 = dgvResultado.CurrentRow.Cells["IIDE"].EditedFormattedValue.ToString();
                        DataTable dtble = new DataTable();
                        dtble = this.buscarPersona(dato1, "", "", "", "", "", "", "");
                        EditarPersona editar = new EditarPersona(dtble);
                        editar.ShowDialog();
                        dgvResultado.DataSource = null;
                    }
                }
            }
        }

        private void dgvResultado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            EditarPersona oEditarPersona = new EditarPersona();
            oEditarPersona.ShowDialog();
            dgvResultado.DataSource = null;
        }

        public void checarcumpleaños()
        {
            foreach (DataGridViewRow row in dgvResultado.Rows)
            {
                string fecha = row.Cells[8].Value.ToString();

                txtfecha.Text = fecha.Remove(12, 8);
                //string hoy = DateTime.Today.ToString();
                string fechacomparador = dtpfechaactual.Text;
                fechacomparador = fechacomparador.Remove(0, 7);
                fechacomparador = fechacomparador.Remove(12, 8);

                if (txtfecha.Text == fechacomparador)
                {
                    dataGridView1.AutoGenerateColumns = false;
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = buscarPersonfecha(txtfecha.Text.Trim());
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            checarcumpleaños();
            dgvResultado.DataSource = listarPersonas();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                if (this.dataGridView1.Columns[e.ColumnIndex].Name == "felicitar1")
                {
                    Felicitacion feliz = new Felicitacion();
                    feliz.ShowDialog();
                }
            }
        }
    }
}


