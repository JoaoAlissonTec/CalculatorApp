using System.Globalization;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        decimal valor1 = 0, valor2 = 0;
        string operacao = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void num0_Click(object sender, EventArgs e)
        {
            txt_calculo.Text += "0";
        }
        private void num1_Click_1(object sender, EventArgs e)
        {
            txt_calculo.Text += "1";
        }

        private void num2_Click(object sender, EventArgs e)
        {
            txt_calculo.Text += "2";
        }

        private void num3_Click(object sender, EventArgs e)
        {
            txt_calculo.Text += "3";
        }

        private void num4_Click(object sender, EventArgs e)
        {
            txt_calculo.Text += "4";
        }

        private void num5_Click(object sender, EventArgs e)
        {
            txt_calculo.Text += "5";
        }

        private void num6_Click(object sender, EventArgs e)
        {
            txt_calculo.Text += "6";
        }

        private void num7_Click(object sender, EventArgs e)
        {
            txt_calculo.Text += "7";
        }

        private void num8_Click(object sender, EventArgs e)
        {
            txt_calculo.Text += "8";
        }

        private void num9_Click(object sender, EventArgs e)
        {
            txt_calculo.Text += "9";
        }

        private void ponto_Click(object sender, EventArgs e)
        {
            txt_calculo.Text += ".";
        }

        private void igual_Click(object sender, EventArgs e)
        {
            valor2 = decimal.Parse(txt_calculo.Text, CultureInfo.InvariantCulture);
            if(operacao == "soma"){
                txt_calculo.Text = Convert.ToString(valor1 + valor2);
            }else if(operacao == "sub")
            {
                txt_calculo.Text = Convert.ToString(valor1 - valor2);
            }
            else if(operacao == "mult")
            {
                txt_calculo.Text = Convert.ToString(valor1 * valor2);
            }
            else if(operacao == "div")
            {
                if(valor2 != 0)
                {
                    txt_calculo.Text = Convert.ToString(valor1 / valor2);
                }
            }
        }

        private void sub_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(txt_calculo.Text, CultureInfo.InvariantCulture);
            txt_calculo.Text = "";
            operacao = "sub";
        }

        private void mult_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(txt_calculo.Text, CultureInfo.InvariantCulture);
            txt_calculo.Text = "";
            operacao = "mult";
        }

        private void div_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(txt_calculo.Text, CultureInfo.InvariantCulture);
            txt_calculo.Text = "";
            operacao = "div";
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            operacao = "";
            txt_calculo.Text = "";
            valor1 = 0;
            valor2 = 0;
        }

        private void apaga_Click(object sender, EventArgs e)
        {
            if(txt_calculo.TextLength > 0)
            {
                txt_calculo.Text = txt_calculo.Text.Substring(0, txt_calculo.TextLength - 1);
            }
        }

        private void soma_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(txt_calculo.Text, CultureInfo.InvariantCulture);
            txt_calculo.Text = "";
            operacao = "soma";
        }
    }
}