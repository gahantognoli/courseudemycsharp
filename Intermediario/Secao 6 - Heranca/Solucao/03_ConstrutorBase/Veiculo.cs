using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ConstrutorBase
{
    class Veiculo
    {

        public Veiculo()
        {
            Console.WriteLine("Construindo veiculo ...");
        }

        public Veiculo(int i)
        {
            Console.WriteLine("Construindo veiculo numero: " + i);
        }

        public virtual void Andar()
        {
            Console.WriteLine("Veiculo Andando ...");
        }
    }
}
