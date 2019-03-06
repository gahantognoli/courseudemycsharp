using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_FormartarString
{
    class Program
    {
        static void Main(string[] args)
        {
            //Formas de formatação.

            string nome = "Gabriel Antognoli", ano = "2018";

            string texto = string.Format("Olá {0} Feliz {1}!", nome, ano);
            Console.WriteLine(texto);

            Console.WriteLine("Olá {0} Feliz {1}!", nome, ano);

            //A partir do C# 6.0
            Console.WriteLine($"Olá {nome} Feliz {ano}!");

            Console.ReadKey();
        }
    }
}
