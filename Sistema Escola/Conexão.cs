using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Reflection;
using System.IO;
using System.Windows.Forms;

namespace Sistema_Escola
{
    class Conexão
    {
        public SqlConnection sqlConn { get; set; }

        //--------------------------------------- String de Conexão com SQL ----------------------------------
        public Conexão()
        {
            string connectionString = "server=GABRIEL\\SQLEXPRESS; Database=Escola;Integrated Security=SSPI;";
            sqlConn = new SqlConnection(connectionString);
        }

        //--------------------------------------- Cadastro ---------------------------------------------------
        public void cadastro(string cargo, string usuario, string senha, string nome, int idade, int sexo)
        {
            sqlConn.Open();
            string query = "INSERT INTO " + cargo + "(Usuário, Senha, Nome, Idade, Sexo) ";
            query += "values (@usuario, @senha, @nome, @idade, @sexo)";

            SqlCommand cmd = new SqlCommand(query, sqlConn);
            SqlParameter param_usuario = new SqlParameter();
            param_usuario.ParameterName = "@usuario";
            param_usuario.Value = usuario;
            SqlParameter param_senha = new SqlParameter();
            param_senha.ParameterName = "@senha";
            param_senha.Value = senha;
            SqlParameter param_nome = new SqlParameter();
            param_nome.ParameterName = "@nome";
            param_nome.Value = nome;
            SqlParameter param_idade = new SqlParameter();
            param_idade.ParameterName = "@idade";
            param_idade.Value = idade;
            SqlParameter param_sexo = new SqlParameter();
            param_sexo.ParameterName = "@sexo";
            param_sexo.Value = sexo;

            cmd.Parameters.Add(param_usuario);
            cmd.Parameters.Add(param_senha);
            cmd.Parameters.Add(param_nome);
            cmd.Parameters.Add(param_idade);
            cmd.Parameters.Add(param_sexo);
            cmd.ExecuteNonQuery();

            sqlConn.Close();
        }
        public void cadastro(string cargo, string usuario, string senha, string nome, int idade, int sexo, int materia)
        {
            sqlConn.Open();
            string query = "INSERT INTO " + cargo + " (Usuário, Senha, Nome, Idade, Sexo, Id_Matéria) ";
            query += "values (@usuario, @senha, @nome, @idade, @sexo, @id_materia)";

            SqlCommand cmd = new SqlCommand(query, sqlConn);
            SqlParameter param_usuario = new SqlParameter();
            param_usuario.ParameterName = "@usuario";
            param_usuario.Value = usuario;
            SqlParameter param_senha = new SqlParameter();
            param_senha.ParameterName = "@senha";
            param_senha.Value = senha;
            SqlParameter param_nome = new SqlParameter();
            param_nome.ParameterName = "@nome";
            param_nome.Value = nome;
            SqlParameter param_idade = new SqlParameter();
            param_idade.ParameterName = "@idade";
            param_idade.Value = idade;
            SqlParameter param_sexo = new SqlParameter();
            param_sexo.ParameterName = "@sexo";
            param_sexo.Value = sexo;
            SqlParameter param_materia = new SqlParameter();
            param_materia.ParameterName = "@id_materia";
            param_materia.Value = materia;

            cmd.Parameters.Add(param_usuario);
            cmd.Parameters.Add(param_senha);
            cmd.Parameters.Add(param_nome);
            cmd.Parameters.Add(param_idade);
            cmd.Parameters.Add(param_sexo);
            cmd.Parameters.Add(param_materia);
            cmd.ExecuteNonQuery();

            sqlConn.Close();
        }
        public bool confirmar_usuario(string usuario, string cargo)
        {
            bool result = false;
            sqlConn.Open();
            string query = "SELECT * FROM " + cargo + " WHERE Usuário = @usuario";
            SqlCommand cmd = new SqlCommand(query, sqlConn);

            SqlParameter param_usuario = new SqlParameter();
            param_usuario.ParameterName = "@usuario";
            param_usuario.Value = usuario;


            cmd.Parameters.Add(param_usuario);
            SqlDataReader Reader = cmd.ExecuteReader();

            if (Reader.HasRows)
            {
                MessageBox.Show("O Usuário escolhido já existe!");
            }
            else
            {
                result = true;
            }
            sqlConn.Close();
            return result;

        }

