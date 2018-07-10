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
    public partial class Cadastro_Professor : Form
    {
        Usuário _usuario = new Usuário();
        Conexão c = new Conexão();
        public Cadastro_Professor()
        {
            InitializeComponent();
        }

        private void bt_cadastrar_Click(object sender, EventArgs e)
        {
            _usuario.Cargo = "Professor";
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
            switch (combobox_materia.SelectedItem)
            {
                case "Português":
                    _usuario.Materia = 1;
                    break;
                case "Matemática":
                    _usuario.Materia = 2;
                    break;
                case "Biologia":
                    _usuario.Materia = 3;
                    break;
                case "Geografia":
                    _usuario.Materia = 4;
                    break;
                case "História":
                    _usuario.Materia = 5;
                    break;
            }
            if (c.confirmar_usuario(_usuario.Usuario, _usuario.Cargo) == true)
            {
                c.cadastro(_usuario.Cargo, _usuario.Usuario, _usuario.Senha, _usuario.Nome, _usuario.Idade, _usuario.Sexo, _usuario.Materia);
                Close();
                MessageBox.Show("Usuário cadastrado com sucesso!");
                Login_Professor loginprofessor = new Login_Professor();
                loginprofessor.Show();
            }
        }
    }
}
