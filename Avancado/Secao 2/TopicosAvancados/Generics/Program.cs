using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Generics.Modelo;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro carro = new Carro() { Marca = "FIAT", Modelo = "Uno" };
            Casa casa = new Casa() { Cidade = "Viradouro", Endereco = "Um endereço qualquer" };
            Usuario usuario = new Usuario() { Nome = "Maria", Email = "maria.email.com.br", Senha = "senha@123" };

            Serializador.Serializar(carro);
            Serializador.Serializar(casa);
            Serializador.Serializar(usuario);

            Carro carroDeserializado = Serializador.Deserializar<Carro>();
            Casa casaDeserializada = Serializador.Deserializar<Casa>();
            Usuario usuarioDeserializado = Serializador.Deserializar<Usuario>();

            Console.WriteLine("Carro: " + carroDeserializado.Marca + " - " + carroDeserializado.Modelo);
            Console.WriteLine("Casa: " + casaDeserializada.Cidade + " - " + casaDeserializada.Endereco);
            Console.WriteLine("Usuario: " + usuarioDeserializado.Nome + " - " + usuarioDeserializado.Email);

            Console.ReadKey();


        }
    }
}
