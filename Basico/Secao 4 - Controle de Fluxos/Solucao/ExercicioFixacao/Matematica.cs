using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioFixacao
{
    class Matematica
    {

        public static int Exponenciacao(int numero, int exponente)
        {
            int resultado = numero;

            for (int i = 1; i < exponente; i++)
            {
                resultado = numero * resultado;
            }

            return resultado;
        }

    }
}
