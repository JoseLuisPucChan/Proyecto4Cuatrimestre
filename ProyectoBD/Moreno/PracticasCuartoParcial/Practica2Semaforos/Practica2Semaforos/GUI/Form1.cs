using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Practica2Semaforos.GUI;

namespace Practica2Semaforos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Autopista pi = new Autopista();
            pi.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Semaforo se = new Semaforo();
            se.Show();
        }
    }
}
