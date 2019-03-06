using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Enumeradores
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exemplo de enumeradores nativos do C#.
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;

            Console.WriteLine("Estado Civil: " + EstadoCivil.Solteiro);
            Console.WriteLine("Estado Civil *Numérico: " + (int)EstadoCivil.Solteiro);

            Console.ReadKey();
        }
    }
}
