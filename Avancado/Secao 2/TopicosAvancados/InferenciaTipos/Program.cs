using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InferenciaTipos
{

    class Usuario
    {
        public string Nome { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            object t = "";
            object t2 = 1;
            t2 = new Usuario() { Nome = "João" };

            var v1 = "";
            var v2 = 123;
            //var v3; Erro

            dynamic v3 = new Usuario { Nome = "Maria" };

            Console.WriteLine(v3.Nome);
            //Console.WriteLine(v3.Senha); Erro

            Console.ReadKey();
        }
    }
}
