namespace OdontoSIS.Janelas
{
    partial class Pesquisa
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
            this.PesquisaDVG = new System.Windows.Forms.DataGridView();
            this.CampoPesquisaTB = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PesquisaDVG)).BeginInit();
            this.SuspendLayout();
            // 
            // PesquisaDVG
            // 
            this.PesquisaDVG.AllowUserToAddRows = false;
            this.PesquisaDVG.AllowUserToDeleteRows = false;
            this.PesquisaDVG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PesquisaDVG.Location = new System.Drawing.Point(12, 44);
            this.PesquisaDVG.MultiSelect = false;
            this.PesquisaDVG.Name = "PesquisaDVG";
            this.PesquisaDVG.ReadOnly = true;
            this.PesquisaDVG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PesquisaDVG.Size = new System.Drawing.Size(586, 394);
            this.PesquisaDVG.TabIndex = 3;
            this.PesquisaDVG.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PesquisaDVG_CellDoubleClick);
            // 
            // CampoPesquisaTB
            // 
            this.CampoPesquisaTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CampoPesquisaTB.Location = new System.Drawing.Point(12, 12);
            this.CampoPesquisaTB.Name = "CampoPesquisaTB";
            this.CampoPesquisaTB.Size = new System.Drawing.Size(586, 26);
            this.CampoPesquisaTB.TabIndex = 2;
            this.CampoPesquisaTB.TextChanged += new System.EventHandler(this.CampoPesquisaTB_TextChanged);
            this.CampoPesquisaTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CampoPesquisaTB_KeyDown);
            // 
            // Pesquisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 450);
            this.Controls.Add(this.PesquisaDVG);
            this.Controls.Add(this.CampoPesquisaTB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Pesquisa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisa";
            ((System.ComponentModel.ISupportInitialize)(this.PesquisaDVG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView PesquisaDVG;
        private System.Windows.Forms.TextBox CampoPesquisaTB;
    }
}