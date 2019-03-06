using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploTeste2
{
    public class Conta : ITributavel, IRecompensavel
    {
        public int Numero { get; set; }
        public double Saldo { get; set; }

        public Conta()
        {
            Saldo = 2000;
        }

        public void Recompensavel()
        {
            Saldo += 1000;
        }

        public void Tributabel()
        {
            Saldo -= 1000;
        }
    }
}
