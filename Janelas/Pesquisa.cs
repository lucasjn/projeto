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
    public partial class Pesquisa : Form
    {
        public string Selecionado = "";
        private int codigo = 0;
        private BindingSource filtro = new BindingSource();
        private DataTable table = new DataTable();
        private string coluna = "";
        private string coluna_codigo = "";

        public int Codigo { get => codigo; set => codigo = value; }

        public Pesquisa(string tabela,string coluna,string coluna_codigo)
        {
            InitializeComponent();
            table = Sessao.DB.TableExecute("select * from "+tabela);
            filtro.DataSource = table;
            PesquisaDVG.DataSource = filtro;
            this.coluna = coluna;
            this.coluna_codigo = coluna_codigo;
        }
        public Pesquisa(string tabela, string coluna, string coluna_codigo,string[] especificações)
        {
            InitializeComponent();
            string colunas = "";

            for (int i = 0; i < especificações.Length; i++)
            {
                colunas += especificações[i];
                if ((i+1) != especificações.Length)
                {
                    colunas += ",";
                }
            }

            table = Sessao.DB.TableExecute("select "+colunas+" from " + tabela);
            filtro.DataSource = table;
            PesquisaDVG.DataSource = filtro;
            this.coluna = coluna;
            this.coluna_codigo = coluna_codigo;
        }

        private void PesquisaDVG_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Selecionar();

        }

        private void CampoPesquisaTB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Selecionar();
            }
            if (e.KeyCode == Keys.Down)
            {
                filtro.MoveNext();
            }
            if (e.KeyCode == Keys.Up)
            {
                filtro.MovePrevious();

            }
        }

        private void CampoPesquisaTB_TextChanged(object sender, EventArgs e)
        {
            filtro.Filter = coluna+" like '%" + CampoPesquisaTB.Text + "%'";
        }

        private void Selecionar()
        {
            try
            {
                Selecionado = ((DataRowView)filtro.Current).Row[coluna].ToString();
                Codigo = (int)((DataRowView)filtro.Current).Row[coluna_codigo];
                Close();

               

            }
            catch (Exception)
            {
            }
            
        }
    }
}
