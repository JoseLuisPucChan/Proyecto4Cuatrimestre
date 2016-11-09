using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using WMPLib;


namespace Practica1Postales.GUI
{
    public partial class PostalCampo : Form
    {
        Thread f;
        Thread n;
        Thread s;
        Thread p;
        Thread a;
        const int Cont = 10;
        WindowsMediaPlayer musica = new WindowsMediaPlayer();
        public PostalCampo()
        {
            InitializeComponent();
            //Flores
            f = new Thread(Flor1);
            f.Start();
            f = new Thread(Flor2);
            f.Start();
            //Nubes
            n = new Thread(Nubes);
            n.Start();
            n = new Thread(Nubes1);
            n.Start();
            //Sol
            s = new Thread(Sol);
            s.Start();
            //Pajarito
            p = new Thread(Pajarito);
            p.Start();
            //Abeja
            a = new Thread(Abeja);
            a.Start();
            
            
        }
        public void Musica()
        {
            musica.URL = @"C:\4toCuatrimestre\Aplicaciones\Parcial2\PracticasCuartoParcial\Practica1Postales\Practica1Postales\Resources\Naturaleza.wav";
            musica.controls.play();
            
        }
        public void Flor1()
        {
            try
            {
                while (true)
                {
                    pictureBox1.Image = Practica1Postales.Properties.Resources.margarita1;
                    pictureBox1.Image = Practica1Postales.Properties.Resources.margarita2;
                    Thread.Sleep(100);

                    pictureBox1.Image = Practica1Postales.Properties.Resources.margarita2;
                    pictureBox1.Image = Practica1Postales.Properties.Resources.margarita3;
                    Thread.Sleep(100);

                    pictureBox1.Image = Practica1Postales.Properties.Resources.margarita3;
                    pictureBox1.Image = Practica1Postales.Properties.Resources.margarita4;
                    Thread.Sleep(100);

                    pictureBox1.Image = Practica1Postales.Properties.Resources.margarita4;
                    pictureBox1.Image = Practica1Postales.Properties.Resources.margarita5;
                    Thread.Sleep(100);

                    pictureBox1.Image = Practica1Postales.Properties.Resources.margarita5;
                    pictureBox1.Image = Practica1Postales.Properties.Resources.margarita1;
                    Thread.Sleep(100);
                }
            }
            catch { }
        }

        public void Flor2()
        {
            try
            {
                while (true)
                {
                    pictureBox2.Image = Practica1Postales.Properties.Resources.margarita4;
                    pictureBox2.Image = Practica1Postales.Properties.Resources.margarita5;
                    Thread.Sleep(100);

                    pictureBox2.Image = Practica1Postales.Properties.Resources.margarita5;
                    pictureBox2.Image = Practica1Postales.Properties.Resources.margarita1;
                    Thread.Sleep(100);

                    pictureBox2.Image = Practica1Postales.Properties.Resources.margarita1;
                    pictureBox2.Image = Practica1Postales.Properties.Resources.margarita2;
                    Thread.Sleep(100);

                    pictureBox2.Image = Practica1Postales.Properties.Resources.margarita2;
                    pictureBox2.Image = Practica1Postales.Properties.Resources.margarita3;
                    Thread.Sleep(100);

                    pictureBox2.Image = Practica1Postales.Properties.Resources.margarita3;
                    pictureBox2.Image = Practica1Postales.Properties.Resources.margarita4;
                    Thread.Sleep(100);
                }
            }
            catch { }
        }
        public void Sol()
        {
            while (true)
            {
                pictureBox5.Image = Practica1Postales.Properties.Resources.SOL1;
                pictureBox5.Image = Practica1Postales.Properties.Resources.SOL2;
                Thread.Sleep(500);

                pictureBox5.Image = Practica1Postales.Properties.Resources.SOL2;
                pictureBox5.Image = Practica1Postales.Properties.Resources.SOL3;
                Thread.Sleep(500);

                pictureBox5.Image = Practica1Postales.Properties.Resources.SOL3;
                pictureBox5.Image = Practica1Postales.Properties.Resources.SOL4;
                Thread.Sleep(500);

                pictureBox5.Image = Practica1Postales.Properties.Resources.SOL4;
                pictureBox5.Image = Practica1Postales.Properties.Resources.SOL5;
                Thread.Sleep(500);

                pictureBox5.Image = Practica1Postales.Properties.Resources.SOL5;
                pictureBox5.Image = Practica1Postales.Properties.Resources.SOL1;
                Thread.Sleep(500);
            }
        }

        public void Nubes()
        {
            try
            {
                while (n != null)
                {
                    for (int i = 0; i < 150; i++)
                    {
                        Thread.Sleep(80);
                        pictureBox3.Left += Cont;

                    }

                    for (int b = 0; b < 150; b++)
                    {
                        Thread.Sleep(80);
                        pictureBox3.Left -= Cont;
                        //pictureBox3.Visible = false;

                    }
                    pictureBox3.Visible = true;
                }
            }
            catch { }
        }

        public void Nubes1()
        {
            try
            {
                while (n != null)
                {
                    for (int i = 0; i < 150; i++)
                    {
                        Thread.Sleep(80);
                        pictureBox4.Left -= Cont;

                    }

                    for (int b = 0; b < 150; b++)
                    {
                        Thread.Sleep(80);
                        pictureBox4.Left += Cont;
                        //pictureBox4.Visible = false;

                    }
                    pictureBox4.Visible = true;
                }
            }
            catch
            { }
        }

        public void Pajarito()
        {
            try
            {
                while (p != null)
                {
                    for (int i = 0; i < 150; i++)
                    {
                        Thread.Sleep(30);
                        pictureBox6.Left -= Cont;

                    }

                    for (int b = 0; b < 150; b++)
                    {
                        Thread.Sleep(10);
                        pictureBox6.Left += Cont;
                        pictureBox6.Visible = false;

                    }
                    pictureBox6.Visible = true;
                }
            }
            catch { }
        }
        public void Abeja()
        {
            try
            {
                while (a != null)
                {
                    for (int i = 0; i < 150; i++)
                    {
                        Thread.Sleep(50);
                        pictureBox7.Left -= Cont;

                    }

                    for (int b = 0; b < 150; b++)
                    {
                        Thread.Sleep(10);
                        pictureBox7.Left += Cont;
                        pictureBox7.Visible = false;

                    }
                    pictureBox7.Visible = true;
                }
            }
            catch { }
        }

        
        private void PostalCampo_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            Musica();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void PostalCampo_FormClosing(object sender, FormClosingEventArgs e)
        {
            musica.controls.stop();
        }

        
        
        
    }
}
