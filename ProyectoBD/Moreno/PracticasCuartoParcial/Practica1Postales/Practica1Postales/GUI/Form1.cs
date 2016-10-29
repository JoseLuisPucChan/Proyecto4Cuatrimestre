using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Practica1Postales.GUI;

namespace Practica1Postales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PostalNavideña pon = new PostalNavideña();
            pon.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PostalCampo cam = new PostalCampo();
            cam.Show();
        }
    }
}
