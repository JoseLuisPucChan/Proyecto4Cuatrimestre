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
    public partial class PostalNavideña : Form
    {
        //--------------Variables de mis hilos
        Thread p;
        Thread s;
        Thread o;
        Thread a;
        Thread e;
        Thread r;
        const int Cont = 10;
        //----------------- Agregar musica
        WindowsMediaPlayer mus = new WindowsMediaPlayer();
        //------------Metodos
        public void Musi()
        {
            mus.URL = @"C:\4toCuatrimestre\Aplicaciones\Parcial2\PracticasCuartoParcial\Practica1Postales\Practica1Postales\Resources\Nochedepaz.mp3";
            mus.controls.play();
        }
        public PostalNavideña()
        {
            InitializeComponent();
            //Letras
            p = new Thread(FelizNavidad);
            p.Start();
            //Santa Claus
            s = new Thread(MoverSanta);
            s.Start();
            //Pinguino
            o = new Thread(MoverPinguino);
            o.Start();
            //Arbol
            a = new Thread(arbol);
            a.Start();
            //Estrella
            e = new Thread(Estrellas);
            e.Start();
            //Regalo
            r = new Thread(regalos);
            r.Start();
            r = new Thread(regalos1);
            r.Start();
            r = new Thread(regalos2);
            r.Start();
            Musi();
            CheckForIllegalCrossThreadCalls = false;
        }

        public void FelizNavidad()
        {
            while (true)
            {
                pictureBox1.Image = Practica1Postales.Properties.Resources.FelizNavidad3;
                pictureBox1.Image = Practica1Postales.Properties.Resources.FelizNavidad;
                Thread.Sleep(1000);
                
                pictureBox1.Image = Practica1Postales.Properties.Resources.FelizNavidad;
                pictureBox1.Image = Practica1Postales.Properties.Resources.FelizNavidad1;
                Thread.Sleep(1000);

                pictureBox1.Image = Practica1Postales.Properties.Resources.FelizNavidad1;
                pictureBox1.Image = Practica1Postales.Properties.Resources.FelizNavidad2;
                Thread.Sleep(1000);

                pictureBox1.Image = Practica1Postales.Properties.Resources.FelizNavidad2;
                pictureBox1.Image = Practica1Postales.Properties.Resources.FelizNavidad3;
                Thread.Sleep(1000);
            }
        }
        public void arbol()
        {
            while (true)
            {
                pictureBox5.Image = Practica1Postales.Properties.Resources.arbol;
                pictureBox5.Image = Practica1Postales.Properties.Resources.arbol1;
                Thread.Sleep(300);

                pictureBox5.Image = Practica1Postales.Properties.Resources.arbol1;
                pictureBox5.Image = Practica1Postales.Properties.Resources.arbol2;
                Thread.Sleep(300);

                pictureBox5.Image = Practica1Postales.Properties.Resources.arbol2;
                pictureBox5.Image = Practica1Postales.Properties.Resources.arbol;
                Thread.Sleep(300);
            }
        }

        public void Estrellas()
        {
            while (true)
            {
                pictureBox6.Image = Practica1Postales.Properties.Resources.Estrella2;
                pictureBox6.Image = Practica1Postales.Properties.Resources.Estrella3;
                Thread.Sleep(300);

                pictureBox6.Image = Practica1Postales.Properties.Resources.Estrella3;
                pictureBox6.Image = Practica1Postales.Properties.Resources.Estrella4;
                Thread.Sleep(300);

                pictureBox6.Image = Practica1Postales.Properties.Resources.Estrella4;
                pictureBox6.Image = Practica1Postales.Properties.Resources.Estrella5;
                Thread.Sleep(300);

                pictureBox6.Image = Practica1Postales.Properties.Resources.Estrella5;
                pictureBox6.Image = Practica1Postales.Properties.Resources.Estrella6;
                Thread.Sleep(300);

                pictureBox6.Image = Practica1Postales.Properties.Resources.Estrella6;
                pictureBox6.Image = Practica1Postales.Properties.Resources.Estrella2;
                Thread.Sleep(300);
            }
        }
        public void regalos()
        {
            while (true)
            {
                pictureBox7.Image = Practica1Postales.Properties.Resources.Regalo2;
                pictureBox7.Image = Practica1Postales.Properties.Resources.Regalo3;
                Thread.Sleep(300);

                pictureBox7.Image = Practica1Postales.Properties.Resources.Regalo3;
                pictureBox7.Image = Practica1Postales.Properties.Resources.Regalo4;
                Thread.Sleep(300);

                pictureBox7.Image = Practica1Postales.Properties.Resources.Regalo4 ;
                pictureBox7.Image = Practica1Postales.Properties.Resources.Regalo5;
                Thread.Sleep(300);

                pictureBox7.Image = Practica1Postales.Properties.Resources.Regalo5;
                pictureBox7.Image = Practica1Postales.Properties.Resources.Regalo6;
                Thread.Sleep(300);

                pictureBox7.Image = Practica1Postales.Properties.Resources.Regalo6;
                pictureBox7.Image = Practica1Postales.Properties.Resources.Regalo2;
                Thread.Sleep(300);
            }
        }
        public void regalos1()
        {
            while (true)
            {
                //9
                pictureBox9.Image = Practica1Postales.Properties.Resources.Regalo3;
                pictureBox9.Image = Practica1Postales.Properties.Resources.Regalo4;
                Thread.Sleep(300);

                pictureBox9.Image = Practica1Postales.Properties.Resources.Regalo4;
                pictureBox9.Image = Practica1Postales.Properties.Resources.Regalo5;
                Thread.Sleep(300);

                pictureBox9.Image = Practica1Postales.Properties.Resources.Regalo5;
                pictureBox9.Image = Practica1Postales.Properties.Resources.Regalo6;
                Thread.Sleep(300);

                pictureBox9.Image = Practica1Postales.Properties.Resources.Regalo6;
                pictureBox9.Image = Practica1Postales.Properties.Resources.Regalo2;
                Thread.Sleep(300);

                pictureBox9.Image = Practica1Postales.Properties.Resources.Regalo2;
                pictureBox9.Image = Practica1Postales.Properties.Resources.Regalo3;
                Thread.Sleep(300);
            }
        }
        public void regalos2()
        {
            while (true)
            {
                //8
                pictureBox8.Image = Practica1Postales.Properties.Resources.Regalo4;
                pictureBox8.Image = Practica1Postales.Properties.Resources.Regalo5;
                Thread.Sleep(300);

                pictureBox8.Image = Practica1Postales.Properties.Resources.Regalo5;
                pictureBox8.Image = Practica1Postales.Properties.Resources.Regalo6;
                Thread.Sleep(300);

                pictureBox8.Image = Practica1Postales.Properties.Resources.Regalo6;
                pictureBox8.Image = Practica1Postales.Properties.Resources.Regalo2;
                Thread.Sleep(300);

                pictureBox8.Image = Practica1Postales.Properties.Resources.Regalo2;
                pictureBox8.Image = Practica1Postales.Properties.Resources.Regalo3;
                Thread.Sleep(300);

                pictureBox8.Image = Practica1Postales.Properties.Resources.Regalo3;
                pictureBox8.Image = Practica1Postales.Properties.Resources.Regalo4;
                Thread.Sleep(300);


            }
        }

        public void MoverSanta()
        {
            //for (int a = 0; a > 100; a++)
            //{
            //    for (int i = 0; i <= 100; i++)
            //    {
            //        pictureBox2.Left += Con;
            //        Thread.Sleep(100);
            //    }
            //}

            while (o != null)
            {
                for (int i = 0; i < 150; i++)
                {
                    Thread.Sleep(30);
                    pictureBox2.Left += Cont;

                }
                
                for (int b = 0; b < 150; b++)
                {
                    Thread.Sleep(10);
                    pictureBox2.Left -= Cont;
                    pictureBox2.Visible = false;
                    
                }
                pictureBox2.Visible = true;
                //for (int i12 = 0; i12 < 100; i12++)
                //{
                //    Thread.Sleep(5);
                //    pictureBox3.Left -= Cont;
                //}
            }
        }
        
        public void MoverPinguino()
        {
            while (true)
            {
                for (int i10 = 0; i10 < 30; i10++)
                {
                    Thread.Sleep(70);
                    pictureBox4.Left += Cont;

                }

                for (int i11 = 0; i11 < 30; i11++)
                {
                    Thread.Sleep(70);
                    pictureBox4.Left -= Cont;
                    //pictureBox4.Visible = false;

                }
                pictureBox4.Visible = true;
            }
        }
        private void PostalNavideña_Load(object sender, EventArgs e)
        {
            //CheckForIllegalCrossThreadCalls = false;
            
        }

        private void PostalNavideña_FormClosing(object sender, FormClosingEventArgs e)
        {
            mus.controls.stop();
        }

        private void PostalNavideña_Load_1(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            Musi();
        }
    }
}
