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
    public partial class Controle_de_Fluxo_de_Caixa : Form
    {
        Conexão c = new Conexão();
        public Controle_de_Fluxo_de_Caixa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            c.controle_fluxo(Convert.ToInt32(texto_ano.Text), Convert.ToInt32(texto_bimestre.Text));
            Close();
            Homepage_Atendimento home_atendimento = new Homepage_Atendimento();
            home_atendimento.Show();
        }
    }
}
