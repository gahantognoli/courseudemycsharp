using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQToObject
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Usuario> lista = new List<Usuario>()
            {
                new Usuario(){ Nome = "José", Email = "jose@gmail.com" },
                new Usuario(){ Nome = "Maria", Email = "Maria@hotmail.com" },
                new Usuario(){ Nome = "João", Email = "joao@ig.com" },
                new Usuario(){ Nome = "Felipe", Email = "felipe@gmail.com" },
                new Usuario(){ Nome = "Elias", Email = "elias@gmail.com" }
            };

            var listaFiltrada = lista.Where(u => u.Email.Contains("@gmail.com")).OrderBy(a => a.Nome).Select(u => u);

            foreach (Usuario usuario in listaFiltrada)
            {
                Console.WriteLine("Nome: " + usuario.Nome + " - Email: " + usuario.Email);
            }

            Console.ReadKey();
            
        }
    }
}
