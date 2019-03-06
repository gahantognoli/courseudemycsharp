using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ClasseInternas
{
    class Pessoa
    {
        public Pessoa()
        {
            Olho olho = new Olho();
        }

        public class Olho
        {
            public static string Iris = "Azul";

            public Olho()
            {
                Pessoa pessoa = new Pessoa();
            }
        }

    }
}
