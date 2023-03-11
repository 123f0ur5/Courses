using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstadosCombobox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            cboEstados.Items.Add("AC");
            cboEstados.Items.Add("AL");
            cboEstados.Items.Add("AP");
            cboEstados.Items.Add("AM");
            cboEstados.Items.Add("BA");
            cboEstados.Items.Add("CE");
            cboEstados.Items.Add("DF");
            cboEstados.Items.Add("ES");
            cboEstados.Items.Add("GO");
            cboEstados.Items.Add("MA");
            cboEstados.Items.Add("MT");
            cboEstados.Items.Add("MS");
            cboEstados.Items.Add("MG");
            cboEstados.Items.Add("PA");
            cboEstados.Items.Add("PB");
            cboEstados.Items.Add("PR");
            cboEstados.Items.Add("PE");
            cboEstados.Items.Add("PI");
            cboEstados.Items.Add("RJ");
            cboEstados.Items.Add("RN");
            cboEstados.Items.Add("RS");
            cboEstados.Items.Add("RO");
            cboEstados.Items.Add("RR");
            cboEstados.Items.Add("SC");
            cboEstados.Items.Add("SP");
            cboEstados.Items.Add("SE");
            cboEstados.Items.Add("TO");


            lblNumEstados.Text = cboEstados.Items.Count.ToString();
            lblNumEstadosNorte.Text = cboNorte.Items.Count.ToString();
            lblNumEstadosNordeste.Text = cboNordeste.Items.Count.ToString();
            lblNumEstadosCentroOeste.Text = cboCentroOeste.Items.Count.ToString();
            lblNumEstadosSudeste.Text = cboSudeste.Items.Count.ToString();
            lblNumEstadosSul.Text = cboSul.Items.Count.ToString();
        }

        private void cboEstados_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void btnMoverNorte_Click(object sender, EventArgs e)
        {
            if (cboNorte.SelectedItem != null)
            {
                string estado = cboNorte.SelectedItem.ToString();
                cboEstados.Items.Add(estado);
                cboNorte.Items.Remove(estado);

                lblNumEstados.Text = cboEstados.Items.Count.ToString();
                lblNumEstadosNorte.Text = cboNorte.Items.Count.ToString();

                cboEstados.Sorted= true;

                cboNorte.ResetText();
            }
        }

        private void btnMoverEstados_Click(object sender, EventArgs e)
        {
            string[] EstadosNorte = { "AC", "AM", "RO", "RR", "AP", "PA", "TO" };
            string[] EstadosNordeste = { "AL", "BA", "CE", "MA", "PB", "PE", "PI", "RN", "SE" };
            string[] EstadosCentroOeste = { "DF", "GO", "MT", "MS" };
            string[] EstadosSudeste = { "ES", "MG", "RJ", "SP" };
            string[] EstadosSul = { "PR", "SC", "RS" };

            if (cboEstados.SelectedItem != null)
            {
                string estado = cboEstados.SelectedItem.ToString();
                if (EstadosNorte.Contains(estado)) { 
                    cboNorte.Items.Add(estado);
                    cboEstados.Items.Remove(estado);
                }

                else if (EstadosNordeste.Contains(estado))
                {
                    cboNordeste.Items.Add(estado);
                    cboEstados.Items.Remove(estado);
                }

                else if (EstadosCentroOeste.Contains(estado))
                {
                    cboCentroOeste.Items.Add(estado);
                    cboEstados.Items.Remove(estado);
                }

                else if (EstadosSudeste.Contains(estado))
                {
                    cboSudeste.Items.Add(estado);
                    cboEstados.Items.Remove(estado);
                }

                else if (EstadosSul.Contains(estado))
                {
                    cboSul.Items.Add(estado);
                    cboEstados.Items.Remove(estado);
                }

                lblNumEstados.Text = cboEstados.Items.Count.ToString();
                lblNumEstadosNorte.Text = cboNorte.Items.Count.ToString();
                lblNumEstadosNordeste.Text = cboNordeste.Items.Count.ToString();
                lblNumEstadosCentroOeste.Text = cboCentroOeste.Items.Count.ToString();
                lblNumEstadosSudeste.Text = cboSudeste.Items.Count.ToString();
                lblNumEstadosSul.Text = cboSul.Items.Count.ToString();
            }
        }

        private void btnMoverNordeste_Click(object sender, EventArgs e)
        {
            if (cboNordeste.SelectedItem != null)
            {
                string estado = cboNordeste.SelectedItem.ToString();
                cboEstados.Items.Add(estado);
                cboNordeste.Items.Remove(estado);

                lblNumEstados.Text = cboEstados.Items.Count.ToString();
                lblNumEstadosNordeste.Text = cboNordeste.Items.Count.ToString();

                cboEstados.Sorted = true;
            }
        }

        private void btnMoverCentroOeste_Click(object sender, EventArgs e)
        {
            if (cboCentroOeste.SelectedItem != null)
            {
                string estado = cboCentroOeste.SelectedItem.ToString();
                cboEstados.Items.Add(estado);
                cboCentroOeste.Items.Remove(estado);

                lblNumEstados.Text = cboEstados.Items.Count.ToString();
                lblNumEstadosCentroOeste.Text = cboCentroOeste.Items.Count.ToString();

                cboEstados.Sorted = true;
            }
        }

        private void btnMoverSudeste_Click(object sender, EventArgs e)
        {
            if (cboSudeste.SelectedItem != null)
            {
                string estado = cboSudeste.SelectedItem.ToString();
                cboEstados.Items.Add(estado);
                cboSudeste.Items.Remove(estado);

                lblNumEstados.Text = cboEstados.Items.Count.ToString();
                lblNumEstadosSudeste.Text = cboSudeste.Items.Count.ToString();

                cboEstados.Sorted = true;
            }
        }

        private void btnMoverSul_Click(object sender, EventArgs e)
        {
            if (cboSul.SelectedItem != null)
            {
                string estado = cboSul.SelectedItem.ToString();
                cboEstados.Items.Add(estado);
                cboSul.Items.Remove(estado);

                lblNumEstados.Text = cboEstados.Items.Count.ToString();
                lblNumEstadosSul.Text = cboSul.Items.Count.ToString();

                cboEstados.Sorted = true;
            }
        }
    }
}
