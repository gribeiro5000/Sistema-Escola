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
    public partial class Homepage_Atendimento : Form
    {
        public Homepage_Atendimento()
        {
            InitializeComponent();
        }

        private void bt_cfc_Click(object sender, EventArgs e)
        {
            Hide();
            Controle_de_Fluxo_de_Caixa cfc = new Controle_de_Fluxo_de_Caixa();
            cfc.Show();
        }

        private void bt_controleinadimplencia_Click(object sender, EventArgs e)
        {
            Hide();
            Controle_de_inadimplencia cont_inadimplencia = new Controle_de_inadimplencia();
            cont_inadimplencia.Show();
        }

        private void bt_controlematricula_Click(object sender, EventArgs e)
        {
            Hide();
            Cancelamento_de_Matricula cancelamento = new Cancelamento_de_Matricula();
            cancelamento.Show();
        }
    }
}
