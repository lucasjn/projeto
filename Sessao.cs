using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OdontoSIS.Models;

namespace OdontoSIS
{
    public static class Sessao
    {
        private static Models.Usuario usuario;
        public static Conexao.DB DB = new Conexao.DB();

        public static Usuario Usuario { get => usuario; set => usuario = value; }


    }
}
