using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OdontoSIS.Models;

namespace OdontoSIS.CRUD
{
    public class Update
    {
        public void SetCliente(Cliente cliente)
        {

            Sessao.DB.TableExecute("Update ");

      
        }
    }
}
