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
    public partial class Clientes : UserControl
    {
        BindingSource filtro = new BindingSource();
        DataTable tabela = new DataTable();

        public Clientes()
        {
            InitializeComponent();
            CarregarClientes();

        }

        private void NovoBTN_Click(object sender, EventArgs e)
        {
            new NovoCliente().ShowDialog();
            CarregarClientes();

        }
        private void CarregarClientes()
        {
            tabela = Sessao.DB.TableExecute("select * from clientes");
            filtro.DataSource = tabela;
            ClientesDGV.DataSource = filtro;
            
        }

        private void CampoBuscaTB_TextChanged(object sender, EventArgs e)
        {
            filtro.Filter = "Nome like '%"+ CampoBuscaTB.Text + "%'";
        }

        private void RemoverBTN_Click(object sender, EventArgs e)
        {
           
            try
            {
                string cod_Cliente = ((DataRowView)filtro.Current).Row["Cod_Cliente"].ToString();
                Sessao.DB.TableExecute("delete from Clientes where Cod_Cliente="+cod_Cliente);
                filtro.RemoveCurrent();

            }
            catch(Exception)
            {
            }


        }

        private void EditarBTN_Click(object sender, EventArgs e)
        {
            int codigo = (int)((DataRowView)filtro.Current).Row["Cod_Cliente"];
            new Janelas.NovoCliente(codigo).ShowDialog();
            CarregarClientes();


        }
    }
}
