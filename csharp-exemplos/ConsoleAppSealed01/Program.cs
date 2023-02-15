using System;

namespace ConsoleAppSealed01
{
    class Program
    {
        static void Main(string[] args)
        {
            Veiculo v = new Veiculo();
            v.dirigir();
        }
    }

    // não permite herança
    // não pode ser abstract, pois obriga implementação (contradiz o conceito)
    sealed class Veiculo
    {
        public void dirigir()
        {
            Console.WriteLine("dirigindo...");
        }
    }
}
