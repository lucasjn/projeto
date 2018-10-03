namespace OdontoSIS.Janelas
{
    partial class NovoLote
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SalvarBTN = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RemoverBTN = new System.Windows.Forms.Button();
            this.AdicionarBTN = new System.Windows.Forms.Button();
            this.NovoLoteDGV = new System.Windows.Forms.DataGridView();
            this.DataValidadeDT = new System.Windows.Forms.DateTimePicker();
            this.DataRecebimentoDTP = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CodigoTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FornecedorTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.NumeroLoteLB = new System.Windows.Forms.Label();
            this.NLoteLB = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NovoLoteDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // SalvarBTN
            // 
            this.SalvarBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalvarBTN.Location = new System.Drawing.Point(553, 429);
            this.SalvarBTN.Margin = new System.Windows.Forms.Padding(2);
            this.SalvarBTN.Name = "SalvarBTN";
            this.SalvarBTN.Size = new System.Drawing.Size(86, 28);
            this.SalvarBTN.TabIndex = 49;
            this.SalvarBTN.Text = "Gerar";
            this.SalvarBTN.UseVisualStyleBackColor = true;
            this.SalvarBTN.Click += new System.EventHandler(this.SalvarBTN_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(14, 28);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(163, 37);
            this.label10.TabIndex = 48;
            this.label10.Text = "Novo Lote";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.RemoverBTN);
            this.groupBox1.Controls.Add(this.AdicionarBTN);
            this.groupBox1.Controls.Add(this.NovoLoteDGV);
            this.groupBox1.Controls.Add(this.DataValidadeDT);
            this.groupBox1.Controls.Add(this.DataRecebimentoDTP);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.CodigoTB);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.FornecedorTB);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(14, 65);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(625, 355);
            this.groupBox1.TabIndex = 50;
            this.groupBox1.TabStop = false;
            // 
            // RemoverBTN
            // 
            this.RemoverBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoverBTN.Location = new System.Drawing.Point(529, 192);
            this.RemoverBTN.Margin = new System.Windows.Forms.Padding(2);
            this.RemoverBTN.Name = "RemoverBTN";
            this.RemoverBTN.Size = new System.Drawing.Size(86, 27);
            this.RemoverBTN.TabIndex = 58;
            this.RemoverBTN.Text = "Remover";
            this.RemoverBTN.UseVisualStyleBackColor = true;
            // 
            // AdicionarBTN
            // 
            this.AdicionarBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdicionarBTN.Location = new System.Drawing.Point(531, 150);
            this.AdicionarBTN.Margin = new System.Windows.Forms.Padding(2);
            this.AdicionarBTN.Name = "AdicionarBTN";
            this.AdicionarBTN.Size = new System.Drawing.Size(84, 33);
            this.AdicionarBTN.TabIndex = 8;
            this.AdicionarBTN.Text = "Adicionar";
            this.AdicionarBTN.UseVisualStyleBackColor = true;
            this.AdicionarBTN.Click += new System.EventHandler(this.AdicionarBTN_Click);
            // 
            // NovoLoteDGV
            // 
            this.NovoLoteDGV.AllowUserToAddRows = false;
            this.NovoLoteDGV.AllowUserToDeleteRows = false;
            this.NovoLoteDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NovoLoteDGV.Location = new System.Drawing.Point(19, 150);
            this.NovoLoteDGV.Margin = new System.Windows.Forms.Padding(2);
            this.NovoLoteDGV.MultiSelect = false;
            this.NovoLoteDGV.Name = "NovoLoteDGV";
            this.NovoLoteDGV.ReadOnly = true;
            this.NovoLoteDGV.RowTemplate.Height = 28;
            this.NovoLoteDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.NovoLoteDGV.Size = new System.Drawing.Size(506, 188);
            this.NovoLoteDGV.TabIndex = 41;
            // 
            // DataValidadeDT
            // 
            this.DataValidadeDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataValidadeDT.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DataValidadeDT.Location = new System.Drawing.Point(153, 89);
            this.DataValidadeDT.Margin = new System.Windows.Forms.Padding(2);
            this.DataValidadeDT.Name = "DataValidadeDT";
            this.DataValidadeDT.Size = new System.Drawing.Size(126, 23);
            this.DataValidadeDT.TabIndex = 4;
            // 
            // DataRecebimentoDTP
            // 
            this.DataRecebimentoDTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataRecebimentoDTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DataRecebimentoDTP.Location = new System.Drawing.Point(19, 89);
            this.DataRecebimentoDTP.Margin = new System.Windows.Forms.Padding(2);
            this.DataRecebimentoDTP.Name = "DataRecebimentoDTP";
            this.DataRecebimentoDTP.Size = new System.Drawing.Size(126, 23);
            this.DataRecebimentoDTP.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(150, 71);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 35;
            this.label3.Text = "Validade";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(492, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 33;
            this.label2.Text = "Código";
            // 
            // CodigoTB
            // 
            this.CodigoTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CodigoTB.Location = new System.Drawing.Point(494, 38);
            this.CodigoTB.Margin = new System.Windows.Forms.Padding(2);
            this.CodigoTB.Name = "CodigoTB";
            this.CodigoTB.Size = new System.Drawing.Size(119, 26);
            this.CodigoTB.TabIndex = 2;
            this.CodigoTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CodigoTB_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 23;
            this.label1.Text = "Fornecedor";
            // 
            // FornecedorTB
            // 
            this.FornecedorTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FornecedorTB.Location = new System.Drawing.Point(19, 38);
            this.FornecedorTB.Margin = new System.Windows.Forms.Padding(2);
            this.FornecedorTB.Name = "FornecedorTB";
            this.FornecedorTB.Size = new System.Drawing.Size(471, 26);
            this.FornecedorTB.TabIndex = 1;
            this.FornecedorTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FornecedorTB_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 71);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 17);
            this.label5.TabIndex = 31;
            this.label5.Text = "Data de recebimento";
            // 
            // NumeroLoteLB
            // 
            this.NumeroLoteLB.AutoSize = true;
            this.NumeroLoteLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumeroLoteLB.Location = new System.Drawing.Point(451, 9);
            this.NumeroLoteLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NumeroLoteLB.Name = "NumeroLoteLB";
            this.NumeroLoteLB.Size = new System.Drawing.Size(53, 37);
            this.NumeroLoteLB.TabIndex = 51;
            this.NumeroLoteLB.Text = "Nº";
            // 
            // NLoteLB
            // 
            this.NLoteLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NLoteLB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.NLoteLB.Location = new System.Drawing.Point(508, 9);
            this.NLoteLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NLoteLB.Name = "NLoteLB";
            this.NLoteLB.Size = new System.Drawing.Size(131, 37);
            this.NLoteLB.TabIndex = 52;
            this.NLoteLB.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 123);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 25);
            this.label4.TabIndex = 53;
            this.label4.Text = "Dentes";
            // 
            // NovoLote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(650, 468);
            this.Controls.Add(this.NLoteLB);
            this.Controls.Add(this.NumeroLoteLB);
            this.Controls.Add(this.SalvarBTN);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NovoLote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NovoLote";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NovoLoteDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SalvarBTN;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView NovoLoteDGV;
        private System.Windows.Forms.DateTimePicker DataValidadeDT;
        private System.Windows.Forms.DateTimePicker DataRecebimentoDTP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CodigoTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FornecedorTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button RemoverBTN;
        private System.Windows.Forms.Button AdicionarBTN;
        private System.Windows.Forms.Label NumeroLoteLB;
        private System.Windows.Forms.Label NLoteLB;
        private System.Windows.Forms.Label label4;
    }
}