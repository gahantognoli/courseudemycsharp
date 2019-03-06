using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperadoresArit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Soma: " + 2 + 2); //Irá realizar a concatenção.
            Console.WriteLine("Soma: " + (2 + 2)); //Irá realizar a soma.

            Console.WriteLine("Subtração: " + (2 - 2)); //Irá realizar a soma.
            Console.WriteLine("Multiplicação: " + (3 * 2)); //Irá realizar a soma.
            Console.WriteLine("Divisão: " + (6 / 2)); //Irá realizar a soma.
            Console.WriteLine("Módulo/Resto: " + (8 % 2)); //Irá realizar a soma.

            Console.ReadKey();
        }
    }
}
