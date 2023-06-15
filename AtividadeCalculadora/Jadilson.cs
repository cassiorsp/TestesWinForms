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
    public partial class Jadilson : Form
    {
        double V1, V2, R;
        string Operacao, Sinal;

        public Jadilson()
        {
            InitializeComponent();
            btnAdicao.Enabled = false;
            btnDivisao.Enabled = false;
            btnMultiplicacao.Enabled = false;
            btnSubtracao.Enabled = false;
            btnResultado.Enabled = false;
            btnLimpar.Enabled = false;
            btnHist.Enabled = false;
            panel1.Visible = false;
        }

        private void CalcularAdicao(object sender, EventArgs e)
        {
            V1 = double.Parse(txtTela.Text);
            Operacao = "MAIS";
            txtTela.Text = "";
            //lblHist.Text = V1 + " + ";
        }

        private void CalcularMulti(object sender, EventArgs e)
        {
            V1 = double.Parse(txtTela.Text);
            Operacao = "VEZES";
            txtTela.Text = "";
            //lblHist.Text = V1 + " * ";
        }

        private void CalcularDivi(object sender, EventArgs e)
        {
            V1 = double.Parse(txtTela.Text);
            Operacao = "DIVIDIR";
            txtTela.Text = "";
            //blHist.Text = V1 + " / ";
        }

        private void CalcularSub(object sender, EventArgs e)
        {
            V1 = double.Parse(txtTela.Text);
            Operacao = "MENOS";
            txtTela.Text = "";
            //lblHist.Text = V1 + " - ";
        }

        private void Calcular(object sender, EventArgs e)
        {
            V2 = double.Parse(txtTela.Text);
            if (Operacao == "MAIS")
            {
                txtTela.Text = Convert.ToString (R = V1 + V2);
                //lblHist.Text = V1 + " + " + V2 + " = " + R;
                Sinal = " + ";

            }
            if (Operacao == "MENOS")
            {
                txtTela.Text = Convert.ToString (V1 - V2);
                //lblHist.Text = V1 + " - " + V2 + " = " + R;
                Sinal = " - ";

            }
            if (Operacao == "VEZES")
            {
                txtTela.Text = Convert.ToString (V1 * V2);
                //lblHist.Text = V1 + " * " + V2 + " = " + R;
                Sinal = " * ";

            }
            if (Operacao == "DIVIDIR")
            {
                txtTela.Text = Convert.ToString (V1 / V2);
                //lblHist.Text = V1 + " / " + V2 + " = " + R;
                Sinal = " / ";

            }
            lblHist.Text += V1 + Sinal + V2 + " = " + R + "\n";
            btnHist.Enabled = true;
        }

        private void LimparTudo(object sender, EventArgs e)
        {
            V1 = 0;
            V2 = 0;
            txtTela.Text = "";
        }

        private void Jadilson_Load(object sender, EventArgs e)
        {

        }

        private void RegrasTextBox(object sender, KeyPressEventArgs e)
        {
            TextBox txt = (TextBox)sender;

            if (!(char.IsNumber(e.KeyChar) && txtTela.TextLength < 5) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;

                tltMsg.ToolTipTitle = "Atenção!!!";
                tltMsg.Show("Por favor, digite apenas números. \nObrigado", txt, 0, -52, 2000);
            }
        }

        private void HabilitaBotoes(object sender, EventArgs e)
        {
            if (txtTela.TextLength > 0)
            {
                btnAdicao.Enabled = true;
                btnDivisao.Enabled = true;
                btnMultiplicacao.Enabled = true;
                btnSubtracao.Enabled = true;
                btnResultado.Enabled = true;
                btnLimpar.Enabled = true;
            }
            else
            {
                btnAdicao.Enabled = false;
                btnDivisao.Enabled = false;
                btnMultiplicacao.Enabled = false;
                btnSubtracao.Enabled = false;
                btnResultado.Enabled = false;
                btnLimpar.Enabled = false;
            }
        }

        private void btnHist_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }
    }
}
