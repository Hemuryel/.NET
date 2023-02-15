using System;

namespace ConsoleAppAnonymousType01
{
    class Program
    {
        static void Main(string[] args)
        {
            // não precisou criar a classe e nem instância da classe
            var prod1 = new { Id = 1, Nome = "Caneta", Preco = 1.25 }; 
            var frutas = new { Id = 1, Nome = "Maça", Preco = 2.25 };

            Console.WriteLine(prod1.Id);
            Console.WriteLine(prod1.Nome);
            Console.WriteLine(prod1.Preco);
            Console.ReadLine();
        }
    }
}
