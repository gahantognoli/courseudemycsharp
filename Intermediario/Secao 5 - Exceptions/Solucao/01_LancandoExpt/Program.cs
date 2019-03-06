using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_LancandoExpt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o numero 1: ");
            string valor = Console.ReadLine();

            if(valor == "1")
            {
                Console.WriteLine("Correto.");
            }
            else
            {
                throw new Exception("O valor digitado não é valido");
            }

            Console.ReadKey();

        }
    }
}
