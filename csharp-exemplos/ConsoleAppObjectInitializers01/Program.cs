using System;
using System.Linq;

namespace ConsoleAppObjectInitializers01
{
    class Program
    {
        static void Main(string[] args)
        {
            #region fluxo normal
            Produto p1 = new Produto();
            p1.Id = 1;
            p1.Nome = "Caneta";
            p1.Preco = 1.45;
            #endregion

            #region Object Initializers
            // inicializa durante instanciação sem precisar de construtor
            // termina com ponto e vírgula
            Produto p2 = new Produto
            {
                Id = 1,
                Nome = "Caneta",
                Preco = 1.45
            };

            Console.WriteLine(p2.Id);
            Console.WriteLine(p2.Nome);
            Console.WriteLine(p2.Preco);
            #endregion
        }
    }

    public class Produto
    {
        public string Promocao;
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }
    }
}
