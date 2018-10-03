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
    public partial class Auditoria : UserControl
    {
        public Auditoria()
        {
            InitializeComponent();
        }

        private void ClearBackColores()
        {
            LoteVLB.BackColor = Color.Transparent;
             
            LoteVLB.ForeColor = Color.White;
            
        }

        private void LoteVLB_Click(object sender, EventArgs e)
        {
            Principal.Controls.Clear();
            Principal.Controls.Add(new Janelas.LotesVencidos());

            ClearBackColores();
            LoteVLB.BackColor = Color.White;
            LoteVLB.ForeColor = Color.Black;
        }

        private void Auditoria_Load(object sender, EventArgs e)
        {

        }
    }
}
