using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using divisasWS.net.webservicex.www;
using divisasWS.DAO;


namespace divisasWS
{
    public partial class Form1 : Form
    {

        divisa odivisa = new divisa();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = Enum.GetValues(typeof(Currency));
            comboBox1.SelectedItem = Currency.USD;
            comboBox2.DataSource = Enum.GetValues(typeof(Currency));
            comboBox2.SelectedItem = Currency.MYR;
        }        

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            calcula();
        }

        private void calcula()
        {
            double cantidad;
            cantidad = Convert.ToDouble(txtCalcula.Text);
            Currency curFrom = (Currency)comboBox1.SelectedItem;
            Currency curTo = (Currency)comboBox2.SelectedItem;
            CurrencyConvertor oCurrencyConvertor = new CurrencyConvertor();
            double value = oCurrencyConvertor.ConversionRate(curFrom, curTo);
            txtResultado.Text = String.Format(" {1:#0.00} {2}", curFrom, (value * cantidad), curTo);
        }
    }  
}
