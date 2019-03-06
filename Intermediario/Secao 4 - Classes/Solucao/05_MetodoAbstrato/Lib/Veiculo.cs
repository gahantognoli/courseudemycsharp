using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_MetodoAbstrato.Lib
{
    //Só é possível existir métodos abstratos em classes abstratas(não podem ser instanciadas, servem apenas de "modelo").
    abstract class Veiculo
    {
        //Obriga as classes que herdaem à implementarem esse método.
        //O abstract já indica que é virtual, ou seja não precisa informar que é virtual para ser sobrescrita.
        abstract public void MudarMarchar(byte NumeroMarcha);
    }
}
