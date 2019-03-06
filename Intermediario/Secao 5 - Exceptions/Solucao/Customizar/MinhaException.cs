using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customizar
{
    public class MinhaException : Exception
    {
        string LinhaDoErro;

        public MinhaException(string linha) : base("Minha exceção")
        {
            LinhaDoErro = linha;
        }
    }
}
