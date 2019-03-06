using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Join
{
    class Program
    {
        static void Main(string[] args)
        {
            Autor autor = new Autor() { Id = 1, Nome = "Leonardo" };
            Autor autor2 = new Autor() { Id = 2, Nome = "Maria Maria" };
            Autor autor3 = new Autor() { Id = 3, Nome = "Joseph" };

            List<Autor> listaAutores = new List<Autor>() { autor, autor2, autor3 };

            Livro livro = new Livro() { Id = 1, AutorId = 2, Titulo = "Amor amado", AnoPublicacao = 1998 };
            Livro livro2 = new Livro() { Id = 2, AutorId = 2, Titulo = "Bem amado", AnoPublicacao = 1991 };
            Livro livro3 = new Livro() { Id = 3, AutorId = 3, Titulo = "Um espião em Washigton", AnoPublicacao = 1971 };
            Livro livro4 = new Livro() { Id = 4, AutorId = 1, Titulo = "A Vida na Terra", AnoPublicacao = 2011 };

            List<Livro> listaLivros = new List<Livro>() { livro, livro2, livro3, livro4 };

            var listaJoin = from li in listaLivros
                            join au in listaAutores
                            on li.AutorId equals au.Id
                            select new
                            {
                                li.Titulo,
                                au.Nome
                            };

            foreach (var item in listaJoin)
            {
                Console.WriteLine("Livro: " + item.Titulo + " - Autor: " + item.Nome);
            }

            Console.ReadKey();
        }
    }
}
