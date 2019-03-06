using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerificarTextoExist
{
    class Program
    {
        static void Main(string[] args)
        {
            string texto = "Olá Amigos do Gabriel Antonio Xavier Antognoli!";

            Console.WriteLine("Verificar existencia no inicio: " + texto.StartsWith("Olá"));

            Console.WriteLine("Verificar existencia no fim: " + texto.EndsWith("!"));

            Console.WriteLine("Verificar existencia no texto: " + texto.Contains("Antonio"));

            Console.ReadKey();

        }
    }
}
