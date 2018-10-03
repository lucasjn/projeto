namespace OdontoSIS.Menus
{
    partial class Emprestimo
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
            this.StatusLB = new System.Windows.Forms.Label();
            this.NovoLB = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Principal = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // StatusLB
            // 
            this.StatusLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.StatusLB.ForeColor = System.Drawing.Color.White;
            this.StatusLB.Location = new System.Drawing.Point(49, 70);
            this.StatusLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.StatusLB.Name = "StatusLB";
            this.StatusLB.Size = new System.Drawing.Size(133, 50);
            this.StatusLB.TabIndex = 7;
            this.StatusLB.Text = "Status             ";
            this.StatusLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.StatusLB.Click += new System.EventHandler(this.StatusLB_Click);
            // 
            // NovoLB
            // 
            this.NovoLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.NovoLB.ForeColor = System.Drawing.Color.White;
            this.NovoLB.Location = new System.Drawing.Point(49, 24);
            this.NovoLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NovoLB.Name = "NovoLB";
            this.NovoLB.Size = new System.Drawing.Size(133, 45);
            this.NovoLB.TabIndex = 6;
            this.NovoLB.Text = "Novo              ";
            this.NovoLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.NovoLB.Click += new System.EventHandler(this.NovoLB_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::OdontoSIS.Properties.Resources.icons8_dente_filled_100;
            this.pictureBox2.Location = new System.Drawing.Point(2, 24);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(49, 45);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::OdontoSIS.Properties.Resources.icons8_dente_96;
            this.pictureBox1.Location = new System.Drawing.Point(-7, 70);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(57, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Principal
            // 
            this.Principal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Principal.BackColor = System.Drawing.Color.White;
            this.Principal.Location = new System.Drawing.Point(163, -1);
            this.Principal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Principal.Name = "Principal";
            this.Principal.Size = new System.Drawing.Size(1117, 758);
            this.Principal.TabIndex = 11;
            // 
            // Emprestimo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.Controls.Add(this.Principal);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.StatusLB);
            this.Controls.Add(this.NovoLB);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Emprestimo";
            this.Size = new System.Drawing.Size(1284, 1280);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label StatusLB;
        private System.Windows.Forms.Label NovoLB;
        private System.Windows.Forms.Panel Principal;
    }
}
