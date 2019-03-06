using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Estrutura
{
    //Passagem por VALOR.
    //Mesmo principio da classe, porém de forma MENOR.
    //Guarda os seus valores diretamente na memória e não em referencia.
    struct Polegada
    {
        double centimetros;
        double polegada;

        public Polegada(double polegadas)
        {
            centimetros = 2.54;
            polegada = polegadas * centimetros;
        }

        public double GetPolegadasCentimetros()
        {
            return polegada;
        }
    }
}