        //--------------------------------------- Login ------------------------------------------------------
        public bool login(string usuario, string senha, string cargo)
        {
            bool result = true;

            sqlConn.Open();

            string query = "SELECT * FROM " + cargo + " WHERE Usuário= @usuario AND Senha= @senha";

            SqlCommand cmd = new SqlCommand(query, sqlConn);
            SqlParameter param_usuario = new SqlParameter();
            param_usuario.ParameterName = "@usuario";
            param_usuario.Value = usuario;
            SqlParameter param_senha = new SqlParameter();
            param_senha.ParameterName = "@senha";
            param_senha.Value = senha;

            cmd.Parameters.Add(param_usuario);
            cmd.Parameters.Add(param_senha);
            SqlDataReader dados = cmd.ExecuteReader();
            result = dados.HasRows;

            sqlConn.Close();

            return result;
        }

        //--------------------------------------- Lancamento de Notas ----------------------------------------
        public void Lançamento_Nota(int aluno, int materia, int ano, int bimestre, int nota)
        {
            int bimestrel = Obter_Bimestre(ano, bimestre);
            sqlConn.Open();
            string query = "INSERT INTO Notas (Id_Aluno, Id_Matéria, Id_Bimestre, Nota)";
            query += "values (@aluno, @materia, @bimestre, @nota)";

            SqlCommand cmd = new SqlCommand(query, sqlConn);
            SqlParameter param_aluno = new SqlParameter();
            param_aluno.ParameterName = "@aluno";
            param_aluno.Value = aluno;
            SqlParameter param_materia = new SqlParameter();
            param_materia.ParameterName = "@materia";
            param_materia.Value = materia;
            SqlParameter param_bimestre = new SqlParameter();
            param_bimestre.ParameterName = "@bimestre";
            param_bimestre.Value = bimestrel;
            SqlParameter param_nota = new SqlParameter();
            param_nota.ParameterName = "@nota";
            param_nota.Value = nota;

            cmd.Parameters.Add(param_aluno);
            cmd.Parameters.Add(param_materia);
            cmd.Parameters.Add(param_bimestre);
            cmd.Parameters.Add(param_nota);
            cmd.ExecuteNonQuery();

            sqlConn.Close();
        }
        public int Obter_Bimestre(int ano, int bimestre)
        {
            sqlConn.Open();

            string query = "SELECT Id FROM Bimestre WHERE Ano = @ano AND Bimestre = @bimestre";

            SqlCommand cmd = new SqlCommand(query, sqlConn);
            SqlParameter param_ano = new SqlParameter();
            param_ano.ParameterName = "@ano";
            param_ano.Value = ano;
            SqlParameter param_bimestre = new SqlParameter();
            param_bimestre.ParameterName = "@bimestre";
            param_bimestre.Value = bimestre;

            cmd.Parameters.Add(param_ano);
            cmd.Parameters.Add(param_bimestre);
            SqlDataReader reader = cmd.ExecuteReader();

            int x = 0;

            while (reader.Read())
            {
                x = Convert.ToInt32(reader["Id"]);
            }

            sqlConn.Close();

            return x;
        }

        //--------------------------------------- emissão de boletim -----------------------------------------
        public void Emitir_Boletim(int id_aluno, int ano, int bimestre)
        {

            string nome_aluno;
            int nota;
            string materia;

            sqlConn.Open();
            string query = "SELECT Nome FROM Aluno WHERE Id = @aluno";

            SqlCommand cmd = new SqlCommand(query, sqlConn);
            SqlParameter param_aluno = new SqlParameter();
            param_aluno.ParameterName = "@aluno";
            param_aluno.Value = id_aluno;

            cmd.Parameters.Add(param_aluno);
            SqlDataReader Reader = cmd.ExecuteReader();
            StreamWriter writer = new StreamWriter(@"C:\Users\gribe\source\boletim.txt", true);

            while (Reader.Read())
            {
                nome_aluno = Reader["Nome"].ToString();
                writer.WriteLine(nome_aluno);
                writer.WriteLine(ano + "     " + bimestre);
            }
            sqlConn.Close();

            sqlConn.Open();

            string query2 = "SELECT Id_Matéria, Nota FROM Notas WHERE Id_Aluno = @aluno ";

            SqlCommand cmd2 = new SqlCommand(query2, sqlConn);
            SqlParameter param_aluno2 = new SqlParameter();
            param_aluno2.ParameterName = "@aluno";
            param_aluno2.Value = id_aluno;

            cmd2.Parameters.Add(param_aluno2);

            SqlDataReader Reader2 = cmd2.ExecuteReader();

            while (Reader2.Read())
            {
                materia = Reader2["Id_Matéria"].ToString();
                if (materia == "1")
                {
                    materia = "Português";
                }
                else if (materia == "2")
                {
                    materia = "Matemática";
                }
                else if (materia == "3")
                {
                    materia = "Biologia";
                }
                else if (materia == "4")
                {
                    materia = "Geografia";
                }
                else if (materia == "5")
                {
                    materia = "História";
                }
                nota = Convert.ToInt32(Reader2["Nota"]);
                writer.WriteLine(materia + "    " + nota);
            }
            writer.Close();
            sqlConn.Close();
        }
        public bool confirmaçao_aluno(int id_aluno)
        {
            bool result = false;
            sqlConn.Open();
            string query = "SELECT * FROM Aluno WHERE Id = @aluno";

            SqlCommand cmd = new SqlCommand(query, sqlConn);
            SqlParameter param_aluno = new SqlParameter();
            param_aluno.ParameterName = "@aluno";
            param_aluno.Value = id_aluno;

            cmd.Parameters.Add(param_aluno);

            SqlDataReader Reader = cmd.ExecuteReader();

            if (Reader.HasRows)
            {
                result = true;
            }
            else
            {
                MessageBox.Show("Esse Aluno não existe!");
            }
            sqlConn.Close();
            return result;

        }

