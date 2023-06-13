using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtividadeCalculadora
{
    public partial class Gabrielcastro : Form
    {

        double Numero1 = 0, Numero2 = 0;
        char operador;

        public Gabrielcastro()
        {
            InitializeComponent();
        }

        private void agregarNumero(object sender,EventArgs e)
        {

            var boton = ((Button)sender);

            if (txtresultado.Text == "0")
                txtresultado.Text = "";

            txtresultado.Text += boton.Text;



        }

        private void clickoperador(object sender, EventArgs e) 
        {

            var boton = ((Button)sender);
            Numero1 = Convert.ToDouble(txtresultado.Text);
            operador = Convert.ToChar(boton.Tag);

            if (operador == '²')
            {

                Numero1 = Math.Pow(Numero1, 2);
                txtresultado.Text = Numero1.ToString();
            }
            else if (operador == '√')
            {

                Numero1 = Math.Sqrt(Numero1);
                txtresultado.Text = Numero1.ToString();
            }
            else
            {

                txtresultado.Text = "0";
            }

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (txtresultado.Text.Length > 1)
            {
                txtresultado.Text = txtresultado.Text.Substring(0, txtresultado.Text.Length - 1);
            }
            else
            {
                txtresultado.Text = "0";
            }
        }

        private void btnapagartudo_Click(object sender, EventArgs e)
        {
            Numero1 = 0;
            Numero2 = 0;
            operador = '\0';
            txtresultado.Text = "0";
        }

        private void btnapagar_Click(object sender, EventArgs e)
        {
            txtresultado.Text = "0";
        }

        private void btnpunto_Click(object sender, EventArgs e)
        {
            if (!txtresultado.Text.Contains(""))
            {
                txtresultado.Text += ".";
            }
        }

        private void btnsigno_Click(object sender, EventArgs e)
        {
            Numero1 = Convert.ToDouble(txtresultado.Text);
            Numero1 *= -1;
            txtresultado.Text = Numero1.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Numero2 = Convert.ToDouble(txtresultado.Text);

            if (operador == '+')
            {

                txtresultado.Text = (Numero1 + Numero2).ToString();
                Numero1 = Convert.ToDouble(txtresultado.Text);

            }
            else if (operador == '-')
            {

                txtresultado.Text = (Numero1 + Numero2).ToString();
                Numero1 = Convert.ToDouble(txtresultado.Text);
            }
            else if (operador == 'X')
            {

                txtresultado.Text = (Numero1 * Numero2).ToString();
                Numero1 = Convert.ToDouble(txtresultado.Text);
            }
            else if (operador == '/')
            {

                txtresultado.Text = (Numero1 / Numero2).ToString();
                Numero1 = Convert.ToDouble(txtresultado.Text);
            }



        }


    }
}
