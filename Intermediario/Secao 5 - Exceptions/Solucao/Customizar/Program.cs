using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customizar
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                throw new MinhaException("10");
            }
            catch (MinhaException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();

        }
    }
}
