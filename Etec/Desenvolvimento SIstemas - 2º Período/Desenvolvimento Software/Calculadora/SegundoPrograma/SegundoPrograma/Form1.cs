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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            try
            {
                lblResultado.Text = (int.Parse(txtN1.Text) + int.Parse(txtN2.Text)).ToString();
            }
            catch {
                lblResultado.Text = "Informe um valor!!";
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtN1.Text = "";
            txtN2.Text = "";
            lblResultado.Text = "0";
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
