using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OdontoSIS.Menus
{
    public partial class Cadastro : UserControl
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void ClienteLB_Click(object sender, EventArgs e)
        {
            Principal.Controls.Clear();
            Janelas.Clientes clientesJanela = new Janelas.Clientes();
            Principal.Controls.Add(clientesJanela);

            ClearBackColores();
            ClienteLB.BackColor = Color.White;
            ClienteLB.ForeColor = Color.Black;
        }

        private void Cadastro_Load(object sender, EventArgs e)
        {

        }
        private void ClearBackColores()
        {
            ClienteLB.BackColor = Color.Transparent;
            FornecedorLB.BackColor = Color.Transparent;
            LoteLB.BackColor = Color.Transparent;

            ClienteLB.ForeColor = Color.White;
            FornecedorLB.ForeColor = Color.White;
            LoteLB.ForeColor = Color.White;
        }

        private void FornecedorLB_Click(object sender, EventArgs e)
        {
            Principal.Controls.Clear();
            Principal.Controls.Add(new Janelas.Fornecedor());

          
            ClearBackColores();
            FornecedorLB.BackColor = Color.White;
            FornecedorLB.ForeColor = Color.Black;

        }

        private void LoteLB_Click(object sender, EventArgs e)
        {
            Principal.Controls.Clear();
            Principal.Controls.Add(new Janelas.Lote());

            ClearBackColores();
            LoteLB.BackColor = Color.White;
            LoteLB.ForeColor = Color.Black;
        }

        private void Principal_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
