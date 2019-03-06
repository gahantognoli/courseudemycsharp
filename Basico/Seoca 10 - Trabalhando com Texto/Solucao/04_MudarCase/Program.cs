
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_MudarCase
{
    class Program
    {
        static void Main(string[] args)
        {
            string texto = "Olá amiguinhos! Feliz ano novo";

            Console.WriteLine(texto.ToLower()); // Minusculo.
            Console.WriteLine(texto.ToUpper()); // Maiusculo.

            Console.ReadKey();
        }
    }
}
