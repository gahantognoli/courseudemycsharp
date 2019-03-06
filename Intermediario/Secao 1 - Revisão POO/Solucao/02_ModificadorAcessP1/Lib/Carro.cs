using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_ModificadorAcessP1.Lib
{
    public class Carro : Veiculo
    {
        byte QtdRodas = 4;

        void infoCarro()
        {
            Marca = "VW";
            Modelo = "Gol";
        }
    }
}
