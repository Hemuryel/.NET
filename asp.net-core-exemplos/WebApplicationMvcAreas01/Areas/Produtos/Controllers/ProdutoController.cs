using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplicationMvcAreas01.Areas.Produtos.Models;

namespace WebApplicationMvcAreas01.Areas.Produtos.Controllers
{
    [Area("Produtos")]
    public class ProdutoController : Controller
    {
        public IActionResult Index()
        {
            List<Produto> produtos = ProdutoService.GetListaProdutos();
            return View(produtos);
        }
    }
}
