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
    public partial class Fornecedor : UserControl
    {
        BindingSource filtro = new BindingSource();
        DataTable tabela = new DataTable();
        private object codigo=0;

        public Fornecedor()
        {
            InitializeComponent();
            CarregarFornecedor();

        }
        private void NovoBTN_Click(object sender, EventArgs e)
        {
            new NovoFornecedor().ShowDialog();
            CarregarFornecedor();
        }

        private void CarregarFornecedor()
        {
            tabela = Sessao.DB.TableExecute("SELECT * FROM Fornecedores");
            filtro.DataSource = tabela;
            FornecedorDGV.DataSource = filtro;


        }

        private void CampoBuscaTB_TextChanged(object sender, EventArgs e)
        {
            filtro.Filter = "Nome like '%" + CampoBuscaTB.Text+"%'";
        }

        private void RemoverBTN_Click(object sender, EventArgs e)
        {
            try
            {
                string cod_Fornecedor = ((DataRowView)filtro.Current).Row["Cod_Fornecedor"].ToString();
                Sessao.DB.TableExecute("delete from Fornecedores where Cod_Fornecedor=" + cod_Fornecedor);
                filtro.RemoveCurrent();

            }
            catch (Exception)
            {
            }
        }

        private void EditarBTN_Click(object sender, EventArgs e)
        {
            int codigo = (int)((DataRowView)filtro.Current).Row["Cod_Fornecedor"];
            new Janelas.NovoFornecedor(codigo).ShowDialog();
            CarregarFornecedor();


        }

        private void Fornecedor_Load(object sender, EventArgs e)
        {

        }
    }
}
