using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleAppCollectionInitializers01
{
    class Program
    {
        static void Main(string[] args)
        {
            #region fluxo normal
            List<string> nomes = new List<string>();
            nomes.Add("Fulano01");
            nomes.Add("Fulano02");
            nomes.Add("Fulano03");
            #endregion

            #region Collection Initializers
            // inicializa coleção de objetos (usando object initilize) 
            // durante instanciação sem precisar de construtor
            // termina com ponto e vírgula
            List<string> nomes2 = new List<string> 
            { 
                "Fulano01",
                "Fulano02",
                "Fulano03"
            };

            List<Produto> listaNomes = new List<Produto>
            {
                new Produto { Id = 1, Nome = "Caneta1", Preco = 1.45 },
                new Produto { Id = 2, Nome = "Caneta2", Preco = 1.45 },
                new Produto { Id = 3, Nome = "Caneta3", Preco = 1.45 },
                new Produto { Id = 4, Nome = "Caneta4", Preco = 1.45 }
            };

            foreach (Produto p in listaNomes)
            {
                Console.WriteLine(p.Id + " " + p.Nome + " " + p.Preco);
            }
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
