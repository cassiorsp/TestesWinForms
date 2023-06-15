using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtividadeCalculadora
{
    public partial class Form2 : Form
    {
        decimal valor1 = 0, valor2 = 0;
        string operacao = "";

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "9";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "1";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "2";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "3";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "4";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "5";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "6";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "7";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "8";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            txtResultado.Text = ".";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            valor2 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);

            if (operacao == "SOMA")
            {
                txtResultado.Text = (valor1 + valor2).ToString();

            }
        }
    }


}

