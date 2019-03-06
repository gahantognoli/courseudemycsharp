using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Estatico
{
    class Program
    {
        static void Main(string[] args)
        {
            //Informações pertencem ao Objeto
            Carro carro = new Carro();
            Carro.QuantidadeCarrosProduzidos = 2; // Propriedade que pertence a classe.

            //Estatico - Informações pertencente a classe.

        }
    }
}
