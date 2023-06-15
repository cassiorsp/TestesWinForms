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
    public partial class carlosAkira : Form
    {
        private decimal valueFist = 0.0m;
        private decimal valueSecond = 0.0m;
        private decimal result = 0.0m;
        private string operators = "+";
        public carlosAkira()
        {
            InitializeComponent();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            switch (operators)
            {
                case "-":
                    valueSecond = decimal.Parse(TxtResp.Text);
                    result = valueFist - valueSecond;
                    TxtResp.Text = result.ToString();
                    break;

                case "+":
                    valueSecond = decimal.Parse(TxtResp.Text);
                    result = valueFist + valueSecond;
                    TxtResp.Text = result.ToString();
                    break;

                case "/":
                    valueSecond = decimal.Parse(TxtResp.Text);
                    result = valueFist / valueSecond;
                    TxtResp.Text = result.ToString();
                    break;

                case "*":
                    valueSecond = decimal.Parse(TxtResp.Text);
                    result = valueFist * valueSecond;
                    TxtResp.Text = result.ToString();
                    break;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            valueFist = decimal.Parse(TxtResp.Text);
            TxtResp.Clear();
            operators = "/";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            valueFist = decimal.Parse(TxtResp.Text);
            TxtResp.Clear();
            operators = "*";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            valueFist = decimal.Parse(TxtResp.Text);
            TxtResp.Clear();
            operators = "-";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            valueFist = decimal.Parse(TxtResp.Text);
            TxtResp.Clear();
            operators = "+";
        }

        private void BTN0_Click(object sender, EventArgs e)
        {
            if (TxtResp.Text == "0")
            {
                TxtResp.Text = "0";
            }
            else
            {
                TxtResp.Text += "0";
            }
        }

        private void BTN9_Click(object sender, EventArgs e)
        {
            if (TxtResp.Text == "0")
            {
                TxtResp.Text = "9";
            }
            else
            {
                TxtResp.Text += "9";
            }
        }

        private void BTN8_Click(object sender, EventArgs e)
        {
            if (TxtResp.Text == "0")
            {
                TxtResp.Text = "8";
            }
            else
            {
                TxtResp.Text += "8";
            }
        }

        private void BTN7_Click(object sender, EventArgs e)
        {
            if (TxtResp.Text == "0")
            {
                TxtResp.Text = "7";
            }
            else
            {
                TxtResp.Text += "7";
            }
        }

        private void BTN6_Click(object sender, EventArgs e)
        {
            if (TxtResp.Text == "0")
            {
                TxtResp.Text = "6";
            }
            else
            {
                TxtResp.Text += "6";
            }
        }

        private void BTN5_Click(object sender, EventArgs e)
        {
            if (TxtResp.Text == "0")
            {
                TxtResp.Text = "5";
            }
            else
            {
                TxtResp.Text += "5";
            }
        }

        private void BTN4_Click(object sender, EventArgs e)
        {
            if (TxtResp.Text == "0")
            {
                TxtResp.Text = "4";
            }
            else
            {
                TxtResp.Text += "4";
            }
        }

        private void BTN3_Click(object sender, EventArgs e)
        {
            if (TxtResp.Text == "0")
            {
                TxtResp.Text = "3";
            }
            else
            {
                TxtResp.Text += "3";
            }
        }

        private void BTN2_Click(object sender, EventArgs e)
        {
            if (TxtResp.Text == "0")
            {
                TxtResp.Text = "2";
            }
            else
            {
                TxtResp.Text += "2";
            }
        }

        private void BTN1_Click(object sender, EventArgs e)
        {
            if (TxtResp.Text == "0")
            {
                TxtResp.Text = "1";
            }
            else
            {
                TxtResp.Text += "1";
            }
        }

        private void TxtResp_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            TxtResp.Clear();
        }
    }
}
