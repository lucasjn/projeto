namespace OdontoSIS.Menus
{
    partial class Devolucao
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
            this.AnaliseLB = new System.Windows.Forms.Label();
            this.NovoLB = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Principal = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // AnaliseLB
            // 
            this.AnaliseLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.AnaliseLB.ForeColor = System.Drawing.Color.White;
            this.AnaliseLB.Location = new System.Drawing.Point(53, 80);
            this.AnaliseLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AnaliseLB.Name = "AnaliseLB";
            this.AnaliseLB.Size = new System.Drawing.Size(107, 42);
            this.AnaliseLB.TabIndex = 12;
            this.AnaliseLB.Text = "Análise     ";
            this.AnaliseLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AnaliseLB.Click += new System.EventHandler(this.AnaliseLB_Click);
            // 
            // NovoLB
            // 
            this.NovoLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.NovoLB.ForeColor = System.Drawing.Color.White;
            this.NovoLB.Location = new System.Drawing.Point(57, 28);
            this.NovoLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NovoLB.Name = "NovoLB";
            this.NovoLB.Size = new System.Drawing.Size(103, 50);
            this.NovoLB.TabIndex = 11;
            this.NovoLB.Text = "Novo        ";
            this.NovoLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.NovoLB.Click += new System.EventHandler(this.NovoLB_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::OdontoSIS.Properties.Resources.icons8_dente_filled_100;
            this.pictureBox2.Location = new System.Drawing.Point(2, 18);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(55, 59);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::OdontoSIS.Properties.Resources.icons8_dente_filled_100__1_;
            this.pictureBox1.Location = new System.Drawing.Point(2, 72);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // Principal
            // 
            this.Principal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Principal.BackColor = System.Drawing.Color.White;
            this.Principal.Location = new System.Drawing.Point(153, 0);
            this.Principal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Principal.Name = "Principal";
            this.Principal.Size = new System.Drawing.Size(1043, 758);
            this.Principal.TabIndex = 15;
            // 
            // Devolucao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.Controls.Add(this.Principal);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.AnaliseLB);
            this.Controls.Add(this.NovoLB);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Devolucao";
            this.Size = new System.Drawing.Size(1196, 1040);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label AnaliseLB;
        private System.Windows.Forms.Label NovoLB;
        private System.Windows.Forms.Panel Principal;
    }
}
