using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_MetodoAbstrato.Lib
{
    class Carro : Veiculo
    {
        //Obrigou a implementação do método abstrato "MudarMarcha" da classe "Veiculo".
        public override void MudarMarchar(byte NumeroMarcha)
        {
            throw new NotImplementedException();
        }
    }
}
