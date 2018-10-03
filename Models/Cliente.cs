using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdontoSIS.Models
{
    public class Cliente:Model
    {
        private String nome;
        private int matricula;
        private String curso;
        private String disciplina;
        private int cpf;
        private String rua;
        private String bairro;
        private int numero;
        private String cidade;
        private String uf;
        private int cep;
        private String telefone;
        private String celular;

        public string Nome { get => nome; set => nome = value; }
        public int Matricula { get => matricula; set => matricula = value; }
        public string Curso { get => curso; set => curso = value; }
        public string Disciplina { get => disciplina; set => disciplina = value; }
        public int Cpf { get => cpf; set => cpf = value; }
        public string Rua { get => rua; set => rua = value; }
        public string Bairro { get => bairro; set => bairro = value; }
        public int Numero { get => numero; set => numero = value; }
        public string Cidade { get => cidade; set => cidade = value; }
        public string Uf { get => uf; set => uf = value; }
        public int Cep { get => cep; set => cep = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string Celular { get => celular; set => celular = value; }
    }
}
