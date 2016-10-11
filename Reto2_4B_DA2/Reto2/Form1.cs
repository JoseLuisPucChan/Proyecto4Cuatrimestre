using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Windows.Forms;

namespace Reto2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LeerPaginaCinemex();
        }

        private void LeerPaginaCinemex()
        {
             WebRequest request = WebRequest.Create("http://cinemex.com/cartelera/zona-86/merida/");

            // Obtener la respuesta.
            WebResponse response = request.GetResponse();

            // Abrir el stream de la respuesta recibida.
            StreamReader reader = new StreamReader(response.GetResponseStream());

            // Leer el contenido.
            string res = reader.ReadToEnd();

            // Cerrar los streams abiertos.
            reader.Close();
            response.Close();

            string[,] lista = new string[100,3];
            string cadena = "", tamaño = "", sede = "";
            int cont = 0, posicion = 0, car = 0;
            foreach (char dato in res)
            {
                cadena += dato;
                tamaño += dato;
                if (dato == ' ')
                {
                    cadena = "";
                }
                if (dato == '>') 
                {
                    if (cadena == "class=\"billboard-block-title\">")
                    {
                        cont = 0;
                        car = 0;
                        cont = tamaño.Length;
                        while (res.Substring(cont, 1) != "<" )
                        {
                            if (car == 0)
                            {
                                sede = res.Substring(cont, 1);
                            }
                            else
                            {
                                sede += res.Substring(cont, 1);
                            }
                            cont++;
                            car++;
                        }
                        cont = 0;
                        cadena = "";
                    }
                    if (cadena == "class=\"mycinema-item-title\">")
                    {
                        cont = 0;
                        cont = tamaño.Length;
                        while (res.Substring(cont, 1) != "<")
                        {
                            foreach (string titulo in lista)
                            {

                            }
                            if (cont == 0)
                            {
                                lista[posicion,1] = res.Substring(cont, 1);
                            }
                            else
                            {
                                lista[posicion,1] += res.Substring(cont, 1);
                            }
                            cont++;
                        }
                        lista[posicion, 0] = sede.Trim();
                        cont = 0;
                        cadena = "";
                        posicion++;
                    }
                    string hr = "";
                    if (cadena.Length > 10)
                    {
                        //    hr = cadena.Substring(cadena.Length - 6, 4);
                        //}

                        //try
                        //{
                        //    hora = Convert.ToInt32(hr);
                        //}
                        //catch
                        //{ }
                        hr = cadena.Substring(0, 10);
                        if ( hr == "data-time=\"")
                        {
                            if (lista[posicion, 2] == null || lista[posicion, 2] == "")
                            {
                                lista[posicion, 2] = res.Substring(cont, 2) + ":" + res.Substring(cont + 2, 2);
                            }
                            else
                            {
                                lista[posicion, 2] += ", " + res.Substring(cont, 2) + ":" + res.Substring(cont + 2, 2);
                            }
                            cont = 0;
                            posicion++;
                            cadena = "";
                        }
                    }
                }
            }
            string comp = "";
            for (int i = 0; i < lista.Length; i++)
            {
                try
                {
                    if (lista[i, 1] != null)
                    {

                        comp += "Título: " + lista[i, 1] + " \n" + "Horarios: " + lista[i, 2] + " \n";

                    }
                }
                catch { }
            }
            textBox1.Text = comp;

        }
    }
}
