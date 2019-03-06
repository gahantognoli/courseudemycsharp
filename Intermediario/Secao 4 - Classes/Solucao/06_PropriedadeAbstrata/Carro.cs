using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_PropriedadeAbstrata
{
    class Carro : Veiculo
    {
        //Obrigando a implementação dos métodos get e set, como definido na classe "Veiculo".
        //Isso faz com que o programador quando for usar sua classe, obrigue que ele implemente os metodos acessores.
        
        public override string Modelo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override string Marca => throw new NotImplementedException();
    }
}
