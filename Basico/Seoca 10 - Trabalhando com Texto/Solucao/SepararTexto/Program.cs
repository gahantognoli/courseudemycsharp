using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SepararTexto
{
    class Program
    {
        static void Main(string[] args)
        {
            string nomes = "Gabriel, Rafael, Otávio, Paulo, Lucas, Cintia, Janaina, Juliana, Elizangela, Edson e Maria.";

            string[] separadores = { ", ", " e ", "." };
            string[] nomesArray = nomes.Split(separadores, StringSplitOptions.None);

            foreach (string nome in nomesArray)
            {
                Console.WriteLine(nome);
            }

            Console.ReadKey();

        }
    }
}
