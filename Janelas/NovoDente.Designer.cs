namespace OdontoSIS.Janelas
{
    partial class NovoDente
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
            this.NomeDenteTB = new System.Windows.Forms.TextBox();
            this.NumeroDenteTB = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.EstadosLB = new System.Windows.Forms.ListBox();
            this.ListaEstadosLB = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.QtTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NomeDenteTB
            // 
            this.NomeDenteTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomeDenteTB.Location = new System.Drawing.Point(92, 88);
            this.NomeDenteTB.Margin = new System.Windows.Forms.Padding(2);
            this.NomeDenteTB.Name = "NomeDenteTB";
            this.NomeDenteTB.ReadOnly = true;
            this.NomeDenteTB.Size = new System.Drawing.Size(181, 26);
            this.NomeDenteTB.TabIndex = 69;
            // 
            // NumeroDenteTB
            // 
            this.NumeroDenteTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumeroDenteTB.Location = new System.Drawing.Point(11, 88);
            this.NumeroDenteTB.Margin = new System.Windows.Forms.Padding(2);
            this.NumeroDenteTB.Name = "NumeroDenteTB";
            this.NumeroDenteTB.Size = new System.Drawing.Size(77, 26);
            this.NumeroDenteTB.TabIndex = 62;
            this.NumeroDenteTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NumeroDenteTB_KeyDown);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(11, 9);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(185, 37);
            this.label10.TabIndex = 65;
            this.label10.Text = "Novo Dente";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(89, 69);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 17);
            this.label8.TabIndex = 72;
            this.label8.Text = "Dente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 69);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 70;
            this.label4.Text = "Nº Dente";
            // 
            // EstadosLB
            // 
            this.EstadosLB.FormattingEnabled = true;
            this.EstadosLB.Location = new System.Drawing.Point(11, 148);
            this.EstadosLB.Name = "EstadosLB";
            this.EstadosLB.Size = new System.Drawing.Size(145, 212);
            this.EstadosLB.TabIndex = 73;
            this.EstadosLB.DoubleClick += new System.EventHandler(this.EstadosLB_DoubleClick);
            // 
            // ListaEstadosLB
            // 
            this.ListaEstadosLB.FormattingEnabled = true;
            this.ListaEstadosLB.Location = new System.Drawing.Point(191, 148);
            this.ListaEstadosLB.Name = "ListaEstadosLB";
            this.ListaEstadosLB.Size = new System.Drawing.Size(145, 212);
            this.ListaEstadosLB.TabIndex = 74;
            this.ListaEstadosLB.DoubleClick += new System.EventHandler(this.ListaEstadosLB_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 128);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 17);
            this.label1.TabIndex = 75;
            this.label1.Text = "Estados Atuais";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(188, 128);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 76;
            this.label2.Text = "Estados";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(258, 366);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 32);
            this.button1.TabIndex = 77;
            this.button1.Text = "Adicionar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // QtTB
            // 
            this.QtTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QtTB.Location = new System.Drawing.Point(277, 88);
            this.QtTB.Margin = new System.Windows.Forms.Padding(2);
            this.QtTB.Name = "QtTB";
            this.QtTB.Size = new System.Drawing.Size(58, 26);
            this.QtTB.TabIndex = 78;
            this.QtTB.Text = "1";
            this.QtTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.QtTB.Enter += new System.EventHandler(this.QtTB_Enter);
            this.QtTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.QtTB_KeyDown);
            this.QtTB.Leave += new System.EventHandler(this.QtTB_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(275, 69);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 17);
            this.label3.TabIndex = 79;
            this.label3.Text = "Qt";
            // 
            // NovoDente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 410);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.QtTB);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ListaEstadosLB);
            this.Controls.Add(this.EstadosLB);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NomeDenteTB);
            this.Controls.Add(this.NumeroDenteTB);
            this.Controls.Add(this.label10);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NovoDente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NovoDente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NomeDenteTB;
        private System.Windows.Forms.TextBox NumeroDenteTB;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox EstadosLB;
        private System.Windows.Forms.ListBox ListaEstadosLB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox QtTB;
        private System.Windows.Forms.Label label3;
    }
}