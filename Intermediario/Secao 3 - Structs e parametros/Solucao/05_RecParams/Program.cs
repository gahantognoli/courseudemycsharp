using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_RecParams
{
    class Program
    {
        static void Main(string[] args)
        {
            
            VariasEntradas01("Gabriel", "Otávio", "Rafael");

            //Criar um array só para passar os parametros.
            //Com o params isso é feito de forma automática.
            string[] nomes = { "Gabriel", "Otávio", "Rafael", "Maria" };
            VariasEntadas02(nomes);

            VariasEntradas03(10, "Gabriel", "Otávio", "Rafael");
        }

        //Muitos parametros, dificultando a leitura do método e deixando mais extenso.
        static void VariasEntradas01(string nome1, string nome2, string nome3)
        {

        }

        //Passando um array de forma explícita.
        static void VariasEntadas02(string[] nomes)
        {

        }

        //Forma mais compactada de passar parâmetros, transformando seus parâmetros em um array de forma implícita.
        //Unica regra é que ele deve ser o ÚLTIMO parametro.
        static void VariasEntradas03(int idade, params string[] nomes)
        {

        }

    }
}
