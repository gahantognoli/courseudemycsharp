using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosExtensao
{
    public static class StringExtension 
    {
        public static string FirstToUpper(this String str, string valor)
        {
            string first = valor.Substring(0, 1).ToUpper();
            string rest = valor.Substring(1, str.Length);
            return first + rest;
        }
    }
}
