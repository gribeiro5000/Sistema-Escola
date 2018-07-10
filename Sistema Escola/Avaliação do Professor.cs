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
    public partial class Avaliação_do_Professor : Form
    {
        Conexão c = new Conexão();
        public Avaliação_do_Professor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            c.avaliaçao_aluno_professor("Professor", Convert.ToInt32(texto_id_aluno.Text), Convert.ToInt32(texto_id_professor.Text), Convert.ToInt32(texto_ano.Text), Convert.ToInt32(texto_bimestre.Text), Convert.ToInt32(texto_nota.Text));
            Close();
            MessageBox.Show("Avaliação enviada com sucesso!");
            Homepage_Prof home_prof = new Homepage_Prof();
            home_prof.Show();
        }
    }
}
