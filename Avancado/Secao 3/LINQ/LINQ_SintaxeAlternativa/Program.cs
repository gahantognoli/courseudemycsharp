using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_SintaxeAlternativa
{
    public class Program
    {
        static void Main(string[] args)
        {
            //LINQ 
            //LAMBDA: estrutura = (entrada) => (expressão)

            int[] lista = new int[] { 3, 9, 4, 6, 20, 10, 60, 90, 80, 50 };

            //var listaFiltrada = lista.Where(a => a > 10).OrderBy(a => a).Select(a => a);
            //Como fazer o comando acima com LINQ.

            var listaFiltrada = from item in lista
                                where item > 10
                                orderby item
                                select item;

            foreach (int item in listaFiltrada)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
