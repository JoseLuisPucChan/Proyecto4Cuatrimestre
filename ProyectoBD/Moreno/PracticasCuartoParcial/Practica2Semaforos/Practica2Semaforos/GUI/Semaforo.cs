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
    public partial class Semaforo : Form
    {
        Thread Sema1;
        public Semaforo()
        {
            InitializeComponent();
            
            
            label1.Text = "Detenerse Semaforo en rojo";
        }

        private void Semaforo_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
        }

        public void semaforo1()
        {
            while (true)
            {

                //Verde
                ptbSemaforo.Image = Practica2Semaforos.Properties.Resources.SemaforoAmarillo;
                ptbSemaforo.Image = Practica2Semaforos.Properties.Resources.SemaforoRojo;
                Thread.Sleep(5000);
                label1.Text = "Avance Semaforo en verde";

                //Amarrillo
                ptbSemaforo.Image = Practica2Semaforos.Properties.Resources.SemaforoRojo;
                ptbSemaforo.Image = Practica2Semaforos.Properties.Resources.SemaforoVerde;
                Thread.Sleep(5000);
                label1.Text = "Cuidado Semaforo en amarillo";

                //Rojo
                ptbSemaforo.Image = Practica2Semaforos.Properties.Resources.SemaforoVerde;
                ptbSemaforo.Image = Practica2Semaforos.Properties.Resources.SemaforoAmarillo;
                Thread.Sleep(5000);
                label1.Text = "Detenerse Semaforo en rojo";

            }
        }

        private void btnReanudar_Click(object sender, EventArgs e)
        {
            Sema1.Resume();
        }

        private void btnDetener_Click(object sender, EventArgs e)
        {
            Sema1.Suspend();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            Sema1 = new Thread(semaforo1);
            Sema1.Start();

        }
    }
}
