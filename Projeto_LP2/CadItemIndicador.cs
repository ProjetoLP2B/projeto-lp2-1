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
    public partial class CadItemIndicador : Form
    {
        public CadItemIndicador()
        {
            InitializeComponent();
        }

        private void ok_Click(object sender, EventArgs e)
        {
            this.Dispose();
            var lol = new Atividades_Usuarios();

            lol.ShowDialog();
        }

        private void cancelar_Click(object sender, EventArgs e)
        {

        }
    }
}
