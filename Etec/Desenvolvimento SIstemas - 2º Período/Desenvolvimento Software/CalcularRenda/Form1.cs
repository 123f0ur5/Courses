using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calc_Click(object sender, EventArgs e)
        {
            double renda = double.Parse(txtRenda.Text);
            double energia = double.Parse(txtEnergia.Text);
            double agua = double.Parse(txtAgua.Text);
            double tv = double.Parse(txtTv.Text);
            double alimentacao = double.Parse(txtAlimentacao.Text);
            double outros = double.Parse(txtOutros.Text);

            double gastos = energia + agua + tv + alimentacao + outros;
            double saldo = renda - gastos;

            lblGasto.Text = gastos.ToString();
            lblSaldo.Text = saldo.ToString();
        }

        private void newCalc_Click(object sender, EventArgs e)
        {
            txtRenda.Text = "";
            txtEnergia.Text = "";
            txtAgua.Text = "";
            txtAlimentacao.Text = "";
            txtTv.Text = "";
            txtOutros.Text = "";

            lblGasto.Text = "0";
            lblSaldo.Text = "0";
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
