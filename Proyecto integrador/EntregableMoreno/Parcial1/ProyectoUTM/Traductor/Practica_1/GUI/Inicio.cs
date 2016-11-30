using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Practica_1.GUI
{
    public partial class Inicio : Form
    {

        ArrayList contenidoIngles;
        ArrayList contenidoEspañol;
        ArrayList contenidoMaya;
        public Inicio()
        {
            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            cboTraducir1.Text = "ESPAÑOL";
            cboTraducir2.Text = "INGLES";
            Leer();

        }

        public void Leer()
        {
            // lee el archivo de texto en ingles
            string RutaCompleta = Application.StartupPath.ToString();
            string ruta = RutaCompleta.Substring(0, RutaCompleta.Length -5) + "Ingles.txt";
            StreamReader objReader = new StreamReader(ruta, System.Text.Encoding.Default);
            string leelinea;
            contenidoIngles = new ArrayList();
            while (objReader.Peek() > -1)
            {
                leelinea = objReader.ReadLine();
                contenidoIngles.Add(leelinea);
            }

            // lee el archivo de texto en español
            string RutaCompletaEspañol = Application.StartupPath.ToString();
            string rutaEspañol = RutaCompleta.Substring(0, RutaCompletaEspañol.Length - 5) + "Español.txt";
            StreamReader objReaderEspañol = new StreamReader(rutaEspañol, System.Text.Encoding.Default);
            string leelineaEspañol;
            contenidoEspañol = new ArrayList();
            while (objReaderEspañol.Peek() > -1)
            {
                leelineaEspañol = objReaderEspañol.ReadLine();
                contenidoEspañol.Add(leelineaEspañol);
            }
            // lee el archivo de texto en maya
            string RutaCompletaMaya = Application.StartupPath.ToString();
            string rutaMaya = RutaCompletaMaya.Substring(0, RutaCompletaMaya.Length - 5) + "Maya.txt";
            StreamReader objReaderMaya = new StreamReader(rutaMaya, System.Text.Encoding.Default);
            string leelineaMaya;
            contenidoMaya = new ArrayList();
            while(objReaderMaya.Peek() > -1)
            {
                leelineaMaya = objReaderMaya.ReadLine();
                contenidoMaya.Add(leelineaMaya);
            }
        }
        public string EspañolIngles(string entrada)
        {
            string salida = "";
            bool encontrar = false;
            int contador = 0;
            while (encontrar == false)
            {
                if (contenidoEspañol[contador].ToString() == entrada)
                {
                    encontrar = true;
                    salida = contenidoIngles[contador].ToString();
                }
                
                contador++;
            }
            
            return salida;
        }

        public string InglesEspañol(string entrada)
        {
            string salida = "";
            bool encontrar = false;
            int contador = 0;
            while (encontrar == false)
            {
                if (contenidoIngles[contador].ToString() == entrada )
                {
                    encontrar = true;
                    salida = contenidoEspañol[contador].ToString();                    
                }
                contador++;
            }
            return salida;
        }
        public string EspañolMaya(string entrada)
        {
            string salida = "";
            bool encontrar = false;
            int contador = 0;
            while (encontrar == false)
            {
                if (contenidoEspañol[contador].ToString() == entrada)
                {
                    encontrar = true;
                    salida = contenidoMaya[contador].ToString();
                }
                contador++;
            }
            return salida;
        }
        public string MayaEspañol(string entrada)
        {
            string salida = "";
            bool encontrar = false;
            int contador = 0;
            while (encontrar == false)
            {
                if (contenidoMaya[contador].ToString() == entrada)
                {
                    encontrar = true;
                    salida = contenidoEspañol[contador].ToString();
                }
                contador++;
            }
            return salida;
        }
        public string InglesMaya(string entrada)
        {
            string salida = "";
            bool encontrar = false;
            int contador = 0;
           
        
                while (encontrar == false)
                {
                    if (contenidoIngles[contador].ToString() == entrada)
                    {
                        encontrar = true;
                        salida = contenidoMaya[contador].ToString();
                    }
                    contador++;
                }
                return salida;
        }
        public string MayaIngles(string entrada)
        {
            string salida = "";
            bool encontrar = false;
            int contador = 0;
            while (encontrar == false)
            {
                if (contenidoMaya[contador].ToString() == entrada)
                {
                    encontrar = true;
                    salida = contenidoIngles[contador].ToString();
                }
                contador++;
            }
            return salida;
        }
        private void btnTraducir_Click(object sender, EventArgs e)
        {

            try
            {
                if (cboTraducir1.SelectedItem.ToString() == "INGLES" && cboTraducir2.SelectedItem.ToString() == "ESPAÑOL")
                {
                    txtTraducir2.Text = InglesEspañol(txtTraducir1.Text);
                }
                else if (cboTraducir1.SelectedItem.ToString() == "ESPAÑOL" && cboTraducir2.SelectedItem.ToString() == "INGLES")
                {
                    txtTraducir2.Text = EspañolIngles(txtTraducir1.Text);
                }
                else if (cboTraducir1.SelectedItem.ToString() == "ESPAÑOL" && cboTraducir2.SelectedItem.ToString() == "MAYA")
                {
                    txtTraducir2.Text = EspañolMaya(txtTraducir1.Text);
                }
                else if (cboTraducir1.SelectedItem.ToString() == "MAYA" && cboTraducir2.SelectedItem.ToString() == "ESPAÑOL")
                {
                    txtTraducir2.Text = MayaEspañol(txtTraducir1.Text);
                }
                else if (cboTraducir1.SelectedItem.ToString() == "INGLES" && cboTraducir2.SelectedItem.ToString() == "MAYA")
                {
                    txtTraducir2.Text = InglesMaya(txtTraducir1.Text);
                }
                else if (cboTraducir1.SelectedItem.ToString() == "MAYA" && cboTraducir2.SelectedItem.ToString() == "INGLES")
                {
                    txtTraducir2.Text = MayaIngles(txtTraducir1.Text);
                }
                
            }
            catch
            {
                MessageBox.Show("No se encuentra la palabra, proxima actualización!");
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string palabra = "";
            if(cboTraducir1.SelectedItem.ToString() == "ESPAÑOL" && cboTraducir2.SelectedItem.ToString() == "INGLES")
            {
                
                cboTraducir1.Text = "INGLES";
                cboTraducir2.Text = "ESPAÑOL";
                palabra = txtTraducir2.Text;
                txtTraducir2.Text = txtTraducir1.Text;
                txtTraducir1.Text = palabra;
                
            }
            else if (cboTraducir1.SelectedItem.ToString() == "INGLES" && cboTraducir2.SelectedItem.ToString() == "ESPAÑOL")
            {
                
                cboTraducir1.Text = "ESPAÑOL";
                cboTraducir2.Text = "INGLES";
                palabra = txtTraducir2.Text;
                txtTraducir2.Text = txtTraducir1.Text;
                txtTraducir1.Text = palabra;
            }
            else if (cboTraducir1.SelectedItem.ToString() == "ESPAÑOL" && cboTraducir2.SelectedItem.ToString() == "MAYA")
            {
                cboTraducir1.Text = "MAYA";
                cboTraducir2.Text = "ESPAÑOL";
                palabra = txtTraducir2.Text;
                txtTraducir2.Text = txtTraducir1.Text;
                txtTraducir1.Text = palabra;
            }
            else if (cboTraducir1.SelectedItem.ToString() == "MAYA" && cboTraducir2.SelectedItem.ToString() == "ESPAÑOL")
            {
                cboTraducir1.Text = "ESPAÑOL";
                cboTraducir2.Text = "MAYA";
                palabra = txtTraducir2.Text;
                txtTraducir2.Text = txtTraducir1.Text;
                txtTraducir1.Text = palabra;
            }
            else if (cboTraducir1.SelectedItem.ToString() == "INGLES" && cboTraducir2.SelectedItem.ToString() == "MAYA")
            {
                cboTraducir1.Text = "MAYA";
                cboTraducir2.Text = "INGLES";
                palabra = txtTraducir2.Text;
                txtTraducir2.Text = txtTraducir1.Text;
                txtTraducir1.Text = palabra;
            }
            else if (cboTraducir1.SelectedItem.ToString() == "MAYA" && cboTraducir2.SelectedItem.ToString() == "INGLES")
            {
                cboTraducir1.Text = "INGLES";
                cboTraducir2.Text = "MAYA";
                palabra = txtTraducir2.Text;
                txtTraducir2.Text = txtTraducir1.Text;
                txtTraducir1.Text = palabra;
            }
            else
            {
                MessageBox.Show("No Se Ha Seleccionado Ningun Idioma");
            }
        }

        private void cboTraducir1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTraducir1.Text == "INGLES")
            {
                pcbImagen1.Image = Properties.Resources.Ingles;
            }
            else
                if (cboTraducir1.Text == "ESPAÑOL")
                {
                    pcbImagen1.Image = Properties.Resources.españa;
                }
            else
                    if (cboTraducir1.Text == "MAYA")
                    {
                        pcbImagen1.Image = Properties.Resources.MAYA3;
                    }
        }

        private void cboTraducir2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTraducir2.Text == "INGLES")
            {
                
                pcbImagen2.Image = Properties.Resources.Ingles;
            }
            else
                if (cboTraducir2.Text == "ESPAÑOL")
                {
                    
                    pcbImagen2.Image = Properties.Resources.españa;
                }
            else
                    if (cboTraducir2.Text == "MAYA")
                    {
                        
                        pcbImagen2.Image = Properties.Resources.MAYA3;
                    }
            
        }
    }
}
