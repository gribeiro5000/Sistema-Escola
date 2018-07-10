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
    public partial class Homepage_Aluno : Form
    {
        public Homepage_Aluno()
        {
            InitializeComponent();
        }

        private void bt_emissaoboleto_Click(object sender, EventArgs e)
        {
            Hide();
            Emissão_de_Boleto emissaoboleto = new Emissão_de_Boleto();
            emissaoboleto.Show();
        }

        private void avaliaçao_professor_Click(object sender, EventArgs e)
        {
            Hide();
            Avaliação_do_Professor avaliaçao = new Avaliação_do_Professor();
            avaliaçao.Show();
        }
    }
}
