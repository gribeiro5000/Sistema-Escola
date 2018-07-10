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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void bt_professor_Click(object sender, EventArgs e)
        {
            Hide();
            var loginProfessor = new Login_Professor();
            loginProfessor.Show();
        }

        private void bt_aluno_Click(object sender, EventArgs e)
        {
            Hide();
            var loginaluno = new Login_Aluno();
            loginaluno.Show();
        }

        private void bt_atendimento_Click(object sender, EventArgs e)
        {
            Hide();
            var loginatendimento = new Login_Atendimento();
            loginatendimento.Show();
        }
    }
}
