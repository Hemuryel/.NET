using System;

using NamespaceTeste01;
using NamespaceTeste01.NamespaceTeste02;
using aliasTeste02 = NamespaceTeste01.NamespaceTeste02.Teste02;

using static NamespaceTeste01.NamespaceTeste02.Teste02;

namespace ConsoleAppNamespace02
{
    class Program
    {
        static void Main(string[] args)
        {
            NamespaceTeste01.Teste01.imprimir();
            NamespaceTeste01.NamespaceTeste02.Teste02.imprimir();

            // using NamespaceTeste01;
            Teste01.imprimir();
            // using NamespaceTeste01.NamespaceTeste02;
            Teste02.imprimir();

            // using aliasTeste02 = NamespaceTeste01.NamespaceTeste02.Teste02;
            aliasTeste02.imprimir();

            // using static NamespaceTeste01.NamespaceTeste02.Teste02;
            imprimir();
        }
    }
}
