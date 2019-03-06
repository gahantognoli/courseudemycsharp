using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Program
    {

        delegate int Calcula(int a, int b);

        static void Main(string[] args)
        {
            //int so = Somar(40, 10);
            //int su = Subtrair(40, 10);

            Calcula calc = new Calcula(Somar);
            int so = calc(10, 20);

            Calcula calc2 = new Calcula(Subtrair);
            int su = calc2(50, 20);

            Console.WriteLine("Soma: " + so);
            Console.WriteLine("Subtrair: " + su);
            Console.ReadKey();
        }

        static int Somar(int a, int b)
        {
            return a + b;
        }

        static int Subtrair(int a, int b)
        {
            return a - b;
        }

    }
}
