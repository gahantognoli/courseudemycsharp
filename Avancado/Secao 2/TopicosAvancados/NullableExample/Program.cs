using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //int i = null; // Erro pois é value type, não pode ser nulo
            int? i = null; // nullable, indicando que pode ser nulo!
            Nullable<int> a = null; //dessa forma também.
        }
    }
}
