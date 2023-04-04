using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicio01
{
    public partial class Form1 : Form
    {
        double valorUni = 0, valorTot = 0; 
        int cont = 1, qtdeAnt = 0;
        

        public Form1()
        {
            InitializeComponent();
            
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            txtDesc.Focus();

            if (txtDesc.Text == "" || txtQuant.Text == "" || txtValorUni.Text == "")
            {
                MessageBox.Show("Descrição ou Quantidade ou Valor Unitário", "Inclua",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                //Limpa as caixas de texto e coloca o cursor na text Nome
                txtDesc.Clear();
                txtQuant.Clear();
                txtValorUni.Focus();

            }
            else
            {
                //Variáveis para processamento do valor total
                valorUni = double.Parse(txtValorUni.Text.Replace(".", ","));
                valorTot += (valorUni * double.Parse(txtQuant.Text.Replace(".",",")));

                //Adiciona o conteúdo das caixas de texto nas colunas correspondentes
                dgvMercado.Rows.Add(txtDesc.Text, txtQuant.Text, txtValorUni.Text);

                //Limpa as caixas de texto
                txtDesc.Clear();
                txtQuant.Clear();
                txtValorUni.Clear();

                //Exibe uma mensagem ai usuário de inclusão com sucesso!
                MessageBox.Show("Venda Incluída com sucesso", "Inclusão",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                //Exibe na label o contador de linhas do GridView atualizado após a inserção
                lblItens.Text = dgvMercado.RowCount.ToString();
                lblTotal.Text = valorTot.ToString("C");


            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (dgvMercado.RowCount > 0)
            {
                
                dgvMercado.Rows.Remove(dgvMercado.CurrentRow);

                
                lblItens.Text = dgvMercado.RowCount.ToString();

                
                txtDesc.Focus();
            }

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txtAlterar.Text != "")
            {
                //Move o conteúdo da primeira célula da linha selecionada para caixa de texto.
                dgvMercado.CurrentRow.Cells[1].Value = txtAlterar.Text;
                valorTot -= (valorUni * qtdeAnt);
                valorTot += (valorUni * double.Parse(txtAlterar.Text));
                lblTotal.Text = valorTot.ToString("C");                
                txtAlterar.Clear();

                //Exibe uma mensagem ai usuário de inclusão com sucesso!
                MessageBox.Show("Quantidade Alterada com Sucesso", "Inclusão",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void btnNovaVenda_Click(object sender, EventArgs e)
        {
            
                //Remove todas as linhas do Grid
                dgvMercado.RowCount= 0;

                
                lblItens.Text = dgvMercado.RowCount.ToString();
                lblTotal.Text = dgvMercado.RowCount.ToString();

                
                cont++;
                txtVenda.Text = cont.ToString();
           
        }

        private void dgvMercado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvMercado.RowCount > 0)
            {
                
                txtAlterar.Text = dgvMercado.CurrentRow.Cells[1].Value.ToString();
                qtdeAnt = int.Parse(dgvMercado.CurrentRow.Cells[1].Value.ToString().Replace(".", ","));
                valorUni = double.Parse(dgvMercado.CurrentRow.Cells[2].Value.ToString().Replace(".",","));
            }

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            
            Application.Exit();
        }

        private void btnCancVenda_Click(object sender, EventArgs e)
        {
            {
                
                dgvMercado.RowCount = 0;

                
                lblItens.Text = dgvMercado.RowCount.ToString();
                lblTotal.Text = dgvMercado.RowCount.ToString();
                cont--;
                txtVenda.Text = cont.ToString();
            }
        }
    }
}