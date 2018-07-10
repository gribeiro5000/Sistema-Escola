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
    public partial class Emissão_de_boletim : Form
    {
        Conexão c = new Conexão();
        Boletim b = new Boletim();
        public Emissão_de_boletim()
        {
            InitializeComponent();
        }

        private void botão_emitirboletim_Click(object sender, EventArgs e)
        {
            b.Id_Aluno = Convert.ToInt32(texto_id_aluno.Text);
            b.Ano = Convert.ToInt32(texto_ano.Text);
            b.Bimestre = Convert.ToInt32(texto_bimestre.Text);

            if (c.confirmaçao_aluno(b.Id_Aluno) == true)
            {
                c.Emitir_Boletim(b.Id_Aluno, b.Ano, b.Bimestre);
                Close();
                MessageBox.Show("Boletim gerado com sucesso");
                Homepage_Prof home_prof = new Homepage_Prof();
                home_prof.Show();
            }
        }
    }
}
