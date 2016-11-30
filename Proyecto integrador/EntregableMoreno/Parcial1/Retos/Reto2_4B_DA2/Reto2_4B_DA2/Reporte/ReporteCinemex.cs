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

namespace Reto2_4B_DA2.Reporte
{
    public partial class ReporteCinemex : Form
    {
        public DataSet ds = new DataSet();
        public string tabla = "";

        public ReporteCinemex()
        {
            InitializeComponent();
        }

        public ReporteCinemex(DataSet dst, string tb)
        {
            InitializeComponent();
            ds = dst;
            tabla = tb;
        }


        private void ReporteCinemex_Load(object sender, EventArgs e)
        {
            GenerarReporte();
        }

        private void GenerarReporte()
        {
            ReportDocument cryrpt = new ReportDocument();
            string mystr = Application.StartupPath;
            string path = "";
            if (tabla == "Todos")
            {
                path = mystr.Substring(0, mystr.Length - 22) + @"Reto2_4B_DA2\Reporte\crCinemex.rpt";
            }
            else
            {
                if (tabla == "Cinemex Canek")
                {
                    path = mystr.Substring(0, mystr.Length - 22) + @"Reto2_4B_DA2\Reporte\crCinemexCanek.rpt";
                }
                else
                {
                    if (tabla == "Cinemex City Center Mérida")
                    {
                        path = mystr.Substring(0, mystr.Length - 22) + @"Reto2_4B_DA2\Reporte\crCinemexCity.rpt";
                    }
                    else
                    {
                        if (tabla == "Cinemex Galerías Mérida")
                        {
                            path = mystr.Substring(0, mystr.Length - 22) + @"Reto2_4B_DA2\Reporte\crCinemexGalerias.rpt";
                        }
                        else
                        {
                            if (tabla == "Cinemex Galerías Mérida Platino")
                            {
                                path = mystr.Substring(0, mystr.Length - 22) + @"Reto2_4B_DA2\Reporte\crCinemexGaleriasP.rpt";
                            }
                            else
                            {
                                if (tabla == "Cinemex Gran Plaza Mérida")
                                {
                                    path = mystr.Substring(0, mystr.Length - 22) + @"Reto2_4B_DA2\Reporte\crCinemexGranP.rpt";
                                }
                                else
                                {
                                    if (tabla == "Cinemex Macroplaza Mérida")
                                    {
                                        path = mystr.Substring(0, mystr.Length - 22) + @"Reto2_4B_DA2\Reporte\crCinemexMacro.rpt";
                                    }
                                    else
                                    {
                                        if (tabla == "Cinemex Península Montejo Platino")
                                        {
                                            path = mystr.Substring(0, mystr.Length - 22) + @"Reto2_4B_DA2\Reporte\crCinemexPenin.rpt";
                                        }
                                        else
                                        {
                                            if (tabla == "Cinemex Rex Mérida")
                                            {
                                                path = mystr.Substring(0, mystr.Length - 22) + @"Reto2_4B_DA2\Reporte\crCinemexRex.rpt";
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            cryrpt.Load(path);
            cryrpt.DataSourceConnections.Clear();
            cryrpt.SetDataSource(ds);
            crvReporte.ReportSource = cryrpt;
            crvReporte.Refresh();
        }



    }
}
