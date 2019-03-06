using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Un_BOXING
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;

            object b = 10;//boxing

            a = (int)b;//unboxing
        }
    }
}
