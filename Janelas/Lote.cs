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
    public partial class Lote : UserControl
    {
        BindingSource filtro = new BindingSource();
        DataTable tabela = new DataTable();
        

        public Lote()
        {
            InitializeComponent();
            CarregarLote();
            //DescricaoRTB_TextChanged();
        }

        public void CarregarLote()
        {
             tabela = Sessao.DB.TableExecute("SELECT * FROM Lotes ");
             filtro.DataSource = tabela;
             LoteDGV.DataSource = filtro;
            LoteDGV.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
           // LoteDGV.Columns[0].Width = default;




        }
        
        private void NovoBTN_Click(object sender, EventArgs e)
        {
            new NovoLote().ShowDialog();
            CarregarLote();
        }

        private void CampoBuscaTB_TextChanged(object sender, EventArgs e)
        {
            //filtro.Filter = "";
        }

        private void RemoverBTN_Click(object sender, EventArgs e)
        {
            try
            {
                string cod_Lote = ((DataRowView)filtro.Current).Row["Cod_Lote"].ToString();
                Sessao.DB.TableExecute("delete from Lotes where Cod_Lote=" + cod_Lote);
                filtro.RemoveCurrent();

            }
            catch (Exception)
            {
            }
        }

        private void EditarBTN_Click(object sender, EventArgs e)
        {
            int codigo = (int)((DataRowView)filtro.Current).Row["Cod_Lote"];
            new Janelas.NovoCliente(codigo).ShowDialog();
            CarregarLote();
        }

        private void DescricaoRTB_TextChanged(object sender, EventArgs e)
        {
               
        }
    }
}
