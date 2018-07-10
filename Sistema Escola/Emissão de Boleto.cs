using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Escola
{
    
    public partial class Emissão_de_Boleto : Form
    {
        boleto _boleto = new boleto();
        Conexão c = new Conexão();
        public Emissão_de_Boleto()
        {
            InitializeComponent();
        }

        private void botao_emitirboleto_Click(object sender, EventArgs e)
        {
            _boleto.Id_Aluno = Convert.ToInt32(texto_id_aluno.Text);
            _boleto.Ano = Convert.ToInt32(texto_ano.Text);
            _boleto.Bimestre = Convert.ToInt32(texto_bimestre.Text);

            if (c.confirmaçao_aluno(_boleto.Id_Aluno) == true)
            {
                Guid g = Guid.NewGuid();
                texto_numeroboleto.Text = g.ToString();
                texto_valor.Text = "205.99";
            }
        }

        private void botao_pagar_Click(object sender, EventArgs e)
        {
            if (texto_numeroboleto.Text == "" || texto_valor.Text == "")
            {
                MessageBox.Show("Número do código de barras invalido!");
            }
            else
            {
                c.Pagar_Boleto(texto_numeroboleto.Text, Convert.ToDouble(texto_valor.Text, CultureInfo.InvariantCulture), _boleto.Id_Aluno, _boleto.Ano, _boleto.Bimestre);
                Close();
                MessageBox.Show("Boleto Pago!");
                Homepage_Aluno home_aluno = new Homepage_Aluno();
                home_aluno.Show();
            }
        }
    }
}
