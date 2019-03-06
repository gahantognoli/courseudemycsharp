using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Group
{
    class Program
    {
        static void Main(string[] args)
        {
            //Agregação - GroupBy com LINQ
            int[] listaNums = { 1, 1, 1, 1, 4, 4, 2, 3, 5, 6, 6, 10, 9, 8 };

            //DISTINCT
            var listaFiltrada = listaNums.Distinct().OrderBy(a => a);

            foreach (var item in listaFiltrada)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("*************");

            //GROUP BY
            var listaFiltrada2 = listaNums.OrderBy(a => a).GroupBy(a => a);

            foreach (var item in listaFiltrada2)
            {
                Console.WriteLine(item.Key);
            }

            Console.ReadKey();
        }
    }
}
