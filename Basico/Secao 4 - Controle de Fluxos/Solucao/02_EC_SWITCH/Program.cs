using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_EC_SWITCH
{
    class Program
    {
        static void Main(string[] args)
        {
            string valor;
            Console.WriteLine("Qual é o seu testado Cívil ? Informe S - Solteiro, C - Casado, V -Viúvo, D - Divorciado");
            valor = Console.ReadLine();

            switch (valor)
            {
                case "S":
                    Console.Write("Você está solteiro.");
                    break;  

                case "C":
                    Console.Write("Você está Casado.");
                    break;

                case "V":
                    Console.Write("Você está Viúvo.");
                    break;

                case "D":
                    Console.Write("Você está Divorciado.");
                    break;

                default:
                    Console.Write("Digite uma opção válida.");
                    break;
            }

            Console.ReadKey();
        }
    }
}
