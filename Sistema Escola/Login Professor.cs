using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Escola
{
    public partial class Login_Professor : Form
    {
        Conexão c = new Conexão();
        public Login_Professor()
        {
            InitializeComponent();
        }

        private void bt_login_Click(object sender, EventArgs e)
        {
            if (c.login(textbox_usuario.Text, textbox_senha.Text, "Professor") == true)
            {
                Hide();
                var homepageProf = new Homepage_Prof();
                homepageProf.Show();
            }
            else
            {
                MessageBox.Show("Usuário ou Senha não existem!");
            }
        }

        private void bt_cadastro_Click(object sender, EventArgs e)
        {
            Hide();
            var cadastroprofessor = new Cadastro_Professor();
            cadastroprofessor.Show();
        }
    }
}
