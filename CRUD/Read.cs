using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OdontoSIS.Models;

namespace OdontoSIS.CRUD
{
    public class Read
    {
        private Conexao.DB db = new Conexao.DB();

        public Cliente GetCliente(int Codigo)
        {
            Cliente cliente = new Cliente();
            DataTable clienteTable = db.TableExecute("select * from Clientes where Cod_Cliente="+Codigo);

            cliente.Codigo = Codigo;
            cliente.Nome = (string)clienteTable.Rows[0]["Nome"];
            cliente.Matricula = (int)clienteTable.Rows[0]["Matricula"];
            cliente.Cpf = (int)clienteTable.Rows[0]["Cpf"];
            cliente.Rua = (string)clienteTable.Rows[0]["Rua"];
            cliente.Bairro = (string)clienteTable.Rows[0]["Bairro"];
            cliente.Numero = (int)clienteTable.Rows[0]["Numero"];
            cliente.Cep = (int)clienteTable.Rows[0]["CEP"];
            cliente.Cidade = (string)clienteTable.Rows[0]["Cidade"];
            cliente.Uf = (string)clienteTable.Rows[0]["UF"];
            cliente.Telefone = (string)clienteTable.Rows[0]["Telefone"];
            cliente.Celular = (string)clienteTable.Rows[0]["Celular"];


            return cliente;
        }
        public Fornecedores GetFornecedor(int Codigo)
        {
            Fornecedores fornecedor = new Fornecedores();
            DataTable clienteTable = db.TableExecute("select * from Fornecedores where Cod_Fornecedor=" + Codigo);

            fornecedor.Codigo = Codigo;
            fornecedor.Nome = (string)clienteTable.Rows[0]["Nome"];
            fornecedor.Cnpj_cpf = clienteTable.Rows[0]["cnpj_cpf"].ToString();
            fornecedor.Rua = (string)clienteTable.Rows[0]["Rua"];
            fornecedor.Bairro = (string)clienteTable.Rows[0]["Bairro"];
            fornecedor.Numero = (int)clienteTable.Rows[0]["Numero"];
            fornecedor.Cep = clienteTable.Rows[0]["CEP"].ToString();
            fornecedor.Cidade = (string)clienteTable.Rows[0]["Cidade"];
            fornecedor.Uf = (string)clienteTable.Rows[0]["UF"];
            fornecedor.Telefone = (string)clienteTable.Rows[0]["Telefone"];
            fornecedor.Celular = (string)clienteTable.Rows[0]["Celular"];


            return fornecedor;
        }

        public Dente GetDente(int Codigo)
        {
            Dente dente = new Dente();
            DataTable clienteTable = db.TableExecute("select * from Dentes where NDente=" + Codigo);

            dente.Codigo = Codigo;
            dente.Nome = (string)clienteTable.Rows[0]["Nome"];
            dente.NDente = (int)clienteTable.Rows[0]["NDente"];
            
            return dente;
        }
    }
}
