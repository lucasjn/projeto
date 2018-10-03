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
    public partial class Devolucao : UserControl
    {
        public Devolucao()
        {
            InitializeComponent();
        }
        private void ClearBackColores()
        {
            NovoLB.BackColor = Color.Transparent;
            AnaliseLB.BackColor = Color.Transparent;
             
            NovoLB.ForeColor = Color.White;
            AnaliseLB.ForeColor = Color.White;
         
        }
        private void NovoLB_Click(object sender, EventArgs e)
        {
            Principal.Controls.Clear();
            Principal.Controls.Add(new Janelas.NovoDevolucao());

            ClearBackColores();
            NovoLB.BackColor = Color.White;
            NovoLB.ForeColor = Color.Black;
        }

        private void AnaliseLB_Click(object sender, EventArgs e)
        {
            Principal.Controls.Clear();
            Principal.Controls.Add(new Janelas.AnaliseDevolucao());

            ClearBackColores();
            AnaliseLB.BackColor = Color.White;
            AnaliseLB.ForeColor = Color.Black;
        }
    }
}
