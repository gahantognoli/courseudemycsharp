using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Polimorfismo.Biblioteca.Derivadas
{
    class Onibus : Veiculo
    {
        //Sobrescrevendo ..
        public override void Mover()
        {
            Console.WriteLine("Onibus se movendo ...");
        }

    }
}
