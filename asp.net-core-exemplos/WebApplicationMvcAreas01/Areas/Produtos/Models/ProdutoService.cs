using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationMvcAreas01.Areas.Produtos.Models
{
    public static class ProdutoService
    {
        public static List<Produto> GetListaProdutos()
        {
            return new List<Produto>() {
                new Produto { Nome = "Caderno" },
                new Produto { Nome = "Caneta" },
                new Produto { Nome = "Borracha" },
                new Produto { Nome = "Estojo" }
            };
        }
    }
}
