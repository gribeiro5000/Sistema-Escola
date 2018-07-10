using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Escola
{
    class LançamentoNota
    {
        private int _idaluno;
        private int _materia;
        private int _ano;
        private int _bimestre;
        private int _nota;

        public int Id_Aluno
        {
            set
            {
                _idaluno = value;
            }
            get
            {
                return _idaluno;
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
        public int Ano
        {
            set
            {
                _ano = value;
            }
            get
            {
                return _ano;
            }
        }
        public int Bimestre
        {
            set
            {
                _bimestre = value;
            }
            get
            {
                return _bimestre;
            }
        }
        public int Nota
        {
            set
            {
                _nota = value;
            }
            get
            {
                return _nota;
            }
        }


    }
}
