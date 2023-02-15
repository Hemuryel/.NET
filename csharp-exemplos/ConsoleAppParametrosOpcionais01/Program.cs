using System;

namespace ConsoleAppParametrosOpcionais01
{
    class Program
    {
        static void Main(string[] args)
        {
            SomarNumerosParams(10, 20, 30, 40, 50);
            SomarNumerosParams(10, 20, new int[] { 30, 40, 50, 60, 10 });
        }

        public static void SomarNumerosDefault(int numero1, int numero2, int numero3 = 0)
        {
            int resultado = numero1 + numero2 + numero3;
            Console.WriteLine("Soma = " + resultado);
        }

        public static void SomarNumerosParams(int numero1, int numero2, params int[] numeros)
        {
            int resultado = numero1 + numero2;
            if (numeros != null)
            {
                foreach (int i in numeros)
                {
                    resultado += i;
                }
            }
            Console.WriteLine("Soma = " + resultado);
        }

        public static void SomarNumerosOptional(int numero1, int numero2, [System.Runtime.InteropServices.Optional] int[] numeros)
        {
            int resultado = numero1 + numero2;
            if (numeros != null)
            {
                foreach (int i in numeros)
                {
                    resultado += i;
                }
            }

            Console.WriteLine("Soma = " + resultado);
        }
    }
}
