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
    public partial class Homepage_Prof : Form
    {
        public Homepage_Prof()
        {
            InitializeComponent();
        }

        private void bt_lançamentodenotas_Click(object sender, EventArgs e)
        {
            Hide();
            Lançamento_de_Notas lançamentonotas = new Lançamento_de_Notas();
            lançamentonotas.Show();
        }

        private void bt_emissaoboletim_Click(object sender, EventArgs e)
        {
            Hide();
            Emissão_de_boletim emissaoboletim = new Emissão_de_boletim();
            emissaoboletim.Show();
        }

        private void bt_cfa_Click(object sender, EventArgs e)
        {
            Hide();
            Controle_de_Frequencia_Aluno cfa = new Controle_de_Frequencia_Aluno();
            cfa.Show();
        }

        private void avaliaçao_aluno_Click(object sender, EventArgs e)
        {
            Hide();
            Avaliaçao_do_Aluno avaliaçao = new Avaliaçao_do_Aluno();
            avaliaçao.Show();
        }
    }
}
