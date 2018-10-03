using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdontoSIS.Models
{
    public class Dente:Model
    {
        private String nome;
        private int nDente;

        public string Nome { get => nome; set => nome = value; }
        public int NDente { get => nDente; set => nDente = value; }
    }
}
