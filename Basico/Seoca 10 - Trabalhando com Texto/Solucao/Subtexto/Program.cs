using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subtexto
{
    class Program
    {
        static void Main(string[] args)
        {
            string texto = "Olá a todos. Desejo feliz ano novo!";

            string frase = texto.Substring(13);
            string palavra = texto.Substring(13, 6);

            Console.WriteLine("Frase: " + frase);
            Console.WriteLine("Palavra: " + palavra);

            Console.ReadKey();
        }
    }
}
