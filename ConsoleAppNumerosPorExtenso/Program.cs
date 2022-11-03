using Caelum.Stella.CSharp.Inwords;
using System.Diagnostics;

namespace ConsoleAppNumerosPorExtenso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double valor = 1532987.89;
            string extenso = new Numero(valor).Extenso();
            Debug.WriteLine(extenso);

            // adicionar reais/real, centavos ao final
            string extensoBRL = new MoedaBRL(valor).Extenso();
            Debug.WriteLine(extensoBRL);
        }
    }
}