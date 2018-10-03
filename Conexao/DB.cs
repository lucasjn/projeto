using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdontoSIS.Conexao
{
    public class DB
    {
        private String provider = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source="+Properties.Settings.Default.LocalBanco+";User Id=admin;Password="+Properties.Settings.Default.SenhaBanco+";";

        public DataTable TableExecute(string CodigoSQL)
        {
            DataTable table = new DataTable();
         
                OleDbConnection connection = new OleDbConnection(provider);
                connection.Open();
                OleDbCommand command = new OleDbCommand(CodigoSQL,connection);
                OleDbDataAdapter adapter = new OleDbDataAdapter(command);
                adapter.Fill(table);
                connection.Close();

            return table;
        }

        public DataSet DataSet(string CodigoSQL)
        {
            DataSet dataSet = new DataSet();
            
            try
            {
                OleDbConnection connection = new OleDbConnection(provider);
                connection.Open();
                OleDbCommand command = new OleDbCommand(CodigoSQL);
                OleDbDataAdapter adapter = new OleDbDataAdapter(command);
                adapter.Fill(dataSet);
            }
            catch (Exception)
            {

            }

            return dataSet;
        }
    }
}
