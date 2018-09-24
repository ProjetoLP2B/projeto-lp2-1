using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.Common;

namespace Projeto_LP2
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        


        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void enter_Click(object sender, EventArgs e)
        {
            var login = "1";
            var senha = "1";

            if(userCampo.Text == login && senhaCampo.Text == senha)
            {
                this.Hide();
                var lol = new Atividades_Usuarios();
                lol.ShowDialog();
 
            }
            else
            {
                erroLogin.Show();
            }


            
            
        }

        private void cadastro_Click(object sender, EventArgs e)
        {
            this.Hide();
            var nova_janela = new Cadastro();
            nova_janela.ShowDialog();

        }

        private void sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
