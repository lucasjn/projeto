namespace OdontoSIS.Menus
{
    partial class Auditoria
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
            this.LoteVLB = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Principal = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // LoteVLB
            // 
            this.LoteVLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LoteVLB.ForeColor = System.Drawing.Color.White;
            this.LoteVLB.Location = new System.Drawing.Point(55, 28);
            this.LoteVLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LoteVLB.Name = "LoteVLB";
            this.LoteVLB.Size = new System.Drawing.Size(120, 46);
            this.LoteVLB.TabIndex = 15;
            this.LoteVLB.Text = "Lotes Vencidos";
            this.LoteVLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LoteVLB.Click += new System.EventHandler(this.LoteVLB_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::OdontoSIS.Properties.Resources.icons8_calendário_filled_100;
            this.pictureBox2.Location = new System.Drawing.Point(0, 28);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(51, 46);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // Principal
            // 
            this.Principal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Principal.BackColor = System.Drawing.Color.White;
            this.Principal.Location = new System.Drawing.Point(170, 0);
            this.Principal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Principal.Name = "Principal";
            this.Principal.Size = new System.Drawing.Size(960, 1113);
            this.Principal.TabIndex = 19;
            // 
            // Auditoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chocolate;
            this.Controls.Add(this.Principal);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.LoteVLB);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Auditoria";
            this.Size = new System.Drawing.Size(1130, 1040);
            this.Load += new System.EventHandler(this.Auditoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label LoteVLB;
        private System.Windows.Forms.Panel Principal;
    }
}
