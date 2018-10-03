using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdontoSIS.CRUD
{
    public class Delete
    {
        public void DeleteCliente(int Codigo)
        {
            Sessao.DB.TableExecute("delete from Clientes where Cod_Cliente=" + Codigo);
        }
    }
}
