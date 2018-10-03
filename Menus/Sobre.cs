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
    public partial class Sobre : UserControl
    {
        public Sobre()
        {
            InitializeComponent();
        }

        private void ClearBackColores()
        {
            DesenvolvedoresLB.BackColor = Color.Transparent;
            AplicativoLB.BackColor = Color.Transparent;

            DesenvolvedoresLB.ForeColor = Color.White;
            AplicativoLB.ForeColor = Color.White;

        }
        private void DesenvolvedoresLB_Click(object sender, EventArgs e)
        {
            Principal.Controls.Clear();
            Principal.Controls.Add(new Janelas.Desenvolvedores());

            ClearBackColores();
            DesenvolvedoresLB.BackColor = Color.White;
            DesenvolvedoresLB.ForeColor = Color.Black;
        }

        private void AplicativosLB_Click(object sender, EventArgs e)
        {
            Principal.Controls.Clear();
            Principal.Controls.Add(new Janelas.Aplicativo());

            ClearBackColores();
            AplicativoLB.BackColor = Color.White;
            AplicativoLB.ForeColor = Color.Black;
        }

    }
}


