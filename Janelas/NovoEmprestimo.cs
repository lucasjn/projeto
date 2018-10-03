using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OdontoSIS.Janelas
{
    public partial class NovoEmprestimo : UserControl
    {
        private int codigo_cliente = 0;
        private DataTable tabelaItems = new DataTable();

        public NovoEmprestimo()
        {
            InitializeComponent();
        }

  
        private void ClienteLB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {

                    Pesquisa pesquisa = new Pesquisa("Clientes", "Nome", "Cod_Clinete");
                    pesquisa.ShowDialog();
                    codigo_cliente = pesquisa.Codigo;
                    ClienteLB.Text = pesquisa.Selecionado;
                    CodigoLB.Text = pesquisa.Codigo.ToString();
                    

                }
                catch (Exception)
                {

                    throw;
                }
            }
        }
    }
}
