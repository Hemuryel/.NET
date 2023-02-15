using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleAppLambda01
{
    class Program
    {
        static void Main(string[] args)
        {
            var lista = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // sem lambda
            var listaFiltrada1 = lista.Where(MaiorQue4);

            foreach (int numero in listaFiltrada1)
            {
                Console.WriteLine(numero);
            }

            // fat lambda
            var listaFiltrada2 = lista.Where(
                (int x) =>
                {
                 return x > 4;
                }
            );

            foreach (int numero in listaFiltrada2)
            {
                Console.WriteLine(numero);
            }

            // com lambda
            var listaFiltrada3 = lista.Where(x => x > 4);

            foreach(int numero in listaFiltrada3)
            {
                Console.WriteLine(numero);
            }
        }

        public static bool MaiorQue4(int x)
        {
            return x > 4;
        }
    }
}
