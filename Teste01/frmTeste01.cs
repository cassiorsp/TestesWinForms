using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teste01
{
    public partial class frmTeste01 : Form
    {
        public frmTeste01()
        {
            InitializeComponent();
            //desativa o botão calcular
            btnCalcular.Enabled = false;
            miSoma.Enabled = false;
            btnMultiplicacao.Visible = false;
        }

        private void CalcularAlgo(object sender, EventArgs e)
        {
            if (txtPrimeiroValor.TextLength > 0 && txtSegundoValor.TextLength > 0)
            {
                var pValor = long.Parse(txtPrimeiroValor.Text);
                var sValor = long.Parse(txtSegundoValor.Text);
                var rValor = pValor + sValor;

                lblResultado.Text += "\n Hora do Resultado: " +
                    DateTime.Now + " Calculo: " + pValor + "+" +
                    sValor + "= " + rValor;

                //aumenta o tamanho do form LARGURA - ALTURA
                this.ClientSize = new System.Drawing.Size(800, 400);
                //MODIFICAR TAMANHO DO BUTTON
                this.btnMultiplicacao.Size = new System.Drawing.Size(130, 40);
            }
            else
            {
                Console.Beep();
                tltMsg.ToolTipTitle = "Serio!!!";
                tltMsg.Show("Por favor não tente fazer o calculo sem ter inserido numeros meu queridos!!!! \nObrigado!!!", btnCalcular, 20, -80, 2000);
            }
        }

        private void RegrasTxtBox(object sender, KeyPressEventArgs e)
        {
            TextBox txt = (TextBox)sender;

            if (!(char.IsNumber(e.KeyChar) && txt.TextLength < 5)
                 && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;

                tltMsg.ToolTipTitle = "Atenção!!!";
                tltMsg.Show("Por favor digite apenas numeros.\nObrigado.", txt, 20, -80, 2000);
            }
        }

        private void HabilitaBotaoCalcular(object sender, EventArgs e)
        {
            if (txtPrimeiroValor.TextLength > 0 && txtSegundoValor.TextLength > 0)
            {
                btnCalcular.Enabled = true;
                miSoma.Enabled = true;
            }
            else
            {
                btnCalcular.Enabled = false;
                miSoma.Enabled = false;
            }
        }

        private void HabilitaMultiplicacao(object sender, EventArgs e)
        {
            if(miHabilitaMulti.Text == "sim")
            {
                btnMultiplicacao.Visible = true;
            }
            else
            {
                btnMultiplicacao.Visible = false;
            }
        }
    }
}
