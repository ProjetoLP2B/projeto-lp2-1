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
    public partial class ControleVisualização : Form
    {
        public ControleVisualização()
        {
            InitializeComponent();
        }


        private void add_Click(object sender, EventArgs e)
        {
            //this.Hide();
            var nova_janela1 = new CadItemIndicador();
            nova_janela1.ShowDialog();
        }
    }
}
