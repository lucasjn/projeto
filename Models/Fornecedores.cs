using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdontoSIS.Models
{
    public class Fornecedores:Model
    {
        private String nome;
        private String cnpj_cpf;
        private String telefone;
        private String celular;
        private String cep;
        private String rua;
        private String bairro;
        private int numero;
        private String cidade;
        private String uf;

        public string Nome { get => nome; set => nome = value; }
        public string Cnpj_cpf { get => cnpj_cpf; set => cnpj_cpf = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string Celular { get => celular; set => celular = value; }
        public string Cep { get => cep; set => cep = value; }
        public string Rua { get => rua; set => rua = value; }
        public string Bairro { get => bairro; set => bairro = value; }
        public int Numero { get => numero; set => numero = value; }
        public string Cidade { get => cidade; set => cidade = value; }
        public string Uf { get => uf; set => uf = value; }
    }
}
