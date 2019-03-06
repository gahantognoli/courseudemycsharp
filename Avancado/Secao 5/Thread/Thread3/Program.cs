using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Thread3
{
    class Program
    {

        static int Rede = 0;
        static object variavelDeCOntrole = 0;

        static void Main(string[] args)
        {
            Console.WriteLine("DataIni: " + DateTime.Now);

            for (int i = 0; i < 5; i++)
            {
                Thread thread = new Thread(ThreadRepeticao);
                thread.Start();
            }

            Console.WriteLine("Programa Finalizado!");
            Console.ReadKey();
        }

        //IO
        public static void ThreadRepeticao()
        {
            lock (variavelDeCOntrole)
            {
                for (int i = 0; i < 1000; i++)
                {
                    Console.WriteLine("Num: " + i);
                    Rede++;
                }
            }
        }
    }
}
