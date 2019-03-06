using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioFixacao
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("****Exercicio Calculo Exponencial****");
            Console.Write("Digite um numero: ");
            int num = int.Parse(Console.ReadLine());

            Console.Write("Digite um numero que será o exponencial: ");
            int exponencial = int.Parse(Console.ReadLine());

            Console.WriteLine("O resultado é: " + Matematica.Exponenciacao(num, exponencial));

            Console.ReadKey();
        }
    }
}
