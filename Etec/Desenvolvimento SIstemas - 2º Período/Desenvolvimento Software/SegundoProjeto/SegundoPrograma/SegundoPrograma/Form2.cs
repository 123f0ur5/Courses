using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SegundoPrograma
{
    public partial class Form2 : Form
    {

        string n1 = "";
        string n2 = "";
        char op = 'a';
        public Form2()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            lblResultado.Text += "0";
            if (op == 'a') { 
                n1 += "0";
            } else
            {
                n2 += "0";
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            lblResultado.Text += "1";
            if (op == 'a')
            {
                n1 += "1";
            }
            else
            {
                n2 += "1";
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            lblResultado.Text += "2";
            if (op == 'a')
            {
                n1 += "2";
            }
            else
            {
                n2 += "2";
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            lblResultado.Text += "3";
            if (op == 'a')
            {
                n1 += "3";
            }
            else
            {
                n2 += "3";
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            lblResultado.Text += "4";
            if (op == 'a')
            {
                n1 += "4";
            }
            else
            {
                n2 += "4";
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            lblResultado.Text += "5";
            if (op == 'a')
            {
                n1 += "5";
            }
            else
            {
                n2 += "5";
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            lblResultado.Text += "6";
            if (op == 'a')
            {
                n1 += "6";
            }
            else
            {
                n2 += "6";
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            lblResultado.Text += "7";
            if (op == 'a')
            {
                n1 += "7";
            }
            else
            {
                n2 += "7";
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            lblResultado.Text += "8";
            if (op == 'a')
            {
                n1 += "8";
            }
            else
            {
                n2 += "8";
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            lblResultado.Text += "9";
            if (op == 'a')
            {
                n1 += "9";
            }
            else
            {
                n2 += "9";
            }
        }

        private void btnMais_Click(object sender, EventArgs e)
        {
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            op = '+';
            lblResultado.Text += "+";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            if (op == '+')
            {
                lblResultado.Text = (int.Parse(n1) + int.Parse(n2)).ToString();
                n1 = lblResultado.Text;
            } else if (op == '-')
            {
                lblResultado.Text = (int.Parse(n1) - int.Parse(n2)).ToString();
                n1 = lblResultado.Text;                
            }
            else if (op == '*')
            {
                lblResultado.Text = (int.Parse(n1) * int.Parse(n2)).ToString();
                n1 = lblResultado.Text;
            }
            else if (op == '/')
            {
                lblResultado.Text = (int.Parse(n1) / int.Parse(n2)).ToString();
                n1 = lblResultado.Text;
            }

            n2 = "0";
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            op = '-';
            lblResultado.Text += "-";
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            op = '*';
            lblResultado.Text += "*";
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            op = '/';
            lblResultado.Text += "/";
        }
    }
}
