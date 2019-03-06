using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Sobrescrita
{
    class Moto : Veiculo
    {
        public int Rodas = 2;

        //Override - Sobrescreve o método da classe pai, deixando intuitivo.
        public override void Mover()
        {
            Console.WriteLine("Mover chamando dentro de Moto.Mover");
            base.Mover(); // acessa a classe base(pai) e executa o método mover.
        }

    }
}
