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
    public partial class Vinicius : Form
    {
        //variaveis globais...
        //primeiro valor 
        //segundo valor
        //resultado
        //operação
        long pValor = 0, sValor = 0, rValor = 0;
        bool pCalcular, pOperacao;
        string sinalOperacao;


        public Vinicius()
        {
            InitializeComponent();
            lbSegundoValor.Visible = false;
            rdbAdicao.Enabled = false;
            rdbSubtracao.Enabled = false;
            rdbMultiplicacao.Enabled = false;
            rdbDivisao.Enabled = false;
            cbResultado.Visible = false;
            btResultado.Enabled = false;
            lbSequencia.Visible = false;
            lbHistorico.Visible = false;
            //cbPrimeiroValor.Visible = false;
            //cbOperacao.Visible = false;
            //cbSegundoValor.Visible = false;
            //pFases.Visible = false;
         
        }

        private void txtBox(object sender, KeyPressEventArgs e)
        {
            TextBox txt = (TextBox)sender;

            if (e.KeyChar == (char)Keys.Enter)
            {
                if (pValor == 0)
                {
                    pValor = long.Parse(valores.Text);
                    valores.Text = "";
                    pCalcular = true;
                    //lbResultado.Text = pValor.ToString();
                    cbPrimeiroValor.Checked = true;
                    cbPrimeiroValor.Text = "Primeiro Valor: " + pValor;
                    pOperacao = true;
                    lbPrimeiroValor.Visible = false;
                    lbSegundoValor.Visible = true;

                }
                else
                {                    
                    sValor = long.Parse(valores.Text);
                    valores.Text = "";
                    //lbResultado.Text = sValor.ToString();
                    cbSegundoValor.Text = "Segundo Valor: " + sValor;
                    cbSegundoValor.Checked = true;

                    rdbAdicao.Enabled = true;
                    rdbSubtracao.Enabled = true;
                    rdbMultiplicacao.Enabled = true;
                    rdbDivisao.Enabled = true;
                    lbSegundoValor.Visible = false;                    

                }
                if (pOperacao == true)
                {
                    
                }
            }


            else if (!(char.IsNumber(e.KeyChar) && txt.TextLength < 5)
                 && e.KeyChar != (char)Keys.Back)

            {
                e.Handled = true;

                tltMsg.ToolTipTitle = "Error";
                tltMsg.Show("Digite apenas números.\nObrigado.", txt, 20, -80, 2000);
            }
        }

        private void HabilitaBotaoResultado(object sender, EventArgs e)
        {
            //if (pOperacao == true)
            //{
            //    rdbAdicao.Enabled = true;
            //    rdbSubtracao.Enabled = true;
            //    rdbMultiplicacao.Enabled = true;
            //    rdbDivisao.Enabled = true;

                //pFases.Visible = true;
                //cbPrimeiroValor.Checked = true;
            //}
            //else
            //{
                //rdbAdicao.Enabled = false;
                //rdbAdicao.Checked = false;
                //rdbSubtracao.Enabled = false;
                //rdbSubtracao.Checked = false;
                //rdbMultiplicacao.Enabled = false;
                //rdbMultiplicacao.Checked = false;
                //rdbDivisao.Enabled = false;
                //rdbDivisao.Checked = false;
                //pFases.Visible = false;
                //cbPrimeiroValor.Checked = false;
            //}
        }

        private void lbPrimeiroValor_Click(object sender, EventArgs e)
        {

        }

        private void calcResultado(object sender, EventArgs e)
        {
             if(rdbAdicao.Checked)
            {
                lbSequencia.Visible = true;
                rValor = pValor + sValor;
                cbResultado.Checked = true;
            }
            else if (rdbSubtracao.Checked)
            {
                rValor = pValor - sValor;
                cbResultado.Checked = true;
            }
            else if (rdbMultiplicacao.Checked)
            {
                rValor = pValor * sValor;
                cbResultado.Checked = true;
            }
            else if (rdbDivisao.Checked)
            {
                rValor = pValor / sValor;
                cbResultado.Checked = true;
            }
            cbResultado.Visible = true;
            cbResultado.Text = "Resultado: " + rValor;
            lblResultadoHist.Text += pValor + " " + sinalOperacao + " " + sValor + " = " + rValor + "\n";
            lbHistorico.Visible = true;
            lbSequencia.Visible = false;
            valores.Enabled = false;
            btResultado.Enabled = false;

            pValor = 0;
            sValor = 0;


        }

        private void checkPrimeiroValor(object sender, EventArgs e)
        {
            //if (valores.TextLength > 0)
            //{
            //    cbPrimeiroValor.Visible = true;
            //}
            //else
            //{
            //    cbPrimeiroValor.Visible = false;
            //}
        }

        private void checkOperacao(object sender, EventArgs e)
        {
       
        }

        public void HabilitaDesabilitaCheckBox(int value)
        {

        }

        private void clickCheckOperacao(object sender, EventArgs e)
        {
          
        }

        private void clickLimpa(object sender, EventArgs e)
        {
            valores.Enabled = true;
            lbPrimeiroValor.Visible = true;
            rdbAdicao.Enabled = false;
            rdbAdicao.Checked = false;
            rdbSubtracao.Enabled = false;
            rdbSubtracao.Checked = false;
            rdbMultiplicacao.Enabled = false;
            rdbMultiplicacao.Checked = false;
            rdbDivisao.Enabled = false;
            rdbDivisao.Checked = false;
            cbResultado.Visible = false;
            btResultado.Enabled = false;
            lbSequencia.Visible = false;
            cbPrimeiroValor.Checked = false;
            cbSegundoValor.Checked = false;
            cbOperacao.Checked = false;
            cbPrimeiroValor.Text = "Primeiro Valor: ";
            cbSegundoValor.Text = "Segundo Valor: ";
            cbOperacao.Text = "Operação: ";


        }

        private void pFases_Paint(object sender, PaintEventArgs e)
        {

        }

        private void calculadora_Enter(object sender, EventArgs e)
        {

        }

        private void ClickCheckChanged(object sender, EventArgs e)
        {
            if (rdbAdicao.Checked)
            {
                btResultado.Enabled = true;
                lbSequencia.Visible = true;
                cbOperacao.Text = "Operação: + ";
                cbOperacao.Checked = true;
                sinalOperacao = "+";
            }
            else if(rdbSubtracao.Checked)
            {
                btResultado.Enabled = true;
                lbSequencia.Visible = true;
                cbOperacao.Text = "Operação: - ";
                cbOperacao.Checked = true;
                sinalOperacao = "-";
            }
            else if(rdbMultiplicacao.Checked)
            {
                btResultado.Enabled = true;
                lbSequencia.Visible = true;
                cbOperacao.Text = "Operação: x ";
                cbOperacao.Checked = true;
                sinalOperacao = "x";
            }
            else if(rdbDivisao.Checked)
            {
                btResultado.Enabled = true;
                lbSequencia.Visible = true;
                cbOperacao.Text = "Operação: ÷ ";
                cbOperacao.Checked = true;
                sinalOperacao = "/";
            }
            else
            {
                cbOperacao.Checked = false;
            }
            
        }
               
        private void checkSegundoValor(object sender, EventArgs e)
        {
        
        }
    }
}
