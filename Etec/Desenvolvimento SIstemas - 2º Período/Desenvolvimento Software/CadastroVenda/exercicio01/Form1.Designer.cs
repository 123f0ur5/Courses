namespace exercicio01
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblVenda = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblQuant = new System.Windows.Forms.Label();
            this.lblValorUni = new System.Windows.Forms.Label();
            this.txtVenda = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.txtQuant = new System.Windows.Forms.TextBox();
            this.txtValorUni = new System.Windows.Forms.TextBox();
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.dgvMercado = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAlterar = new System.Windows.Forms.TextBox();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnCancVenda = new System.Windows.Forms.Button();
            this.btnNovaVenda = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblItens = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMercado)).BeginInit();
            this.SuspendLayout();
            // 
            // lblVenda
            // 
            this.lblVenda.AutoSize = true;
            this.lblVenda.Location = new System.Drawing.Point(7, 29);
            this.lblVenda.Name = "lblVenda";
            this.lblVenda.Size = new System.Drawing.Size(41, 13);
            this.lblVenda.TabIndex = 0;
            this.lblVenda.Text = "Venda:";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(7, 55);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(58, 13);
            this.lblDesc.TabIndex = 1;
            this.lblDesc.Text = "Descrição:";
            // 
            // lblQuant
            // 
            this.lblQuant.AutoSize = true;
            this.lblQuant.Location = new System.Drawing.Point(7, 86);
            this.lblQuant.Name = "lblQuant";
            this.lblQuant.Size = new System.Drawing.Size(65, 13);
            this.lblQuant.TabIndex = 2;
            this.lblQuant.Text = "Quantidade:";
            // 
            // lblValorUni
            // 
            this.lblValorUni.AutoSize = true;
            this.lblValorUni.Location = new System.Drawing.Point(7, 114);
            this.lblValorUni.Name = "lblValorUni";
            this.lblValorUni.Size = new System.Drawing.Size(73, 13);
            this.lblValorUni.TabIndex = 3;
            this.lblValorUni.Text = "Valor Unitário:";
            // 
            // txtVenda
            // 
            this.txtVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVenda.ForeColor = System.Drawing.Color.Maroon;
            this.txtVenda.Location = new System.Drawing.Point(80, 26);
            this.txtVenda.Name = "txtVenda";
            this.txtVenda.ReadOnly = true;
            this.txtVenda.Size = new System.Drawing.Size(33, 20);
            this.txtVenda.TabIndex = 4;
            this.txtVenda.Text = "1";
            this.txtVenda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(80, 52);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(485, 20);
            this.txtDesc.TabIndex = 5;
            // 
            // txtQuant
            // 
            this.txtQuant.Location = new System.Drawing.Point(80, 83);
            this.txtQuant.Name = "txtQuant";
            this.txtQuant.Size = new System.Drawing.Size(68, 20);
            this.txtQuant.TabIndex = 6;
            // 
            // txtValorUni
            // 
            this.txtValorUni.Location = new System.Drawing.Point(80, 111);
            this.txtValorUni.Name = "txtValorUni";
            this.txtValorUni.Size = new System.Drawing.Size(91, 20);
            this.txtValorUni.TabIndex = 7;
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(361, 86);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(94, 45);
            this.btnInserir.TabIndex = 8;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(471, 86);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(94, 45);
            this.btnRemover.TabIndex = 9;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // dgvMercado
            // 
            this.dgvMercado.AllowUserToAddRows = false;
            this.dgvMercado.AllowUserToDeleteRows = false;
            this.dgvMercado.AllowUserToOrderColumns = true;
            this.dgvMercado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMercado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvMercado.Location = new System.Drawing.Point(10, 150);
            this.dgvMercado.Name = "dgvMercado";
            this.dgvMercado.ReadOnly = true;
            this.dgvMercado.Size = new System.Drawing.Size(555, 150);
            this.dgvMercado.TabIndex = 10;
            this.dgvMercado.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMercado_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Descrição";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Quant.";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "V.Unitário";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 318);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Quantidade de Item Selecionado:";
            // 
            // txtAlterar
            // 
            this.txtAlterar.Location = new System.Drawing.Point(178, 315);
            this.txtAlterar.Name = "txtAlterar";
            this.txtAlterar.Size = new System.Drawing.Size(277, 20);
            this.txtAlterar.TabIndex = 12;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(471, 313);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(94, 23);
            this.btnAlterar.TabIndex = 13;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnCancVenda
            // 
            this.btnCancVenda.Location = new System.Drawing.Point(471, 348);
            this.btnCancVenda.Name = "btnCancVenda";
            this.btnCancVenda.Size = new System.Drawing.Size(94, 23);
            this.btnCancVenda.TabIndex = 14;
            this.btnCancVenda.Text = "Canc. Venda";
            this.btnCancVenda.UseVisualStyleBackColor = true;
            this.btnCancVenda.Click += new System.EventHandler(this.btnCancVenda_Click);
            // 
            // btnNovaVenda
            // 
            this.btnNovaVenda.Location = new System.Drawing.Point(471, 383);
            this.btnNovaVenda.Name = "btnNovaVenda";
            this.btnNovaVenda.Size = new System.Drawing.Size(94, 23);
            this.btnNovaVenda.TabIndex = 15;
            this.btnNovaVenda.Text = "Nova Venda";
            this.btnNovaVenda.UseVisualStyleBackColor = true;
            this.btnNovaVenda.Click += new System.EventHandler(this.btnNovaVenda_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(471, 415);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(94, 23);
            this.btnFechar.TabIndex = 16;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(137, 351);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Total:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(92, 386);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Itens na Grade:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.Blue;
            this.lblTotal.Location = new System.Drawing.Point(241, 348);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(58, 16);
            this.lblTotal.TabIndex = 19;
            this.lblTotal.Text = "R$ 0,00";
            // 
            // lblItens
            // 
            this.lblItens.AutoSize = true;
            this.lblItens.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItens.ForeColor = System.Drawing.Color.Blue;
            this.lblItens.Location = new System.Drawing.Point(257, 383);
            this.lblItens.Name = "lblItens";
            this.lblItens.Size = new System.Drawing.Size(15, 16);
            this.lblItens.TabIndex = 20;
            this.lblItens.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(607, 450);
            this.Controls.Add(this.lblItens);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnNovaVenda);
            this.Controls.Add(this.btnCancVenda);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.txtAlterar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvMercado);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.txtValorUni);
            this.Controls.Add(this.txtQuant);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.txtVenda);
            this.Controls.Add(this.lblValorUni);
            this.Controls.Add(this.lblQuant);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.lblVenda);
            this.Name = "Form1";
            this.Text = "TecnoMarket";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMercado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVenda;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblQuant;
        private System.Windows.Forms.Label lblValorUni;
        private System.Windows.Forms.TextBox txtVenda;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.TextBox txtQuant;
        private System.Windows.Forms.TextBox txtValorUni;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.DataGridView dgvMercado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAlterar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnCancVenda;
        private System.Windows.Forms.Button btnNovaVenda;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblItens;
    }
}

