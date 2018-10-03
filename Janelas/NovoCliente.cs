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
    public partial class NovoCliente : System.Windows.Forms.Form
    {
        private int Codigo = 0;
        private bool Editar = false;

        public NovoCliente()
        {
            InitializeComponent();
        }

        public NovoCliente(int Codigo)
        {
            InitializeComponent();
            this.Codigo = Codigo;
            CRUD.Read read = new CRUD.Read();
            Models.Cliente cliente = read.GetCliente(Codigo);
            NomeTB.Text = cliente.Nome;
            RuaTB.Text = cliente.Rua;
            CEPTB.Text = cliente.Cep.ToString();
            MatriculaTB.Text = cliente.Matricula.ToString();
            CPFTB.Text = cliente.Cpf.ToString();
            BairroTB.Text = cliente.Bairro;
            NumeroTB.Text = cliente.Numero.ToString();
            CidadeTB.Text = cliente.Cidade;
            UFTB.Text = cliente.Uf;
            TelefoneTB.Text = cliente.Telefone;
            CelularTB.Text = cliente.Celular;
            CodigoLB.Text ="Código: "+cliente.Codigo.ToString();
            CodigoLB.Visible = true;
            TituloLB.Text = "Editar Cliente";
            Editar = true;

             
                
        }

        private void NovoCliente_Load(object sender, EventArgs e)
        {

        }

        private void SalvarBTN_Click(object sender, EventArgs e)
        {
            if (Editar)
            {
                try
                {

                    Sessao.DB.TableExecute("update Clientes set Nome=\"" + NomeTB.Text + "\",Matricula=" + MatriculaTB.Text + ",CPF=" + CPFTB.Text + ",Rua=\"" + RuaTB.Text + "\",Bairro=\"" + BairroTB.Text + "\"," +
                        " Numero=" + NumeroTB.Text + ",Cidade=\"" + CidadeTB.Text + "\",UF=\"" + UFTB.Text + "\",CEP=" + CEPTB.Text + ",Telefone=\"" + TelefoneTB.Text + "\",Celular=\"" + CelularTB.Text + "\" where Cod_Cliente="+Codigo);
                    MessageBox.Show("Dados gravados com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();

                }
                catch (Exception)
                {
                    throw;
                    //MessageBox.Show("Algum valor foi considerado inválido!\npreencha todos os campos corretamente");
                }
            }
            else
            {
                try
                {

                    Sessao.DB.TableExecute("insert into Clientes(Nome,Matricula,CPF,Rua,Bairro,Numero,Cidade,UF,CEP,Telefone,Celular)" +
                        " Values (\"" + NomeTB.Text + "\"," + MatriculaTB.Text + "," + CPFTB.Text + ",\"" + RuaTB.Text + "\",\"" + BairroTB.Text + "\"," + NumeroTB.Text + ",\"" + CidadeTB.Text + "\",\"" + UFTB.Text + "\"," + CEPTB.Text + ",\"" + TelefoneTB.Text + "\",\"" + CelularTB.Text + "\")");
                    MessageBox.Show("Dados gravados com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();

                }
                catch (Exception)
                {
                    throw;
                    //MessageBox.Show("Algum valor foi considerado inválido!\npreencha todos os campos corretamente");
                }
            }
            
        }
    }
}
