using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleAppDictionary04
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dic1 = new Dictionary<int, string>()
             {
                                                {1,"Banana"},
                                                {2, "Laranja"},
                                                {3, "Manga"},
                                                {4, "Abacate"},
                                                {5,"Maça"}
              };
            foreach (KeyValuePair<int, string> item in dic1)
            {
                Console.WriteLine("chave: {0}, valor: {1}", item.Key, item.Value);
            }
            Console.ReadKey();

            Console.WriteLine("Acessando elementos de um Dictionary");
            Dictionary<int, string> dic2 = new Dictionary<int, string>()
            {
                                                {1,"Banana"},
                                                {2, "Laranja"},
                                                {3, "Manga"},
                                                {4, "Abacate"},
                                                {5,"Maça"}
            };
            for (int i = 0; i < dic1.Count; i++)
            {
                Console.WriteLine("chave: {0}, valor: {1}", dic2.Keys.ElementAt(i),
                            dic2[dic2.Keys.ElementAt(i)]);
            }
            Console.ReadKey();

            Dictionary<int, string> dic3 = new Dictionary<int, string>()
            {
                                                {1,"Banana"},
                                                {2, "Laranja"},
                                                {3, "Manga"},
                                                {4, "Abacate"},
                                                {5,"Maça"}
            };
            Console.WriteLine(dic3[2]);   // retorna laranja
            Console.WriteLine(dic3[4]);   // retorna abacate 
            Console.ReadKey();

            Console.WriteLine("Acessando elementos de um Dictionary");
            Dictionary<int, string> dic4 = new Dictionary<int, string>()
            {
                                                {1,"Banana"},
                                                {2, "Laranja"},
                                                {3, "Manga"},
                                                {4, "Abacate"},
                                                {5,"Maça"}
            };
            string resultado;
            if (dic4.TryGetValue(4, out resultado))
            {
                Console.WriteLine(resultado);
            }
            else
            {
                Console.WriteLine("Não foi possível achar a chave especificada.");
            }
            Console.ReadKey();

            Console.WriteLine("Verificar se há elementos existentes");
            Dictionary<int, string> dic5 = new Dictionary<int, string>()
            {
                                                {1,"Banana"},
                                                {2, "Laranja"},
                                                {3, "Manga"},
                                                {4, "Abacate"},
                                                {5,"Maça"}
            };
            Console.WriteLine(dic5.ContainsKey(1)); // retorna true
            Console.WriteLine(dic5.ContainsKey(6)); // retorna false

            // retorna true
            Console.WriteLine(dic5.Contains(new KeyValuePair<int, string>(3, "Manga")));
            Console.ReadKey();

            Console.WriteLine("Remover elementos de um dicionário");
            Dictionary<int, string> dic6 = new Dictionary<int, string>()
            {
                                                {1,"Banana"},
                                                {2, "Laranja"},
                                                {3, "Manga"},
                                                {4, "Abacate"},
                                                {5,"Maça"}
            };
            // remove o item com chave igual a 1
            dic6.Remove(1);
            Console.ReadKey();
        }
    }
}
