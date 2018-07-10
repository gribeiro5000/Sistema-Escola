using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Escola
{
    class Usuário
    {
        int _id;
        string _usuario;
        string _senha;
        string _nome;
        int _idade;
        int _sexo;
        string _cargo;
        int _materia;

        public int Id
        {
            set
            {
                _id = value;
            }
            get
            {
                return _id;
            }
        }
        public string Usuario
        {
            set
            {
                _usuario = value;
            }
            get
            {
                return _usuario;
            }
        }
        public string Senha
        {
            set
            {
                _senha = value;
            }
            get
            {
                return _senha;
            }
        }
        public string Nome
        {
            set
            {
                _nome = value;
            }
            get
            {
                return _nome;
            }
        }
        public int Idade
        {
            set
            {
                _idade = value;
            }
            get
            {
                return _idade;
            }
        }
        public int Sexo
        {
            set
            {
                _sexo = value;
            }
            get
            {
                return _sexo;
            }
        }
        public string Cargo
        {
            set
            {
                _cargo = value;
            }
            get
            {
                return _cargo;
            }
        }
        public int Materia
        {
            set
            {
                _materia = value;
            }
            get
            {
                return _materia;
            }
        }
    }
}
