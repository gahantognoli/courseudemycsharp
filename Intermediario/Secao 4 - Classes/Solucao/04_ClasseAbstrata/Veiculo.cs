using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ClasseAbstrata
{
    //Não pode ser instanciada, serve apenas de "modelo" para as classes que herdam dela.
    abstract class Veiculo
    {
        string Modelo;
        string Marca;
        int AnoFabricacao;
        byte Eixos;
        byte rodas;
    }
}
