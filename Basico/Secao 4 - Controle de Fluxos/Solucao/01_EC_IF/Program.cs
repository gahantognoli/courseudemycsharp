using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_EC_IF
{
    class Program
    {
        static void Main(string[] args)
        {
            float valorPoucanca;
            string valorPoupancaTexto;
            Console.Write("Digite o valor que possue na sua conta poupança: ");
            valorPoupancaTexto = Console.ReadLine();

            valorPoucanca = float.Parse(valorPoupancaTexto);

            if (valorPoucanca > 100000)
            {
                Console.WriteLine("Voce cliente VIP possui uma taxa de juros diferenciada.");
            }
            else if (valorPoucanca > 50000)
            {
                Console.Write("Você é uma Cliente especial, com taxa de juros de 1.2% ao mês.");
            }
            else
            {
                Console.Write("Você é um Cliente especial, mas sua taxa de juros é normal(0.5%) ao mês.");
            }

            Console.ReadKey();
        }
    }
}
