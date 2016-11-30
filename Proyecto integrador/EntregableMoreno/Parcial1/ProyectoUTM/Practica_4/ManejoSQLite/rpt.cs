using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace ManejoSQLite
{
    public partial class rpt : Form
    {
        public rpt()
        {
            InitializeComponent();
        }
        public rpt(DataTable dt)
        {
            InitializeComponent();
            CargarReporte(dt);
        }

        private void CargarReporte(DataTable dt)
        {
            ReportDocument cryrpt = new ReportDocument();
            string mystr = Application.StartupPath;


            //string path = mystr.Substring(0, mystr.Length - 9);
            string path = mystr.Substring(0, mystr.Length - 9) + @"Reporte\CrystalReport1.rpt";
            cryrpt.Load(path);
            cryrpt.DataSourceConnections.Clear();
            cryrpt.SetDataSource(dt);
            crvLibro.ReportSource = cryrpt;
            crvLibro.Refresh();
        }
        private void rpt_Load(object sender, EventArgs e)
        {

        }
    }
}
