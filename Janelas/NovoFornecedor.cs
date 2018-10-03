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
    public partial class NovoFornecedor : System.Windows.Forms.Form
    {
        private int Codigo = 0;
        public bool Editar = false;

      
        public NovoFornecedor()
        {
            InitializeComponent();
        }


        public NovoFornecedor(int Codigo)
        {
            InitializeComponent();
            this.Codigo = Codigo;
            CRUD.Read read = new CRUD.Read();
            Models.Fornecedores fornecedores = read.GetFornecedor(Codigo);
            NomeTB.Text = fornecedores.Nome;
            Cnpj_cpfTB.Text = fornecedores.Cnpj_cpf.ToString();
            RuaTB.Text = fornecedores.Cnpj_cpf;
            BairroTB.Text = fornecedores.Bairro;
            NumeroTB.Text = fornecedores.Numero.ToString();
            CidadeTB.Text = fornecedores.Cidade;
            UFTB.Text = fornecedores.Uf;
            CEPTB.Text = fornecedores.Cep;
            TelefoneTB.Text = fornecedores.Telefone.ToString();
            CelularTB.Text = fornecedores.Celular.ToString();
            codigoLB.Text = "Código:" + fornecedores.Codigo;
            codigoLB.Visible = true;
            TituloLB.Text = "Editar Fornecedor";
            Editar = true;
             
        }
         
        private void SalvarBTN_Click(object sender, EventArgs e)
        {
            if (Editar)
            {
                try
                {
                    Sessao.DB.TableExecute("UPDATE Fornecedores set Nome=\""+NomeTB.Text+"\",CNPJ_CPF=\""+Cnpj_cpfTB.Text+"\",Rua=\""+RuaTB.Text+"\",Bairro=\""+BairroTB.Text + "\",Numero="+ NumeroTB.Text + ",Cidade=\""+CidadeTB.Text+"\","+"UF=\""+UFTB.Text+"\",CEP=\""+CEPTB.Text+"\",Telefone=\""+TelefoneTB.Text+"\",Celular=\""+CelularTB.Text+ "\" where Cod_Fornecedor=" + Codigo);
                    MessageBox.Show("Salvo com sucesso!");
                    Close();



                }
                catch (Exception)
                {
                     MessageBox.Show("Algum valor foi considerado inválido!\npreencha todos os campos corretamente");
                }
            }
            else
            {
                try
                {
                    Sessao.DB.TableExecute("INSERT INTO Fornecedores(Nome,CNPJ_CPF,Rua,Bairro,Numero,Cidade,UF,CEP,Telefone,Celular) " +"Values (\"" + NomeTB.Text + "\",\"" + Cnpj_cpfTB.Text + "\",\"" + BairroTB.Text + "\",\"" + RuaTB.Text + "\",\"" + NumeroTB.Text + "\",\"" + CidadeTB.Text + "\",\"" + UFTB.Text + "\",\"" + CEPTB.Text + "\",\"" + TelefoneTB.Text + "\",\"" + CelularTB.Text + "\") ");
                    MessageBox.Show("Salvo com sucesso!");
                    Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Algum valor foi considerado inválido!\npreencha todos os campos corretamente");
                }

            }
        }
    }
}
