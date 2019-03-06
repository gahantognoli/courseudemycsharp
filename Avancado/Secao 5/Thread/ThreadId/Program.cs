using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadId
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                Thread thread = new Thread(ThreadRepeticao);
                thread.Start(i);
            }

            Console.WriteLine("Programa Finalizado!");
            Console.ReadKey();
        }

        //IO
        public static void ThreadRepeticao(object Id)
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine("Thread Id: " + Id + " - Num: " + i + "ID Interno: " + Thread.CurrentThread.ManagedThreadId);
            }
        }
    }
}
