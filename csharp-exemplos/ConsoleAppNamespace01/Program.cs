using System;

namespace ConsoleAppNamespace01
{
    class Program
    {
        static void Main(string[] args)
        {
            Exemplo1.Exemplo.testar();
            Exemplo2.Exemplo.testar();
        }
    }

}

// namespace
// - permite organização do escpo
// - namespaces diferentes permitem classes e métodos com mesmo nome

namespace Exemplo1
{
    class Exemplo
    {
        public static void testar()
        {
            Console.WriteLine("Exemplo1");
        }
    }
}

namespace Exemplo2
{
    class Exemplo
    {
        public static void testar()
        {
            Console.WriteLine("Exemplo2");
        }
    }
}