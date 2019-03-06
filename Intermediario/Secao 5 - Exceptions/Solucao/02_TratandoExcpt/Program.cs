using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_TratandoExcpt
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Pessoa pessoa = new Pessoa();
                pessoa.SetCEP("ABCD10");
            }
            catch (FormatException forExcept)
            {
                Console.WriteLine("ERRO FORMAT: " + forExcept.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERRO: " + ex.Message);
            }
            finally
            {
                //Sempre é executado ..
            }


            Console.ReadKey();

        }
    }
}
