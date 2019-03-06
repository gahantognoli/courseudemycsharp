using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Substituir
{
    class Program
    {
        static void Main(string[] args)
        {
            string texto = "Olá amigos do João";

            Console.WriteLine(texto);
            string textoSub = texto.Replace("João", "Josias");
            Console.WriteLine(textoSub);
            Console.WriteLine(texto);

            Console.ReadKey();
        }
    }
}
