using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            dgvAlunos.Rows.Add(txtNome.Text, txtCurso.Text);

            txtNome.Clear();
            txtCurso.Clear();

            MessageBox.Show("Aluno Incluido com sucesso", "Inclusão", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            lblTotal.Text =dgvAlunos.RowCount.ToString();

        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            dgvAlunos.RowCount= 0;

            lblTotal.Text = dgvAlunos.RowCount.ToString();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if(dgvAlunos.RowCount > 0)
            {
                dgvAlunos.Rows.RemoveAt(dgvAlunos.CurrentCell.RowIndex);

                MessageBox.Show("Aluno Excluido com sucesso", "Exclusão",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                lblTotal.Text = dgvAlunos.RowCount.ToString();
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txtAlteracao.Text  != "" && txtAltCurso.Text != "")
            {
                dgvAlunos.CurrentRow.Cells[0].Value = txtAlteracao.Text;
                dgvAlunos.CurrentRow.Cells[1].Value = txtAltCurso.Text;



                MessageBox.Show("Aluno Alterado com sucesso", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                
                }
            }

        private void dgvAlunos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvAlunos.RowCount > 0)
            {

                    txtAlteracao.Text = dgvAlunos.CurrentRow.Cells[0].Value.ToString();
                    txtAltCurso.Text = dgvAlunos.CurrentRow.Cells[1].Value.ToString();
         
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