        //--------------------------------------- emissão de boleto ------------------------------------------
        public void Pagar_Boleto(string numero_boleto, double valor, int id_aluno, int ano, int bimestre)
        {
            int bimestrel = Obter_Bimestre(ano, bimestre);
            sqlConn.Open();
            string query = "INSERT INTO Pagamento (Id_Aluno, Id_Bimestre, Número_Boleto, Valor)";
            query += "values(@id_aluno, @id_bimestre, @numero_boleto, @valor)";

            SqlCommand cmd = new SqlCommand(query, sqlConn);
            SqlParameter param_aluno = new SqlParameter();
            param_aluno.ParameterName = "@id_aluno";
            param_aluno.Value = id_aluno;
            SqlParameter param_bimestre = new SqlParameter();
            param_bimestre.ParameterName = "@id_bimestre";
            param_bimestre.Value = bimestrel;
            SqlParameter param_numeroboleto = new SqlParameter();
            param_numeroboleto.ParameterName = "@numero_boleto";
            param_numeroboleto.Value = numero_boleto;
            SqlParameter param_valor = new SqlParameter();
            param_valor.ParameterName = "@valor";
            param_valor.Value = valor;

            cmd.Parameters.Add(param_aluno);
            cmd.Parameters.Add(param_bimestre);
            cmd.Parameters.Add(param_numeroboleto);
            cmd.Parameters.Add(param_valor);
            cmd.ExecuteNonQuery();

            sqlConn.Close();
        }

        //--------------------------------------- Controle de Frequencia aluno ---------------------------------
        public void controle_frequencia(int id_aluno, string ano, string mes, string dia)
        {
            string id_dia = obter_dia(ano, mes, dia);
            sqlConn.Open();
            string query = "INSERT INTO Frequencia (Id_Aluno, Id_Dia) VALUES (@aluno, @dia)";

            SqlCommand cmd = new SqlCommand(query, sqlConn);
            SqlParameter param_aluno = new SqlParameter();
            param_aluno.ParameterName = "@aluno";
            param_aluno.Value = id_aluno;
            SqlParameter param_dia = new SqlParameter();
            param_dia.ParameterName = "@dia";
            param_dia.Value = id_dia;

            cmd.Parameters.Add(param_aluno);
            cmd.Parameters.Add(param_dia);
            cmd.ExecuteNonQuery();

            sqlConn.Close();
        }
        public string obter_dia(string ano, string mes, string dia)
        {
            string id_dia = ano + "-" + mes + "-" + dia;
            sqlConn.Open();
            string query = "SELECT Id FROM Dias_Presença WHERE Dia = @dia";

            SqlCommand cmd = new SqlCommand(query, sqlConn);
            SqlParameter param_dia = new SqlParameter();
            param_dia.ParameterName = "@dia";
            param_dia.Value = id_dia;

            cmd.Parameters.Add(param_dia);
            SqlDataReader Reader = cmd.ExecuteReader();

            while (Reader.Read())
            {
                id_dia = Reader["Id"].ToString();
            }
            sqlConn.Close();
            return id_dia;
        }

