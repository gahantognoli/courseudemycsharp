using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_ER_FOREACH
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nomes = { "José", "Maria", "João", "Pedro", "Thiago" };

            Console.WriteLine("------------ Repetição com For -------------");
            for (int i = 0; i < nomes.Length; i++)
            {
                Console.WriteLine("Nomes: " + nomes[i]);
            }

            Console.WriteLine("------------ Repetição com For -------------");
            foreach (string nome in nomes)
            {
                Console.WriteLine("Nomes: " + nome);
            }

            Console.ReadKey();

        }
    }
}
