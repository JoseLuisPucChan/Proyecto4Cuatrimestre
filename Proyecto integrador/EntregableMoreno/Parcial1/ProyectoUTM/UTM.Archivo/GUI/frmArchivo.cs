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
using System.Collections;
namespace UTM.SI.GUI
{
    public partial class frmArchivo : Form
    {
        public frmArchivo()
        {
            InitializeComponent();
        }
        
        public void leerarchivo()
        {
            
            string rutacompleta = Application.StartupPath.ToString();
            string ruta = rutacompleta.Substring(0, rutacompleta.Length - 16) + @"UTM.Archivo\bin\FExamen.txt";
            StreamReader objReader = new StreamReader(ruta, System.Text.Encoding.Default);
            string leelinea;
            int conta = 0;
            ArrayList contenido = new ArrayList();
            while(objReader.Peek() > -1)
            {
                leelinea = objReader.ReadLine();
                contenido.Add(leelinea);
            }
            objReader.Close();
            foreach (string datos in contenido)
            {
                txtDatos.Text += datos.ToString() + Environment.NewLine;
                if (datos.ToString() == "Parcial 2")
                {
                    conta = 1;
                }
                if (datos.ToString() == "Parcial 3")
                {
                    conta = 2;
                }
                switch (conta)
                {
                    case 0:
                        txtParcial1.Text += datos.ToString() + Environment.NewLine;
                        break;
                    case 1:
                        txtParcial2.Text += datos.ToString() + Environment.NewLine;
                        break;
                    case 2:
                        txtParcial3.Text += datos.ToString() + Environment.NewLine;
                        break;
                }
            }
        }
        private void btnTraer_Click(object sender, EventArgs e)
        {
            leerarchivo();
        }
    }
}
