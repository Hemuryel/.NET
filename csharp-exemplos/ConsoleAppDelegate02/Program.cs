using System;

namespace ConsoleAppDelegate02
{
    class Program
    {
        // Declaração
        public delegate void ExemploDelegate(string texto);

        static void Main(string[] args)
        {
            // Instanciação - 2 formas
            ExemploDelegate ex1 = new ExemploDelegate(ImprimirTexto);
            ExemploDelegate ex2 = ImprimirTexto;

            // Invocação
            ex1("exemplo1 delegate");
            ex1("exemplo2 delegate");
        }

        public static void ImprimirTexto(string texto)
        {
            Console.WriteLine(texto);
        }
    }
}
