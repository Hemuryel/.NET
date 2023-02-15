using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleAppLinq02
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] saudacoes = { "Olá Mundo", "Olá", "LINQ" };

            var item = from s in saudacoes
                       where s.EndsWith("LINQ")
                       select s;

            foreach (var i in item)
            {
                Console.WriteLine(i);
            }


            int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8 };

            var todosNumeros = from n in numeros
                               where n > 5
                               orderby n descending
                               select n;

            foreach (var n in todosNumeros)
            {
                Console.WriteLine(" " + n + 1);
            }

            var pessoas = new List<Pessoa>
            {
                new Pessoa { Idade = 15, Nome = "Fulano1"},
                new Pessoa { Idade = 17, Nome = "Fulano2"},
                new Pessoa { Idade = 25, Nome = "Fulano3"},
                new Pessoa { Idade = 30, Nome = "Fulano4"}
            };
            var adolescentes = from p in pessoas
                               where p.Idade > 14 && p.Idade < 20
                               select p;
    
            foreach (var ad in adolescentes)
            {
                Console.WriteLine(ad.Nome + "\t\n");
            }

            Console.ReadKey();
        }
    }

    public class Pessoa
    {
        public int Idade;
        public string Nome;
    }
}
