using System;

namespace ConsoleAppDelegate01
{
    class Program
    {
        static void Main(string[] args)
        {
            Delegate1 delegateExemplo1;
            
            delegateExemplo1 = new Delegate1(Mat.somar);
            Console.WriteLine($"Soma = {delegateExemplo1(10, 20)}");

            delegateExemplo1 = new Delegate1(Mat.multiplicar);
            Console.WriteLine($"Multiplicar = {delegateExemplo1(10, 20)}");
        }
    }

    /* Delegate
     * - faz referência a métodos
     * - contém endereço de memória do ponto de entrada do método
     */
    delegate int Delegate1(int n1, int n2);

    class Mat
    {
        public static int somar (int n1, int n2)
        {
            return n1 + n2;
        }

        public static int multiplicar(int n1, int n2)
        {
            return n1 * n2;
        }
    }
}
