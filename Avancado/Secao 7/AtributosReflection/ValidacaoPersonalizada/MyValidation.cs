using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ValidacaoPersonalizada
{
    class MyValidation : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            return (((string)value).Length == 10);
        }
    }
}
