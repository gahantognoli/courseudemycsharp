
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_ModificadorAcessP1.Lib
{
    public class Caminhao : Veiculo
    {
        byte QtdRodas = 10;

        void infoCaminhao()
        {
            Marca = "VOLVO";
            Modelo = "1520";
        }
    }
}
