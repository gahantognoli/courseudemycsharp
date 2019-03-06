using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01_Biblioteca;

namespace _01_ReferenciaPrograma
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculo calculo = new Calculo();

            double resultado = calculo.Soma(10, 10);

            Console.Write("Resultado: " + resultado);
            Console.ReadKey();
        }
    }
}
