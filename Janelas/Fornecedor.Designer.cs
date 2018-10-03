namespace OdontoSIS.Janelas
{
    partial class Fornecedor
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.RemoverBTN = new System.Windows.Forms.Button();
            this.EditarBTN = new System.Windows.Forms.Button();
            this.NovoBTN = new System.Windows.Forms.Button();
            this.FornecedorDGV = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.CampoBuscaTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.FornecedorDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // RemoverBTN
            // 
            this.RemoverBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoverBTN.Location = new System.Drawing.Point(563, 171);
            this.RemoverBTN.Margin = new System.Windows.Forms.Padding(2);
            this.RemoverBTN.Name = "RemoverBTN";
            this.RemoverBTN.Size = new System.Drawing.Size(82, 24);
            this.RemoverBTN.TabIndex = 29;
            this.RemoverBTN.Text = "Remover";
            this.RemoverBTN.UseVisualStyleBackColor = true;
            this.RemoverBTN.Click += new System.EventHandler(this.RemoverBTN_Click);
            // 
            // EditarBTN
            // 
            this.EditarBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditarBTN.Location = new System.Drawing.Point(563, 144);
            this.EditarBTN.Margin = new System.Windows.Forms.Padding(2);
            this.EditarBTN.Name = "EditarBTN";
            this.EditarBTN.Size = new System.Drawing.Size(82, 24);
            this.EditarBTN.TabIndex = 28;
            this.EditarBTN.Text = "Editar";
            this.EditarBTN.UseVisualStyleBackColor = true;
            this.EditarBTN.Click += new System.EventHandler(this.EditarBTN_Click);
            // 
            // NovoBTN
            // 
            this.NovoBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NovoBTN.Location = new System.Drawing.Point(563, 116);
            this.NovoBTN.Margin = new System.Windows.Forms.Padding(2);
            this.NovoBTN.Name = "NovoBTN";
            this.NovoBTN.Size = new System.Drawing.Size(82, 24);
            this.NovoBTN.TabIndex = 27;
            this.NovoBTN.Text = "Novo";
            this.NovoBTN.UseVisualStyleBackColor = true;
            this.NovoBTN.Click += new System.EventHandler(this.NovoBTN_Click);
            // 
            // FornecedorDGV
            // 
            this.FornecedorDGV.AllowUserToAddRows = false;
            this.FornecedorDGV.AllowUserToDeleteRows = false;
            this.FornecedorDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FornecedorDGV.Location = new System.Drawing.Point(20, 116);
            this.FornecedorDGV.Margin = new System.Windows.Forms.Padding(2);
            this.FornecedorDGV.MultiSelect = false;
            this.FornecedorDGV.Name = "FornecedorDGV";
            this.FornecedorDGV.RowTemplate.Height = 28;
            this.FornecedorDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.FornecedorDGV.Size = new System.Drawing.Size(540, 308);
            this.FornecedorDGV.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(13, 13);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(211, 36);
            this.label10.TabIndex = 25;
            this.label10.Text = "Fornecedores";
            // 
            // CampoBuscaTB
            // 
            this.CampoBuscaTB.Font = new System.Drawing.Font("Lucida Sans", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CampoBuscaTB.Location = new System.Drawing.Point(19, 89);
            this.CampoBuscaTB.Margin = new System.Windows.Forms.Padding(2);
            this.CampoBuscaTB.Name = "CampoBuscaTB";
            this.CampoBuscaTB.Size = new System.Drawing.Size(540, 23);
            this.CampoBuscaTB.TabIndex = 24;
            this.CampoBuscaTB.TextChanged += new System.EventHandler(this.CampoBuscaTB_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 23;
            this.label1.Text = "Procurar";
            // 
            // Fornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.RemoverBTN);
            this.Controls.Add(this.EditarBTN);
            this.Controls.Add(this.NovoBTN);
            this.Controls.Add(this.FornecedorDGV);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.CampoBuscaTB);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Fornecedor";
            this.Size = new System.Drawing.Size(658, 485);
            this.Load += new System.EventHandler(this.Fornecedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FornecedorDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RemoverBTN;
        private System.Windows.Forms.Button EditarBTN;
        private System.Windows.Forms.Button NovoBTN;
        private System.Windows.Forms.DataGridView FornecedorDGV;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox CampoBuscaTB;
        private System.Windows.Forms.Label label1;
    }
}
