using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploTeste2
{
    class Program
    {
        static void Main(string[] args)
        {
            ITributavel conta = new Conta();
            TesteInterface(conta);
        }

        public static void TesteInterface(ITributavel conta)
        {
            var conta2 = conta;
            if (conta is IRecompensavel)
            {
                (conta as Conta).Recompensavel();
            }
        }

    }
}
