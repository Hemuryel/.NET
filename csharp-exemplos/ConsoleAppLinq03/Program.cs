using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleAppLinq03
{
    class Program
    {
        static void Main(string[] args)
        {
            // inicializador de coleção
            List<Produto> lista = new List<Produto>
            {
                // inicializador de objeto
                new Produto { Id = 1, Nome = "Fulano1", Preco = 2.50 },
                new Produto { Id = 2, Nome = "Fulano2", Preco = 2.50 },
                new Produto { Id = 3, Nome = "Fulano3", Preco = 2.50 }
            };

            // tipagem implícita
            var produtoMaiorPreco = from produto in lista
                                    where produto.Preco > 1.10
                                    select new // tipo anônimo
                                    {
                                        NomeProduto = produto.Nome,
                                        PrecoProduto = produto.Preco
                                    };

            foreach (var p in produtoMaiorPreco)
            {
                Console.WriteLine(p.NomeProduto + " " + p.PrecoProduto);
            }
            Console.ReadKey();
        }
    }

    class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }
    }
}
