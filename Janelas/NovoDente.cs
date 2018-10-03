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
    public partial class NovoDente : Form
    {
        private int qt = 1;
        DataTable table = new DataTable();
        public NovoDente()
        {
            InitializeComponent();
            CarregarEstadoTipo();
            QtTB.Text = qt.ToString();
        }

        private void NumeroDenteTB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (NumeroDenteTB.Text.Length > 0)
                {
                    CRUD.Read read = new CRUD.Read();
                    var dente = read.GetDente(Convert.ToInt32(NumeroDenteTB.Text));
                    NumeroDenteTB.Text = dente.NDente.ToString();
                    NomeDenteTB.Text = dente.Nome;
                    ListaEstadosLB.Focus();
                }
                else
                {
                    string[] colunas = new string[2];
                    colunas[0] = "NDente";
                    colunas[1] = "Nome";

                    var pesquisa = new Pesquisa("Dentes", "Nome", "NDente", colunas);
                    pesquisa.ShowDialog();
                    if (pesquisa.Codigo > 0)
                    {
                        NumeroDenteTB.Text = pesquisa.Codigo.ToString();
                        NomeDenteTB.Text = pesquisa.Selecionado;
                        ListaEstadosLB.Focus();
                    }
                }
            }
        }

        private void CarregarEstadoTipo()
        {
            try
            {
              
                table = Sessao.DB.TableExecute("SELECT * FROM estados");
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    ListaEstadosLB.Items.Add(table.Rows[i]["Estado"].ToString());
                }
               
            }
            catch (Exception)
            {


            }


        }

        private void ListaEstadosLB_DoubleClick(object sender, EventArgs e)
        {
            if (ListaEstadosLB.SelectedIndex > -1)
            {
                int index = ListaEstadosLB.SelectedIndex;
                EstadosLB.Items.Add(ListaEstadosLB.Items[index]);
                ListaEstadosLB.Items.RemoveAt(index);
                EstadosLB.Sorted = true;
            }
        }

        private void EstadosLB_DoubleClick(object sender, EventArgs e)
        {
            if (EstadosLB.SelectedIndex > -1)
            {
                int index = EstadosLB.SelectedIndex;
                ListaEstadosLB.Items.Add(EstadosLB.Items[index]);
                EstadosLB.Items.RemoveAt(index);
                EstadosLB.Sorted = true;
            }
        }

        private void QtTB_Leave(object sender, EventArgs e)
        {
                try
                {
                if (int.Parse(QtTB.Text) > 0)
                    qt = int.Parse(QtTB.Text);
                else
                    QtTB.Text = qt.ToString();
                    ListaEstadosLB.Focus();
                }
                catch (Exception)
                {
                QtTB.Text = qt.ToString();
                }
            
        }

        private void QtTB_Enter(object sender, EventArgs e)
        {
          
        }

        private void QtTB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    if (int.Parse(QtTB.Text) > 0)
                        qt = int.Parse(QtTB.Text);
                    else
                        QtTB.Text = qt.ToString();
                    ListaEstadosLB.Focus();
                }
                catch (Exception)
                {

                }
            }

        }
    }
}
