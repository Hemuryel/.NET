using System;

namespace ConsoleAppMetodoRefOut01
{
    class Program
    {
        public static void Main(string[] args)
        {
            int numero = 100;
            Console.WriteLine($"{numero}");
            
            CalcularValor_PorValor(numero);
            Console.WriteLine($"{numero}");

            CalcularValor_PorReferencia(ref numero);
            Console.WriteLine($"{numero}");

            CalcularValor_PorReferencia_Out(out numero);
            Console.WriteLine($"{numero}");
        }

        public static void CalcularValor_PorValor(int valor)
        {
            valor = valor * 10;
        }
        public static void CalcularValor_PorReferencia(ref int valor)
        {
            valor = valor * valor;
        }
        public static void CalcularValor_PorReferencia_Out(out int valor)
        {
            valor = 5;
            valor = valor * valor;
        }
    }
}
