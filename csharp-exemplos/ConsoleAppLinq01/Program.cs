using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleAppLinq01
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> cidades = new List<string>();
            cidades.Add("Curitiba");
            cidades.Add("Londrina");
            cidades.Add("Rio de Janeiro");

            //Console.WriteLine(BuscarPrimeiroNomeComForeach(cidades, "Londrina"));
            //Console.WriteLine(BuscarPrimeiroNomeComLinq(cidades, "Londrina"));
            //Console.WriteLine(BuscarPrimeiroNomeComLinqLambda(cidades, "Londrina"));

            BuscarListaComLinq(cidades, "Londrina").ForEach(x => Console.WriteLine(x));
            BuscarListaComLinqLambda(cidades, "Londrina").ForEach(x => Console.WriteLine(x));

            Console.ReadKey();
        }

        public static string BuscarPrimeiroNomeComForeach(List<string> lista, string termo)
        {
            foreach(string item in lista)
            {
                if (item.Equals(termo))
                {
                    return item;
                }
            }
            return null;
        }
        
        public static string BuscarPrimeiroNomeComLinq(List<string> lista, string termo)
        {
            return (from item in lista where item.Equals(termo) select item).First();
        }

        public static string BuscarPrimeiroNomeComLinqLambda(List<string> lista, string termo)
        {
            return lista.First(p => p.Equals(termo));
        }

        public static List<string> BuscarListaComLinq(List<string> lista, string termo)
        {
            // se não transformar em ToList, ficará como Enumerable e haverá perda de performance (trará todos os registros)
            return (from item in lista where item.Contains(termo) select item).ToList();
        }

        public static List<string> BuscarListaComLinqLambda(List<string> lista, string termo)
        {
            return lista.Where(p => p.Contains(termo)).ToList();
        }
    }
}
