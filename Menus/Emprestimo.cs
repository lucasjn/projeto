using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OdontoSIS.Menus
{
    public partial class Emprestimo : UserControl
    {
        public Emprestimo()
        {
            InitializeComponent();
        }

        private void ClearBackColores()
        {
            NovoLB.BackColor = Color.Transparent;
            StatusLB.BackColor = Color.Transparent;
            
            NovoLB.ForeColor = Color.White;
            StatusLB.ForeColor = Color.White;
           
        }

       
        private void NovoLB_Click(object sender, EventArgs e)
        {
            Principal.Controls.Clear();
            Principal.Controls.Add(new Janelas.NovoEmprestimo());


            ClearBackColores();
            NovoLB.BackColor = Color.White;
            NovoLB.ForeColor = Color.Black;
        }

        private void StatusLB_Click(object sender, EventArgs e)
        {
            Principal.Controls.Clear();
            Principal.Controls.Add(new Janelas.StatusEmprestimo());

            ClearBackColores();
            StatusLB.BackColor = Color.White;
            StatusLB.ForeColor = Color.Black;
        }
    }
}
