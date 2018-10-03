namespace OdontoSIS.Janelas
{
    partial class Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LoginTB = new System.Windows.Forms.TextBox();
            this.SenhaTB = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.EntrarBTN = new System.Windows.Forms.Button();
            this.CancelarBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(42, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuário";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(42, 278);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Senha";
            // 
            // LoginTB
            // 
            this.LoginTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginTB.Location = new System.Drawing.Point(161, 206);
            this.LoginTB.Name = "LoginTB";
            this.LoginTB.Size = new System.Drawing.Size(268, 39);
            this.LoginTB.TabIndex = 2;
            this.LoginTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LoginTB_KeyDown);
            // 
            // SenhaTB
            // 
            this.SenhaTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SenhaTB.Location = new System.Drawing.Point(161, 278);
            this.SenhaTB.Name = "SenhaTB";
            this.SenhaTB.PasswordChar = '*';
            this.SenhaTB.Size = new System.Drawing.Size(268, 39);
            this.SenhaTB.TabIndex = 3;
            this.SenhaTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SenhaTB_KeyDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::OdontoSIS.Properties.Resources.icons8_usuário_filled_100;
            this.pictureBox1.Location = new System.Drawing.Point(154, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(168, 154);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // EntrarBTN
            // 
            this.EntrarBTN.BackColor = System.Drawing.Color.White;
            this.EntrarBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EntrarBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EntrarBTN.Location = new System.Drawing.Point(285, 362);
            this.EntrarBTN.Name = "EntrarBTN";
            this.EntrarBTN.Size = new System.Drawing.Size(144, 50);
            this.EntrarBTN.TabIndex = 5;
            this.EntrarBTN.Text = "Entrar";
            this.EntrarBTN.UseVisualStyleBackColor = false;
            this.EntrarBTN.Click += new System.EventHandler(this.EntrarBTN_Click);
            // 
            // CancelarBTN
            // 
            this.CancelarBTN.BackColor = System.Drawing.Color.White;
            this.CancelarBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CancelarBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelarBTN.Location = new System.Drawing.Point(48, 362);
            this.CancelarBTN.Name = "CancelarBTN";
            this.CancelarBTN.Size = new System.Drawing.Size(144, 50);
            this.CancelarBTN.TabIndex = 6;
            this.CancelarBTN.Text = "Cancelar";
            this.CancelarBTN.UseVisualStyleBackColor = false;
            this.CancelarBTN.Click += new System.EventHandler(this.CancelarBTN_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(479, 445);
            this.Controls.Add(this.CancelarBTN);
            this.Controls.Add(this.EntrarBTN);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.SenhaTB);
            this.Controls.Add(this.LoginTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox LoginTB;
        private System.Windows.Forms.TextBox SenhaTB;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button EntrarBTN;
        private System.Windows.Forms.Button CancelarBTN;
    }
}