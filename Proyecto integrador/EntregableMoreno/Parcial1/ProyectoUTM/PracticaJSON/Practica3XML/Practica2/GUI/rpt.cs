using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace Practica2.GUI
{
    public partial class rpt : MetroForm
    {

        //---------------------Costructor-------------
        public rpt()
        {
            InitializeComponent();
        }

        public rpt(DataTable dt)
        {
            InitializeComponent();
            CargarReporte(dt);
        }

        //---------------------Eventos----------------

        private void rpt_Load(object sender, EventArgs e)
        {

        }
        //---------------------Metodos----------------

        //-----Cargar reporte----

        private void CargarReporte(DataTable dt)
        {
            ReportDocument cryrpt = new ReportDocument();
            string mystr = Application.StartupPath;


            //string path = mystr.Substring(0, mystr.Length - 9);
            string path = mystr.Substring(0, mystr.Length - 9) + @"GUI\Reporte\CrystalReport1.rpt";
            cryrpt.Load(path);
            cryrpt.DataSourceConnections.Clear();
            cryrpt.SetDataSource(dt);
            crvLibro.ReportSource = cryrpt;
            crvLibro.Refresh();
        }


    }
}
