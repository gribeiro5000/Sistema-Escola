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
    public partial class Cadastro_Aluno : Form
    {
        Usuário _usuario = new Usuário();
        Conexão c = new Conexão();
        public Cadastro_Aluno()
        {
            InitializeComponent();
        }


        private void bt_cadastrar_Click(object sender, EventArgs e)
        {
            _usuario.Cargo = "Aluno";
            _usuario.Usuario = textbox_usuario.Text;
            _usuario.Senha = textbox_senha.Text;
            _usuario.Nome = textbox_nome.Text;
            _usuario.Idade = Convert.ToInt32(textbox_idade.Text);
            if (combobox_sexo.SelectedItem.ToString() == "Masculino")
            {
                _usuario.Sexo = 1;
            }
            if (combobox_sexo.SelectedItem.ToString() == "Feminino")
            {
                _usuario.Sexo = 2;
            }
            if (c.confirmar_usuario(_usuario.Usuario, _usuario.Cargo) == true)
            {
                c.cadastro(_usuario.Cargo, _usuario.Usuario, _usuario.Senha, _usuario.Nome, _usuario.Idade, _usuario.Sexo);
                Close();
                MessageBox.Show("Usuário cadastrado com sucesso!");
                Login_Aluno loginaluno = new Login_Aluno();
                loginaluno.Show();
            }
        }
    }
}
