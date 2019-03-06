using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero: ");

            try
            {
                int numero = int.Parse(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine("Não foi possivel realizar a conversão do valor digitado, por favor digite um valor válido.");
            } // Exception genérica - deve sempre vir por ultimo catch, pois senão todos os erros caem nela.
            catch (Exception e)
            {
                Console.WriteLine("Erro tratado pela classe Pai - Exception");
            }
            finally
            {
                Console.WriteLine("Finally");
            }

            Console.ReadLine();
            Console.ReadKey();
        }
    }
}
