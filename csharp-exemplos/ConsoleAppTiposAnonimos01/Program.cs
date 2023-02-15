using static System.Console;
using System.Collections.Generic;
using System.Linq;
using ConsoleAppTiposAnonimos01;

namespace ConsoleAppTiposAnonimos01
{
    class Program
    {
        static void Main(string[] args)
        {

            var produtoTeste = new
            {
                id = 1,
                nome = "Monitor",
                preco = 1500
            };

            WriteLine($"id: {produtoTeste.id} {produtoTeste.nome} - preço: {produtoTeste.preco}");
          
            // instanciação de coleção
            List<Produto> produtos = new List<Produto>(); 
            // instanciação de objeto
            Produto produto = new Produto(); 
            produto.Id = 1;
            produto.Nome = "Mouse Microsoft";
            produto.Descricao = "Mouse sem fio 1200 dpi";
            produto.Estoque = 10;

            produtos.Add(produto);

            produto = new Produto();
            produto.Id = 2;
            produto.Nome = "Fone Ouvidos State Lite";
            produto.Descricao = "Fone de ouvidos de luxo";
            produto.Estoque = 5;

            produtos.Add(produto);

            var consultaProduto = from prod in produtos
                                  select new { prod.Id, prod.Nome, prod.Descricao };

            foreach (var p in consultaProduto)
            {
                WriteLine("Id={0}, Nome={1}, Descricao={2} ", p.Id, p.Nome, p.Descricao);
            }

            ReadLine();
        }
    }
}
