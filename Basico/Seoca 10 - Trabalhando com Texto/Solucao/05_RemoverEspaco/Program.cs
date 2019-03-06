using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_RemoverEspaco
{
    class Program
    {
        static void Main(string[] args)
        {
            string texto = "       Olá amigos do Gabriel            ";

            Console.WriteLine("Inicio: " + texto.TrimStart());
            Console.WriteLine("Inicio: " + texto.TrimStart().Length);

            Console.WriteLine("Final: " + texto.TrimEnd());
            Console.WriteLine("Final: " + texto.TrimEnd().Length);

            Console.WriteLine("Tudo: " + texto.Trim());
            Console.WriteLine("Tudo: " + texto.Trim().Length);

            Console.ReadKey();
        }
    }
}
