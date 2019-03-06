using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_IntroducaoArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Começa em 0.
            string[] nomes = { "João da Silva", "José da Costa", "Maria da Costa", "Gabriel Antognoli" };

            Console.WriteLine("Nome de N3: " + nomes[3]);

            nomes[3] = "Gazim"; //Alterando valor de indice numero 3.
            Console.WriteLine("Nome de N3: " + nomes[3]);
            Console.ReadKey();
        }
    }
}
