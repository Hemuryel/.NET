using System;
using System.Collections.Generic;

namespace ConsoleAppVar01
{
    class Program
    {
        static void Main(string[] args)
        {
            #region fluxo normal
            int contador = 0;
            string Nome = "Fulano";
            int[] numeros = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<int> inteiros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            #endregion

            #region var tipo implícito
            var contador2 = 0;
            var Nome2 = "Fulano";
            var numeros2 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var inteiros2 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            #endregion
        }
    }
}
