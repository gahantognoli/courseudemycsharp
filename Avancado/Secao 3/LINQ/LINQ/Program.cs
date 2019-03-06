using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            //LINQ 
            //LAMBDA: estrutura = (entrada) => (expressão)

            int[] lista = new int[] { 3, 9, 4, 6, 20, 10, 60, 90, 80, 50 };
            var listaFiltrada = lista.Where(a => a > 10).OrderBy(a => a).Select(a => a);

            foreach (int item in listaFiltrada)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
