using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estados_Brasil
{
    
    public partial class Form1 : Form
    {

        // restante do código
        void exibeTotal(Label lb, ComboBox cb)
        {
            lb.Text = cb.Items.Count.ToString();
            lblTodosEstados.Text = (cboEstados.Items.Count - 1).ToString();
        }

        void mudaEstados(string nome, ComboBox cb)
        {
            cb.Items.Add(nome);
            cboEstados.Items.Remove(nome);
            cb.Sorted = true;
        }

        void voltaEstados(string nome, ComboBox cb)
        {
            cboEstados.Items.Add(nome);
            cb.Items.Remove(nome);
            cb.ResetText();
            cboEstados.Sorted = true;
        }

        void rodaClick(Label lbl, ComboBox cb)
        {
            if (cb.SelectedIndex != -1)
            {
                string estado = cb.SelectedItem.ToString();

                voltaEstados(estado, cb);

                // Incrementa a contagem da região Sul
                exibeTotal(lbl, cb);
            }
            else
            {
                MessageBox.Show("Selecione um estado");
            }
        }

        string[] Norte = { "AC", "AM", "AP", "PA", "RO", "RR", "TO"};
        string[] Nordeste = { "MA", "CE", "BA", "PI", "PE", "RN", "PB", "AL", "SE" };
        string[] CentroOeste = { "MT", "GO", "MS" };
        string[] Sudeste = { "MG", "ES", "SP", "RJ" };
        string[] Sul = { "PR", "SC", "RS" };

        public Form1()
        {
            InitializeComponent();
            lblTodosEstados.Text = (cboEstados.Items.Count - 1).ToString();
        }
  
        private void btnEstados_Click_1(object sender, EventArgs e)
        {
            // Verifica se algum estado foi selecionado na cboEstados
            if (cboEstados.SelectedIndex != -1)
            {
                // Armazena o estado selecionado
                string estado = cboEstados.SelectedItem.ToString();

                // Verifica se o estado pertence à região Norte
                if (Norte.Contains(estado))
                {
                    mudaEstados(estado, cboNorte);
                    exibeTotal(lblNorte, cboNorte);
                    
                }

                // Verifica se o estado pertence à região Nordeste
                else if (Nordeste.Contains(estado))
                {
                    mudaEstados(estado, cboNordeste);
                    exibeTotal(lblNordeste, cboNordeste);
                }

                // Verifica se o estado pertence à região Centro-Oeste
                else if (CentroOeste.Contains(estado))
                {
                    mudaEstados(estado, cboCentroOeste);
                    exibeTotal(lblCentroOeste, cboCentroOeste);
                }

                // Verifica se o estado pertence à região Sul
                else if (Sul.Contains(estado))
                {
                    mudaEstados(estado, cboSul);
                    exibeTotal(lblSul, cboSul);
                }

                // Verifica se o estado pertence à região Sudeste
                else if (Sudeste.Contains(estado))
                {
                    mudaEstados(estado, cboSudeste);
                    exibeTotal(lblSudeste, cboSudeste);
                }

            }
            else
            {
                MessageBox.Show("Selecione um estado");
            }
        } 

    private void btnNorte_Click_1(object sender, EventArgs e)
        {
            rodaClick(lblNorte, cboNorte);
        }

        private void btnNordeste_Click(object sender, EventArgs e)
        {
            rodaClick(lblNordeste, cboNordeste);
        }

        private void btnCentroOeste_Click(object sender, EventArgs e)
        {
            rodaClick(lblCentroOeste, cboCentroOeste);
        }

        private void btnSudeste_Click(object sender, EventArgs e)
        {
            rodaClick(lblSudeste, cboSudeste);
        }

        private void btnSul_Click(object sender, EventArgs e)
        {
            rodaClick(lblSul, cboSul);
        }
    }
}




