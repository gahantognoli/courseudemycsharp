using Delegates2.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates2
{
    class Program
    {
        static void Main(string[] args)
        {
            Foto foto = new Foto() { Nome = "perfil.jpg", TamanhoX = 1920, TamanhoY = 1080 };
            FotoProcessador.filtros = new FotoFiltro().GerarThumb;
            FotoProcessador.Processador(foto);

            Foto foto2 = new Foto() { Nome = "produto.jpg", TamanhoX = 1920, TamanhoY = 1080 };
            FotoProcessador.filtros = new FotoFiltro().Colorir;
            FotoProcessador.filtros += new FotoFiltro().RedimensionarTamanhoMedio;
            FotoProcessador.Processador(foto2);

            Foto foto3 = new Foto() { Nome = "album.jpg", TamanhoX = 1920, TamanhoY = 1080 };
            FotoProcessador.filtros = new FotoFiltro().PretoBranco;
            FotoProcessador.Processador(foto3);

            Console.ReadKey();
        }
    }
}
