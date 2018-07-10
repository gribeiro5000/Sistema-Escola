using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Escola
{
    class boleto
    {
        int _id_aluno;
        int _ano;
        int _bimestre;

        public int Id_Aluno
        {
            set
            {
                _id_aluno = value;
            }
            get
            {
                return _id_aluno;
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
    }
}
