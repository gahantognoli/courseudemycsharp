﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThread
{
    class Program
    {
        static void Main(string[] args)
        {
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
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine("Num: " + i);
            }
        }

    }
}
