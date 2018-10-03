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
    public partial class NovoLote : System.Windows.Forms.Form
    {
        private int codigo_fornecedor = 0;
        private DataTable tabelaItems = new DataTable();
        private bool Gerado = false;


        public NovoLote()
        {
            InitializeComponent();
            
            tabelaItems.Columns.Add("NDente", typeof(int));
            tabelaItems.Columns.Add("Nome", typeof(string));
            tabelaItems.Columns.Add("Estado", typeof(string));
            tabelaItems.Columns.Add("Tipo", typeof(string));
            tabelaItems.Columns.Add("QT", typeof(int));
            NovoLoteDGV.DataSource = tabelaItems;
        }

        private void FornecedorTB_KeyDown(object sender, KeyEventArgs e)
        {
            Pesquisa pesquisa = new Pesquisa("Fornecedores","Nome","Cod_Fornecedor");
            pesquisa.ShowDialog();
            codigo_fornecedor = pesquisa.Codigo;
            FornecedorTB.Text = pesquisa.Selecionado;
            CodigoTB.Text = pesquisa.Codigo.ToString();
          


        }

        private void CodigoTB_KeyDown(object sender, KeyEventArgs e)
        {
            //Verificando se a tecla enter foi apertada
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    //buscando no read o fornecedor selecionado e enviando o codigo como parametro.
                    CRUD.Read read = new CRUD.Read();
                    Models.Fornecedores fornecedor = read.GetFornecedor(Convert.ToInt32(CodigoTB.Text));
                    FornecedorTB.Text = fornecedor.Nome;
                    codigo_fornecedor = fornecedor.Codigo;
                }
                catch (Exception)
                {
                    MessageBox.Show("Código de fornecedor inexistente!");
                }
            }
        }

       

       
        private void AdicionarBTN_Click(object sender, EventArgs e)
        {
            new NovoDente().ShowDialog();
        }

        private void SalvarBTN_Click(object sender, EventArgs e)
        {
            if (Gerado)
            {
                Close();
            }
            else
            {
                Sessao.DB.TableExecute("Insert into Lotes (Cod_Fornecedor,data_lote,Data_validade) values(" + codigo_fornecedor+",#"+DataRecebimentoDTP.Value+"#,#"+DataValidadeDT.Value+"#)");
                DataTable table = Sessao.DB.TableExecute("select max(cod_lote) as cod_lote from Lotes");
                int cod_lote = (int)table.Rows[0]["cod_lote"];
                NLoteLB.Text = cod_lote.ToString();

                for (int i = 0; i < tabelaItems.Rows.Count; i++)
                {
                    Sessao.DB.TableExecute("Insert into BancoDente (NDente,Estado,Tipo,Cod_Lote) values("+tabelaItems.Rows[i]["NDente"]+",'"+ tabelaItems.Rows[i]["Estado"] + "','"+ tabelaItems.Rows[i]["Tipo"] + "',"+cod_lote+")");
                }
                Gerado = true;
                SalvarBTN.Text = "Concluir";
            }
        }
    }
}
