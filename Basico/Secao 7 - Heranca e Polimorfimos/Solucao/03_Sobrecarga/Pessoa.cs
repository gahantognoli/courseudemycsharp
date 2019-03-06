using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Sobrecarga
{
    class Pessoa
    {
        //Sobrecarga: Varias possibilidades para um mesmo método(mesmo nome), porém se diferem na quantidade de parametros e/ou 
        // no tipo de parametros.
        public int Andar()
        {
            return 1;
        }

        public int Andar(int lvl)
        {
            return Andar() * lvl;
        }
    }
}
