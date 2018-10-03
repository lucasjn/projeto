namespace OdontoSIS.Menus
{
    partial class Sobre
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
            this.AplicativoLB = new System.Windows.Forms.Label();
            this.DesenvolvedoresLB = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Principal = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // AplicativoLB
            // 
            this.AplicativoLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.AplicativoLB.ForeColor = System.Drawing.Color.White;
            this.AplicativoLB.Location = new System.Drawing.Point(64, 62);
            this.AplicativoLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AplicativoLB.Name = "AplicativoLB";
            this.AplicativoLB.Size = new System.Drawing.Size(144, 41);
            this.AplicativoLB.TabIndex = 13;
            this.AplicativoLB.Text = "Aplicativo";
            this.AplicativoLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AplicativoLB.Click += new System.EventHandler(this.AplicativosLB_Click);
            // 
            // DesenvolvedoresLB
            // 
            this.DesenvolvedoresLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.DesenvolvedoresLB.ForeColor = System.Drawing.Color.White;
            this.DesenvolvedoresLB.Location = new System.Drawing.Point(66, 18);
            this.DesenvolvedoresLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DesenvolvedoresLB.Name = "DesenvolvedoresLB";
            this.DesenvolvedoresLB.Size = new System.Drawing.Size(142, 41);
            this.DesenvolvedoresLB.TabIndex = 12;
            this.DesenvolvedoresLB.Text = "Desenvolvedores";
            this.DesenvolvedoresLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DesenvolvedoresLB.Click += new System.EventHandler(this.DesenvolvedoresLB_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::OdontoSIS.Properties.Resources.icons8_sobre_48;
            this.pictureBox2.Location = new System.Drawing.Point(8, 62);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(52, 41);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::OdontoSIS.Properties.Resources.icons8_desenvolvedor_filled_100;
            this.pictureBox1.Location = new System.Drawing.Point(9, 16);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // Principal
            // 
            this.Principal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Principal.BackColor = System.Drawing.Color.White;
            this.Principal.Location = new System.Drawing.Point(206, 0);
            this.Principal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Principal.Name = "Principal";
            this.Principal.Size = new System.Drawing.Size(1103, 758);
            this.Principal.TabIndex = 17;
            // 
            // Sobre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.Controls.Add(this.Principal);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.AplicativoLB);
            this.Controls.Add(this.DesenvolvedoresLB);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Sobre";
            this.Size = new System.Drawing.Size(1308, 1040);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label AplicativoLB;
        private System.Windows.Forms.Label DesenvolvedoresLB;
        private System.Windows.Forms.Panel Principal;
    }
}
