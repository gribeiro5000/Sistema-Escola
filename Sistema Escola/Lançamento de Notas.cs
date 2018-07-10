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
    public partial class Lançamento_de_Notas : Form
    {
        LançamentoNota _ln = new LançamentoNota();
        Conexão c = new Conexão();
        public Lançamento_de_Notas()
        {
            InitializeComponent();
        }

        private void botão_lançamento_Click(object sender, EventArgs e)
        {
            _ln.Id_Aluno = Convert.ToInt32(texto_idaluno.Text);
            _ln.Ano = Convert.ToInt32(texto_ano.Text);
            _ln.Bimestre = Convert.ToInt32(texto_bimestre.Text);
            _ln.Nota = Convert.ToInt32(texto_nota.Text);
            switch (combobox_materia.SelectedItem)
            {
                case "Português":
                    _ln.Materia = 1;
                    break;
                case "Matemática":
                    _ln.Materia = 2;
                    break;
                case "Biologia":
                    _ln.Materia = 3;
                    break;
                case "Geografia":
                    _ln.Materia = 4;
                    break;
                case "História":
                    _ln.Materia = 5;
                    break;

            }
            if (_ln.Nota > 10)
            {
                MessageBox.Show("A nota deve ser menor ou igual a 10!");
            }
            else
            {
                if (c.confirmaçao_aluno(_ln.Id_Aluno) == true)
                {
                    c.Lançamento_Nota(_ln.Id_Aluno, _ln.Materia, _ln.Ano, _ln.Bimestre, _ln.Nota);
                    Close();
                    MessageBox.Show("Nota inserida com sucesso!");
                    Homepage_Prof home_prof = new Homepage_Prof();
                    home_prof.Show();
                }
            }
        }
    }
}
