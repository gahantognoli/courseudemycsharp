using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading; 

namespace Thread1
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread thread = new Thread(ThreadRepeticao);
            thread.Start();

            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine("Main: " + i);
            }

            Console.ReadKey();

        }

        //IO
        public static void ThreadRepeticao()
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine("Num: " + i);
            }
        }

    }
}
