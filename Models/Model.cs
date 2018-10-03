using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdontoSIS.Models
{
    public abstract class Model
    {
        private int codigo;

        public int Codigo { get => codigo; set => codigo = value; }
    }
}
