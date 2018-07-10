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
    public partial class Cancelamento_de_Matricula : Form
    {
        Conexão c = new Conexão();
        public Cancelamento_de_Matricula()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            c.cancelamento_matricula(Convert.ToInt32(texto_id.Text), combobox_cargo.Text);
            Close();
            MessageBox.Show("Cancelamento Concluído!");
            Homepage_Atendimento home_atend = new Homepage_Atendimento();
            home_atend.Show();
        }
    }
}
