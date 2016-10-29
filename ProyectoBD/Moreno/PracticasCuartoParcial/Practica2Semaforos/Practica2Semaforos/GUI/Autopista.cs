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
namespace Practica2Semaforos.GUI
{
    public partial class Autopista : Form
    {
        Thread p;
        int i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12;
        const int desp = 10;
        public Autopista()
        {
            InitializeComponent(); 
        }
        private void Visibles()
        {
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            pictureBox4.Visible = true;
            pictureBox5.Visible = true;
            pictureBox6.Visible = true;
            pictureBox7.Visible = true;
            pictureBox8.Visible = true;
            pictureBox9.Visible = true;
            pictureBox10.Visible = true;
            pictureBox11.Visible = true;
            pictureBox12.Visible = true;
        }

        private void Iniciar()
        {
            while (p != null)
            {

                Visibles();
                //Primer semaforo
                pictureBox1.Visible = true;
                if (pictureBox1.Visible)
                {
                    pictureBox19.Visible = true;
                    pictureBox3.Visible = false;
                    for (i1 = 0; i1 < 100; i1++)
                    {
                        Thread.Sleep(30);
                        pictureBox19.Top -= desp;
                    }

                    pictureBox1.Visible = false;
                }
                pictureBox19.Visible = false;
                pictureBox2.Visible = true;
                if (pictureBox2.Visible)
                {
                    pictureBox20.Visible = true;
                    for (i2 = 0; i2 < 100; i2++)
                    {
                        Thread.Sleep(10);
                        pictureBox19.Top += desp;
                        pictureBox20.Top -= desp;
                    }
                    pictureBox2.Visible = false;
                }
                pictureBox3.Visible = true;
                if (pictureBox3.Visible)
                {
                    pictureBox20.Visible = false;
                    for (i3 = 0; i3 < 100; i3++)
                    {
                        Thread.Sleep(5);
                        pictureBox20.Top += desp;
                    }
                }
                //Segundo semaforo
                if (pictureBox4.Visible)
                {
                    pictureBox21.Visible = true;
                    pictureBox6.Visible = false;
                    for (i4 = 0; i4 < 100; i4++)
                    {
                        Thread.Sleep(30);
                        pictureBox21.Top += desp;
                    }
                    pictureBox4.Visible = false;
                }
                pictureBox21.Visible = false;
                pictureBox5.Visible = true;
                if (pictureBox5.Visible)
                {
                    pictureBox22.Visible = true;
                    for (i5 = 0; i5 < 100; i5++)
                    {
                        Thread.Sleep(10);
                        pictureBox22.Top += desp;
                        pictureBox21.Top -= desp;
                    }
                    pictureBox5.Visible = false;
                }
                pictureBox22.Visible = false;
                pictureBox6.Visible = true;
                if (pictureBox6.Visible)
                {
                    for (i6 = 0; i6 < 100; i6++)
                    {
                        pictureBox22.Top -= desp;
                        Thread.Sleep(5);
                    }
                }
                //Tercer semaforo
                if (pictureBox7.Visible)
                {
                    pictureBox14.Visible = true;
                    pictureBox9.Visible = false;
                    for (i7 = 0; i7 < 100; i7++)
                    {
                        Thread.Sleep(30);
                        pictureBox14.Left -= desp;
                    }
                    pictureBox7.Visible = false;
                }
                pictureBox14.Visible = false;
                pictureBox8.Visible = true;
                if (pictureBox8.Visible)
                {
                    pictureBox13.Visible = true;
                    for (i8 = 0; i8 < 100; i8++)
                    {
                        pictureBox13.Left -= desp;
                        pictureBox14.Left += desp;
                        Thread.Sleep(10);
                    }
                    pictureBox8.Visible = false;
                }
                pictureBox13.Visible = false;
                pictureBox9.Visible = true;
                if (pictureBox9.Visible)
                {
                    for (i9 = 0; i9 < 100; i9++)
                    {
                        Thread.Sleep(5);
                        pictureBox13.Left += desp;
                    }
                }
                //Cuarto semaforo
                if (pictureBox10.Visible)
                {
                    pictureBox17.Visible = true;
                    pictureBox12.Visible = false;
                    for (i10 = 0; i10 < 100; i10++)
                    {
                        pictureBox17.Left += desp;
                        Thread.Sleep(30);
                    }
                    pictureBox10.Visible = false;
                }
                pictureBox17.Visible = false;
                pictureBox11.Visible = true;
                if (pictureBox11.Visible)
                {
                    pictureBox18.Visible = true;
                    for (i11 = 0; i11 < 100; i11++)
                    {
                        Thread.Sleep(10);
                        pictureBox17.Left -= desp;
                        pictureBox18.Left += desp;
                    }
                    pictureBox11.Visible = false;
                }
                pictureBox18.Visible = false;
                pictureBox12.Visible = true;
                if (pictureBox12.Visible)
                {
                    for (i12 = 0; i12 < 100; i12++)
                    {
                        Thread.Sleep(5);
                        pictureBox18.Left -= desp;
                    }
                    pictureBox12.Visible = false;
                }
            }

        }

        private void Autopista_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            p = new Thread(Iniciar);
            p.Start();
        }

    }
}
