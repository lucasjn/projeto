using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdontoSIS.Models
{
    public class Usuario:Model
    {
        private String nome;
        private String senha;
        private int acessLevel;

        public string Nome { get => nome; set => nome = value; }
        public string Senha { get => senha; set => senha = value; }
        public int AcessLevel { get => acessLevel; set => acessLevel = value; }
    }
}
