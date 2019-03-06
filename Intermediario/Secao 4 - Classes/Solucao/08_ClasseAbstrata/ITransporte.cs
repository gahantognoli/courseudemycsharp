using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_ClasseAbstrata
{
    //Interface tem como caracteristica definir CONTRATOS com as classes que herdam dela, obrigando a implementação de seus métodos
    // e de suas propriedades, tornando assim o código mais seguro.
    //NÃO UTILIZA MODIFICADORES DE ACESSO.
    //É POSSÍVEL NO C# HERDAR MAIS DE UMA INTERFACE, MAS NÃO MAIS DE UMA CLASSE.
    interface ITransporte
    {
        void Mover(int velocidade);
    }
}
