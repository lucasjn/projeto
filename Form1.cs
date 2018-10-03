using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OdontoSIS
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            ClearBackColores();
            ImgOPCadastro.BackColor = Color.FromName("Highlight");

            PrincipalP.Controls.Clear();
            PrincipalP.Controls.Add(new Menus.Cadastro());
        }

        private void ClearBackColores()
        {
            ImgOPCadastro.BackColor = Color.Black;
            ImgOPAuditoria.BackColor = Color.Black;
            ImgOPConfiguracoes.BackColor = Color.Black;
            ImgOPDevolucao.BackColor = Color.Black;
            ImgOPEmprestimo.BackColor = Color.Black;
            ImgOPSobre.BackColor = Color.Black;
        }

        private void ImgOPEmprestimo_Click(object sender, EventArgs e)
        {
            ClearBackColores();
            ImgOPEmprestimo.BackColor = Color.FromName("DarkOliveGreen");

            PrincipalP.Controls.Clear();
            PrincipalP.Controls.Add(new Menus.Emprestimo());
        }

        private void ImgOPDevolucao_Click(object sender, EventArgs e)
        {
            ClearBackColores();
            ImgOPDevolucao.BackColor = Color.FromName("Goldenrod");

            PrincipalP.Controls.Clear();
            PrincipalP.Controls.Add(new Menus.Devolucao());
        }

        private void ImgOPAuditoria_Click(object sender, EventArgs e)
        {
            ClearBackColores();
            ImgOPAuditoria.BackColor = Color.FromName("Chocolate");

            PrincipalP.Controls.Clear();
            PrincipalP.Controls.Add(new Menus.Auditoria());
        }

        private void ImgOPConfiguracoes_Click(object sender, EventArgs e)
        {
            ClearBackColores();
            ImgOPConfiguracoes.BackColor = Color.FromName("Firebrick");

            PrincipalP.Controls.Clear();
            PrincipalP.Controls.Add(new Menus.Configuração());
        }

        private void ImgOPSobre_Click(object sender, EventArgs e)
        {
            ClearBackColores();
            ImgOPSobre.BackColor = Color.FromName("Highlight");

            PrincipalP.Controls.Clear();
            PrincipalP.Controls.Add(new Menus.Sobre());
        }

        private void Label1Cadastros_Click(object sender, EventArgs e)
        {
            ClearBackColores();
            ImgOPCadastro.BackColor = Color.FromName("Highlight");

            PrincipalP.Controls.Clear();
            Menus.Cadastro cadastro = new Menus.Cadastro();
            PrincipalP.Controls.Add(cadastro);

        }

    }
}
