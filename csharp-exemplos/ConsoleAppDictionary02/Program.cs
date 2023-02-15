using System;
using System.Collections.Generic;

namespace ConsoleAppDictionary02
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> veiculos = new Dictionary<int, string>();
            veiculos.Add(10, "Carro");
            veiculos.Add(2, "Avisão");
            veiculos.Add(0, "Navio");
            veiculos.Add(20, "Moto");
            veiculos.Add(15, "Patinete");

            Console.WriteLine($"Tamanho: {veiculos.Count}"); // Count é propriedade e não método

            //veiculos.Clear(); // excluir todos dados do dicionário

            veiculos.Remove(20);

            Console.WriteLine($"Tamanho: {veiculos.Count}");

            int chave = 20;
            if (veiculos.ContainsKey(chave))
            {
                Console.WriteLine($"A chave {chave} está na coleção");
            }
            else
            {
                Console.WriteLine($"A chave {chave} NÃO está na coleção");
            }

            // alterar valor
            veiculos[15] = "Bicicleta";

            string valor = "Bicicleta";
            if (veiculos.ContainsValue(valor))
            {
                Console.WriteLine($"O valor {valor} está na coleção");
            }
            else
            {
                Console.WriteLine($"O Valor {valor} NÃO está na coleção");
            }

            foreach(KeyValuePair<int, string> v in veiculos)
            {
                Console.WriteLine(v.Value);
            }

            Dictionary<int, string>.ValueCollection valores = veiculos.Values;
            foreach (string v in valores)
            {
                Console.WriteLine(v);
            }
        }
    }
}