        //--------------------------------------- Controle de fluxo de caixa -----------------------------------
        public void controle_fluxo(int ano, int bimestre)
        {
            double valor = 0;
            int bimestrel = Obter_Bimestre(ano, bimestre);
            sqlConn.Open();
            string query = "SELECT Valor FROM Pagamento WHERE Id_Bimestre = @bimestre";

            SqlCommand cmd = new SqlCommand(query, sqlConn);
            SqlParameter param_bimestre = new SqlParameter();
            param_bimestre.ParameterName = "@bimestre";
            param_bimestre.Value = bimestrel;

            cmd.Parameters.Add(param_bimestre);
            SqlDataReader Reader = cmd.ExecuteReader();

            if (Reader.HasRows)
            {
                while (Reader.Read())
                {
                    valor = valor + Convert.ToDouble(Reader["valor"]);
                }
                MessageBox.Show("O Lucro total do " + bimestre + " biméstre do ano de " + ano + " é " + valor);
            }
            else
            {
                MessageBox.Show("Ano não esperado!");
            }
        }

        //--------------------------------------- Controle de inadimplencia ------------------------------------
        public void controle_inadimplencia(int ano, int bimestre)
        {
            int inadimplencia = 0;
            int bimestrel = Obter_Bimestre(ano, bimestre);
            sqlConn.Open();
            string query = "SELECT Id_Aluno FROM Pagamento WHERE Id_Bimestre = @bimestre";

            SqlCommand cmd = new SqlCommand(query, sqlConn);
            SqlParameter param_bimestre = new SqlParameter();
            param_bimestre.ParameterName = "@bimestre";
            param_bimestre.Value = bimestrel;
            StreamWriter writer = new StreamWriter(@"C:\Users\gribe\source\Controle d inadimplencia.txt", true);

            cmd.Parameters.Add(param_bimestre);
            SqlDataReader Reader = cmd.ExecuteReader();

            while (Reader.Read())
            {
                inadimplencia = Convert.ToInt32(Reader["Id_Aluno"]);
                writer.WriteLine(inadimplencia);
            }
            writer.Close();
            sqlConn.Close();
        }

        //--------------------------------------- Controle de cancelamento de matricula ------------------------
        public void cancelamento_matricula(int id, string cargo)
        {
            sqlConn.Open();
            string query = "DELETE FROM " + cargo + " WHERE Id = @id";

            SqlCommand cmd = new SqlCommand(query, sqlConn);
            SqlParameter param_id = new SqlParameter();
            param_id.ParameterName = "@id";
            param_id.Value = id;

            cmd.Parameters.Add(param_id);
            cmd.ExecuteNonQuery();
        }

        //--------------------------------------- Avaliação do aluno/professor ---------------------------------
        public void avaliaçao_aluno_professor(string cargo, int id_aluno, int id_professor, int ano, int bimestre, int nota)
        {
            int bimestrel = Obter_Bimestre(ano, bimestre);
            string query = "";
            if (cargo == "Aluno")
            {
                query = "INSERT INTO Aluno_Avaliação (Id_Aluno, Id_Professor, Id_Bimestre, Nota)";
                query += "VALUES (@aluno, @professor, @bimestre, @nota)";
            }
            else if (cargo == "Professor")
            {
                query = "INSERT INTO Professor_Avaliação (Id_Professor, Id_Aluno, Id_Bimestre, Nota)";
                query += "VALUES (@aluno, @professor, @bimestre, @nota)";
            }
            sqlConn.Open();
            SqlCommand cmd = new SqlCommand(query, sqlConn);
            SqlParameter param_aluno = new SqlParameter();
            param_aluno.ParameterName = "@aluno";
            param_aluno.Value = id_aluno;
            SqlParameter param_professor = new SqlParameter();
            param_professor.ParameterName = "@professor";
            param_professor.Value = id_professor;
            SqlParameter param_bimestre = new SqlParameter();
            param_bimestre.ParameterName = "@bimestre";
            param_bimestre.Value = bimestrel;
            SqlParameter param_nota = new SqlParameter();
            param_nota.ParameterName = "@nota";
            param_nota.Value = nota;

            cmd.Parameters.Add(param_aluno);
            cmd.Parameters.Add(param_professor);
            cmd.Parameters.Add(param_bimestre);
            cmd.Parameters.Add(param_nota);
            cmd.ExecuteNonQuery();
        }
    }
        




}
