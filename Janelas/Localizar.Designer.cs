namespace OdontoSIS.Janelas
{
    partial class Localizar
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
            this.ProcurarBTN = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.CaminhoTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ProcurarBTN
            // 
            this.ProcurarBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProcurarBTN.Location = new System.Drawing.Point(735, 141);
            this.ProcurarBTN.Name = "ProcurarBTN";
            this.ProcurarBTN.Size = new System.Drawing.Size(123, 37);
            this.ProcurarBTN.TabIndex = 34;
            this.ProcurarBTN.Text = "Procurar";
            this.ProcurarBTN.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(14, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(555, 52);
            this.label10.TabIndex = 32;
            this.label10.Text = "Localizar Banco de Dados";
            // 
            // CaminhoTB
            // 
            this.CaminhoTB.Font = new System.Drawing.Font("Lucida Sans", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaminhoTB.Location = new System.Drawing.Point(23, 141);
            this.CaminhoTB.Name = "CaminhoTB";
            this.CaminhoTB.Size = new System.Drawing.Size(706, 31);
            this.CaminhoTB.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 25);
            this.label1.TabIndex = 30;
            this.label1.Text = "Local";
            // 
            // Localizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ProcurarBTN);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.CaminhoTB);
            this.Controls.Add(this.label1);
            this.Name = "Localizar";
            this.Size = new System.Drawing.Size(917, 746);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ProcurarBTN;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox CaminhoTB;
        private System.Windows.Forms.Label label1;
    }
}
