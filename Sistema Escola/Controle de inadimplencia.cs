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
    public partial class Controle_de_inadimplencia : Form
    {
        Conexão c = new Conexão();
        public Controle_de_inadimplencia()
        {
            InitializeComponent();
        }

        private void botao_inadimplencia_Click(object sender, EventArgs e)
        {
            c.controle_inadimplencia(Convert.ToInt32(texto_ano.Text), Convert.ToInt32(texto_bimestre.Text));
            Close();
            MessageBox.Show("relatório salvo no bloco de notas C:/Users/gribe/source/Controle d inadimplencia.txt");
            Homepage_Atendimento home_atend = new Homepage_Atendimento();
            home_atend.Show();
        }
    }
}
