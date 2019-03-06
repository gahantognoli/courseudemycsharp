using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Lista
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> marcas = new List<string>();

            marcas.Add("Fiat");
            marcas.Add("Chevrolet");
            marcas.Add("Ford");
            marcas.Add("Renault");

            foreach (string marca in marcas)
            {
                Console.WriteLine("Marca: " + marca);
            }

            Console.WriteLine("Primeira Marca: " + marcas[0]);

            Console.ReadKey();

        }
    }
}
