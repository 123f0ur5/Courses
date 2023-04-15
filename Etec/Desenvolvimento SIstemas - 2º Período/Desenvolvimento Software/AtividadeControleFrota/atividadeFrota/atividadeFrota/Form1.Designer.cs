namespace atividadeFrota
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblKmTotal = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblNViagens = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblKMMedio = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dgvFrota = new System.Windows.Forms.DataGridView();
            this.veiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.motorista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kminicial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kmfinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.distancia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtAltKmFinal = new System.Windows.Forms.TextBox();
            this.txtAltKmInicial = new System.Windows.Forms.TextBox();
            this.btnAlternar = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.txtVeiculo = new System.Windows.Forms.TextBox();
            this.txtMotorista = new System.Windows.Forms.TextBox();
            this.txtKmInicial = new System.Windows.Forms.TextBox();
            this.txtKmFinal = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFrota)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Veículo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-3, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Motorista";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(342, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "KM Inicial:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(342, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "KM Final:";
            // 
            // lblKmTotal
            // 
            this.lblKmTotal.AutoSize = true;
            this.lblKmTotal.Location = new System.Drawing.Point(327, 587);
            this.lblKmTotal.Name = "lblKmTotal";
            this.lblKmTotal.Size = new System.Drawing.Size(13, 13);
            this.lblKmTotal.TabIndex = 4;
            this.lblKmTotal.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(409, 587);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Número de Viagens:";
            // 
            // lblNViagens
            // 
            this.lblNViagens.AutoSize = true;
            this.lblNViagens.Location = new System.Drawing.Point(518, 587);
            this.lblNViagens.Name = "lblNViagens";
            this.lblNViagens.Size = new System.Drawing.Size(13, 13);
            this.lblNViagens.TabIndex = 6;
            this.lblNViagens.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(579, 587);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "KM Médio por viagem:";
            // 
            // lblKMMedio
            // 
            this.lblKMMedio.AutoSize = true;
            this.lblKMMedio.Location = new System.Drawing.Point(692, 587);
            this.lblKMMedio.Name = "lblKMMedio";
            this.lblKMMedio.Size = new System.Drawing.Size(13, 13);
            this.lblKMMedio.TabIndex = 8;
            this.lblKMMedio.Text = "0";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(199, 587);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "KM Total Percorrido:";
            // 
            // dgvFrota
            // 
            this.dgvFrota.AllowUserToAddRows = false;
            this.dgvFrota.AllowUserToDeleteRows = false;
            this.dgvFrota.AllowUserToOrderColumns = true;
            this.dgvFrota.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFrota.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.veiculo,
            this.motorista,
            this.kminicial,
            this.kmfinal,
            this.distancia});
            this.dgvFrota.Location = new System.Drawing.Point(133, 280);
            this.dgvFrota.Name = "dgvFrota";
            this.dgvFrota.ReadOnly = true;
            this.dgvFrota.Size = new System.Drawing.Size(688, 164);
            this.dgvFrota.TabIndex = 10;
            this.dgvFrota.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFrota_CellClick);
            // 
            // veiculo
            // 
            this.veiculo.HeaderText = "Veículo";
            this.veiculo.Name = "veiculo";
            this.veiculo.ReadOnly = true;
            // 
            // motorista
            // 
            this.motorista.HeaderText = "Motorista";
            this.motorista.Name = "motorista";
            this.motorista.ReadOnly = true;
            // 
            // kminicial
            // 
            this.kminicial.HeaderText = "KMInicial";
            this.kminicial.Name = "kminicial";
            this.kminicial.ReadOnly = true;
            // 
            // kmfinal
            // 
            this.kmfinal.HeaderText = "KMFinal";
            this.kmfinal.Name = "kmfinal";
            this.kmfinal.ReadOnly = true;
            // 
            // distancia
            // 
            this.distancia.HeaderText = "Distância";
            this.distancia.Name = "distancia";
            this.distancia.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtAltKmFinal);
            this.groupBox1.Controls.Add(this.txtAltKmInicial);
            this.groupBox1.Controls.Add(this.btnAlternar);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Location = new System.Drawing.Point(133, 470);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(688, 93);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alternar Lançamento";
            // 
            // txtAltKmFinal
            // 
            this.txtAltKmFinal.Location = new System.Drawing.Point(449, 34);
            this.txtAltKmFinal.Name = "txtAltKmFinal";
            this.txtAltKmFinal.Size = new System.Drawing.Size(100, 20);
            this.txtAltKmFinal.TabIndex = 16;
            // 
            // txtAltKmInicial
            // 
            this.txtAltKmInicial.Location = new System.Drawing.Point(194, 34);
            this.txtAltKmInicial.Name = "txtAltKmInicial";
            this.txtAltKmInicial.Size = new System.Drawing.Size(100, 20);
            this.txtAltKmInicial.TabIndex = 17;
            // 
            // btnAlternar
            // 
            this.btnAlternar.Location = new System.Drawing.Point(583, 34);
            this.btnAlternar.Name = "btnAlternar";
            this.btnAlternar.Size = new System.Drawing.Size(75, 23);
            this.btnAlternar.TabIndex = 3;
            this.btnAlternar.Text = "Alternar";
            this.btnAlternar.UseVisualStyleBackColor = true;
            this.btnAlternar.Click += new System.EventHandler(this.btnAlternar_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(385, 39);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "KM Final:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(132, 39);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "KM Inicial:";
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(746, 251);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(75, 23);
            this.btnRemover.TabIndex = 4;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(643, 251);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(75, 23);
            this.btnInserir.TabIndex = 5;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // txtVeiculo
            // 
            this.txtVeiculo.Location = new System.Drawing.Point(221, 139);
            this.txtVeiculo.Name = "txtVeiculo";
            this.txtVeiculo.Size = new System.Drawing.Size(193, 20);
            this.txtVeiculo.TabIndex = 12;
            // 
            // txtMotorista
            // 
            this.txtMotorista.Location = new System.Drawing.Point(88, 74);
            this.txtMotorista.Name = "txtMotorista";
            this.txtMotorista.Size = new System.Drawing.Size(193, 20);
            this.txtMotorista.TabIndex = 13;
            // 
            // txtKmInicial
            // 
            this.txtKmInicial.Location = new System.Drawing.Point(404, 35);
            this.txtKmInicial.Name = "txtKmInicial";
            this.txtKmInicial.Size = new System.Drawing.Size(190, 20);
            this.txtKmInicial.TabIndex = 14;
            // 
            // txtKmFinal
            // 
            this.txtKmFinal.Location = new System.Drawing.Point(404, 74);
            this.txtKmFinal.Name = "txtKmFinal";
            this.txtKmFinal.Size = new System.Drawing.Size(190, 20);
            this.txtKmFinal.TabIndex = 15;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(880, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(238, 172);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 33F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label13.Location = new System.Drawing.Point(259, 28);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(362, 70);
            this.label13.TabIndex = 17;
            this.label13.Text = "Controle de Frota";
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(746, 577);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 23);
            this.btnFechar.TabIndex = 18;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtKmFinal);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtMotorista);
            this.groupBox2.Controls.Add(this.txtKmInicial);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(133, 101);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(691, 144);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 741);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtVeiculo);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvFrota);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblKMMedio);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblNViagens);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblKmTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFrota)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblKmTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblNViagens;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblKMMedio;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgvFrota;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtAltKmFinal;
        private System.Windows.Forms.TextBox txtAltKmInicial;
        private System.Windows.Forms.Button btnAlternar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.TextBox txtVeiculo;
        private System.Windows.Forms.TextBox txtMotorista;
        private System.Windows.Forms.TextBox txtKmInicial;
        private System.Windows.Forms.TextBox txtKmFinal;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnFechar;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.DataGridViewTextBoxColumn veiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn motorista;
        private System.Windows.Forms.DataGridViewTextBoxColumn kminicial;
        private System.Windows.Forms.DataGridViewTextBoxColumn kmfinal;
        private System.Windows.Forms.DataGridViewTextBoxColumn distancia;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

