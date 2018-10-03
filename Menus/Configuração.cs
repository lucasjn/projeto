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
    public partial class Configuração : UserControl
    {
        public Configuração()
        {
            InitializeComponent();
        }
        
  
    
    private void ClearBackColores()
    {
        LocalizarLB.BackColor = Color.Transparent;
        BackupLB.BackColor = Color.Transparent;
        RestaurarLB.BackColor = Color.Transparent;

        LocalizarLB.ForeColor = Color.White;
        BackupLB.ForeColor = Color.White;
        RestaurarLB.ForeColor = Color.White;
    }
    private void LocalizarLB_Click(object sender, EventArgs e)
        {
            Principal.Controls.Clear();
            Principal.Controls.Add(new Janelas.Localizar());

            ClearBackColores();
            LocalizarLB.BackColor = Color.White;
            LocalizarLB.ForeColor = Color.Black;
        }

        private void BackupLB_Click(object sender, EventArgs e)
        {
            Principal.Controls.Clear();
            Principal.Controls.Add(new Janelas.BackupDeBanco());

            ClearBackColores();
            BackupLB.BackColor = Color.White;
            BackupLB.ForeColor = Color.Black;
        }

        private void RestaurarLB_Click(object sender, EventArgs e)
        {
            Principal.Controls.Clear();
            Principal.Controls.Add(new Janelas.RecuperarBanco());

            ClearBackColores();
            RestaurarLB.BackColor = Color.White;
            RestaurarLB.ForeColor = Color.Black;
        }
    }
}
