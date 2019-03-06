using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ConversaoCasting
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor = 30.50;

            int b = (int)valor;//Casting

            int a = Convert.ToInt32(valor);
        }
    }
}
