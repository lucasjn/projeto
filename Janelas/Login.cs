using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OdontoSIS.Janelas
{
    public partial class Login : System.Windows.Forms.Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void CancelarBTN_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void EntrarBTN_Click(object sender, EventArgs e)
        {
            if (Sessao.DB.TableExecute("SELECT * FROM Usuarios WHERE Usuario = \"" + LoginTB.Text + "\" and Senha=\"" + SenhaTB.Text + "\"").Rows.Count > 0)
            {
                Models.Usuario usuario = new Models.Usuario();
                usuario.Nome = LoginTB.Text;
                usuario.Senha = SenhaTB.Text;
                Sessao.Usuario = usuario;

                Hide();
                new Form1().ShowDialog();
                Show();
                Sessao.Usuario = null;

            }
            else
            {
                MessageBox.Show("Usuário ou Senha incorretos !", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        private void LoginTB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SenhaTB.Focus();
            }
        }

        private void SenhaTB_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                EntrarBTN_Click(sender, e);
            }
        }
    }
}
