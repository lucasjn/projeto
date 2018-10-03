using OdontoSIS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdontoSIS.CRUD
{
    class Create
    {
        private Conexao.DB db = new Conexao.DB();

        public void InsertCliente(Cliente cliente)
        {
            db.TableExecute("Insert into clientes (nome,noas) values('"+cliente.Nome+"')");



        }
    }
}
