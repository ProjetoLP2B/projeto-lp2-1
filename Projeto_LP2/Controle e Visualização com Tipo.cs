using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_LP2
{
    public partial class Controle_e_Visualização_com_Tipo : Form
    {
        public Controle_e_Visualização_com_Tipo()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {
            //this.Hide();
            var nova_janela = new CadIndicadores();
            nova_janela.ShowDialog();
        }
    }
}
