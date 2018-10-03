namespace OdontoSIS.Janelas
{
    partial class Clientes
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.CampoBuscaTB = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.ClientesDGV = new System.Windows.Forms.DataGridView();
            this.clientesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.NovoBTN = new System.Windows.Forms.Button();
            this.EditarBTN = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ClientesDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSet1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Procurar";
            // 
            // CampoBuscaTB
            // 
            this.CampoBuscaTB.Font = new System.Drawing.Font("Lucida Sans", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CampoBuscaTB.Location = new System.Drawing.Point(17, 92);
            this.CampoBuscaTB.Margin = new System.Windows.Forms.Padding(2);
            this.CampoBuscaTB.Name = "CampoBuscaTB";
            this.CampoBuscaTB.Size = new System.Drawing.Size(541, 23);
            this.CampoBuscaTB.TabIndex = 1;
            this.CampoBuscaTB.TextChanged += new System.EventHandler(this.CampoBuscaTB_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(11, 11);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(130, 36);
            this.label10.TabIndex = 18;
            this.label10.Text = "Clientes";
            // 
            // ClientesDGV
            // 
            this.ClientesDGV.AllowUserToAddRows = false;
            this.ClientesDGV.AllowUserToDeleteRows = false;
            this.ClientesDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientesDGV.Location = new System.Drawing.Point(18, 119);
            this.ClientesDGV.Margin = new System.Windows.Forms.Padding(2);
            this.ClientesDGV.Name = "ClientesDGV";
            this.ClientesDGV.ReadOnly = true;
            this.ClientesDGV.RowTemplate.Height = 28;
            this.ClientesDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ClientesDGV.Size = new System.Drawing.Size(540, 308);
            this.ClientesDGV.TabIndex = 19;
            // 
            // clientesBindingSource1
            // 
            this.clientesBindingSource1.DataMember = "Clientes";
            // 
            // NovoBTN
            // 
            this.NovoBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NovoBTN.Location = new System.Drawing.Point(562, 119);
            this.NovoBTN.Margin = new System.Windows.Forms.Padding(2);
            this.NovoBTN.Name = "NovoBTN";
            this.NovoBTN.Size = new System.Drawing.Size(82, 24);
            this.NovoBTN.TabIndex = 20;
            this.NovoBTN.Text = "Novo";
            this.NovoBTN.UseVisualStyleBackColor = true;
            this.NovoBTN.Click += new System.EventHandler(this.NovoBTN_Click);
            // 
            // EditarBTN
            // 
            this.EditarBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditarBTN.Location = new System.Drawing.Point(562, 147);
            this.EditarBTN.Margin = new System.Windows.Forms.Padding(2);
            this.EditarBTN.Name = "EditarBTN";
            this.EditarBTN.Size = new System.Drawing.Size(82, 24);
            this.EditarBTN.TabIndex = 21;
            this.EditarBTN.Text = "Editar";
            this.EditarBTN.UseVisualStyleBackColor = true;
            this.EditarBTN.Click += new System.EventHandler(this.EditarBTN_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(562, 175);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(82, 24);
            this.button3.TabIndex = 22;
            this.button3.Text = "Remover";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.button3);
            this.Controls.Add(this.EditarBTN);
            this.Controls.Add(this.NovoBTN);
            this.Controls.Add(this.ClientesDGV);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.CampoBuscaTB);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Clientes";
            this.Size = new System.Drawing.Size(658, 485);
            ((System.ComponentModel.ISupportInitialize)(this.ClientesDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSet1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CampoBuscaTB;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView ClientesDGV;
        private System.Windows.Forms.Button NovoBTN;
        private System.Windows.Forms.Button EditarBTN;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private System.Windows.Forms.BindingSource clientesBindingSource1;
        private System.Windows.Forms.BindingSource dataDataSet1BindingSource;
    }
}
