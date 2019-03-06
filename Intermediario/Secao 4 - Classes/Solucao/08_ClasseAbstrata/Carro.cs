using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_ClasseAbstrata
{
    class Carro : Veiculo, ITransporte
    {
        //Obrigando a implementação do método definido na INTERFACE.(IDÉIA DE CONTRATO)
        public void Mover(int velocidade)
        {
            Console.WriteLine("Mover ...");
        }
    }
}
