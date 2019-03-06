using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_PropriedadeAbstrata
{
    abstract class Veiculo
    {
        /// <summary>
        /// Instrucões: tal tal tal ...
        /// </summary>
        abstract public string Modelo { get; set; }
        abstract public string Marca { get; }
    }
}
