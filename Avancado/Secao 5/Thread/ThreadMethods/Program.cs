using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inicio do programa!");
            Thread.Sleep(3000);
            Console.WriteLine("Termino do programa");
            Console.ReadKey();

            Thread thread = new Thread(ThreadRepeticao);
            thread.Start();
            thread.Join(); //espera a execução da thread.

        }

        public static void ThreadRepeticao(object Id)
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine("Thread Id: " + Id + " - Num: " + i + "ID Interno: " + Thread.CurrentThread.ManagedThreadId);
            }
        }
    }
}
