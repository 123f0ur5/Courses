using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atividadeFrota
{
    public partial class Form1 : Form
    {
        double totalPercorrido = 0, mediaViagem = 0;
        int numeroViagens = 0;
        double kmInicialAtual, kmFinalAtual;

        private void atualizaContadores(int op, double distancia)
        {
            if (op == 1)
            {
                totalPercorrido += distancia;
                numeroViagens += 1;
            } else
            {
                totalPercorrido -= distancia;
                numeroViagens -= 1;
            }

            mediaViagem = totalPercorrido / numeroViagens;
            if (mediaViagem.Equals(double.NaN))
            {
                mediaViagem = 0;
            }

            lblNViagens.Text = numeroViagens.ToString();
            lblKmTotal.Text = totalPercorrido.ToString();
            lblKMMedio.Text = mediaViagem.ToString();
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dgvFrota_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvFrota.Rows.Count > 0) { 
                txtAltKmFinal.Text = dgvFrota.CurrentRow.Cells[3].Value.ToString();
                txtAltKmInicial.Text = dgvFrota.CurrentRow.Cells[2].Value.ToString();

                kmInicialAtual = double.Parse(dgvFrota.CurrentRow.Cells[2].Value.ToString());
                kmFinalAtual = double.Parse(dgvFrota.CurrentRow.Cells[3].Value.ToString());
            }
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            if(txtVeiculo.Text != "" && txtMotorista.Text != "" 
                && txtKmInicial.Text != "" && txtKmFinal.Text != "")
            {               
                double KMFinal = double.Parse(txtKmFinal.Text);
                double KMInicial = double.Parse(txtKmInicial.Text);
                double distancia = KMFinal - KMInicial;

                dgvFrota.Rows.Add(txtVeiculo.Text, txtMotorista.Text, txtKmInicial.Text, txtKmFinal.Text, distancia);
                
                txtVeiculo.Clear();
                txtMotorista.Clear();
                txtKmInicial.Clear();
                txtKmFinal.Clear();

                atualizaContadores(1, distancia);
            } 
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void btnAlternar_Click(object sender, EventArgs e)
        {
            
            if (txtAltKmInicial.Text != "" && txtAltKmFinal.Text != "" && dgvFrota.Rows.Count > 0)
            {
                double distancia = kmFinalAtual - kmInicialAtual;
                atualizaContadores(0, distancia);

                dgvFrota.CurrentRow.Cells[2].Value = txtAltKmInicial.Text;
                dgvFrota.CurrentRow.Cells[3].Value = txtAltKmFinal.Text;

                double novoKmIni = double.Parse(txtAltKmInicial.Text);
                double novoKmFinal = double.Parse(txtAltKmFinal.Text);

                distancia = novoKmFinal - novoKmIni;

                dgvFrota.CurrentRow.Cells[4].Value = distancia.ToString();

                atualizaContadores(1, distancia);

                txtAltKmInicial.Clear();
                txtAltKmFinal.Clear();
            }
            while (txtAltKmInicial.Text.Length > 0 && txtAltKmFinal.TextLength > 0);
            btnAlternar.Enabled = true;
        }




        private void btnRemover_Click(object sender, EventArgs e)
        {
            if(dgvFrota.Rows.Count > 0)
            {
                double distancia = double.Parse(dgvFrota.CurrentRow.Cells[4].Value.ToString());
                dgvFrota.Rows.Remove(dgvFrota.CurrentRow);

                txtVeiculo.Focus();

                atualizaContadores(0, distancia);

                txtAltKmFinal.Clear();
                txtAltKmInicial.Clear();
            }
        }
    }
}
