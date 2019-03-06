using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Construtor
{
    class Pessoa
    {
        public string Nome;
        public string Sexo;
        public DateTime DataNascimento;
        public double PosicaoX, PosicaoY;

        public Pessoa(string nome, string sexo, DateTime dataNascimento, double X, double Y)
        {
            Nome = nome;
            Sexo = sexo;
            DataNascimento = dataNascimento;
            PosicaoX = X;
            PosicaoY = Y;
        }
    }
}
