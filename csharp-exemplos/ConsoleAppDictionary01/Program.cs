using System;
using System.Collections.Generic;

namespace ConsoleAppDictionary01
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> pessoas = new Dictionary<string, int>()
            {
                { "Fulano", 21 },
                { "Maria", 35 }
            };

            pessoas.Add("Pedro", 52);
            pessoas.Add("João", 19);

            // alterando informação
            pessoas["Pedro"] = 101;

            Console.WriteLine($"Número de pessoas: {pessoas.Count}");

            pessoas.Remove("João");
            
            Console.WriteLine($"Número de pessoas: {pessoas.Count}");

            foreach (KeyValuePair<string, int> pessoa in pessoas)
            {
                Console.WriteLine($"Nome: {pessoa.Key}");
                Console.WriteLine($"Idade: {pessoa.Value}");
            }
        }
    }
}
