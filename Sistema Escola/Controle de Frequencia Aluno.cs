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
    public partial class Controle_de_Frequencia_Aluno : Form
    {
        Conexão c = new Conexão();
        public Controle_de_Frequencia_Aluno()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (c.confirmaçao_aluno(Convert.ToInt32(texto_id_aluno.Text)) == true)
            {
                c.controle_frequencia(Convert.ToInt32(texto_id_aluno.Text), texto_ano.Text, texto_mes.Text, texto_dia.Text);
                Close();
                MessageBox.Show("Presença registrada com sucesso!");
                Homepage_Prof home_prof = new Homepage_Prof();
                home_prof.Show();
            }
        }
    }
}
