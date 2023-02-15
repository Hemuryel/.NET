    using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplicationMvc01.Controllers
{
    public class ProdutoController : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}

        // não é obrigado a usar View
        // acesso = https://localhost:44340/produto
        public string Index()
        {
            return "Index() = Action método padrão 123" ;
        }

        public IActionResult Detalhe()
        {
            return View(); // default = Views/Produto/Detalhe.cshtml
        }

        public IActionResult RedirecionarIndex1()
        {
            return RedirectToAction("Index"); // Action: index, Controller: Produto
        }

        public IActionResult RedirecionarIndex2()
        {
            return RedirectToAction("Index", "Home"); // Action: index, Controller: Home
        }

        public IActionResult RedirecionarIndex3()
        {
            return RedirectToAction("Index", "Home", new { pagina = 1, ordem = "nome" }); 
            // Action: index, Controller: Home
            // e enviar parâmetros
        }

        public IActionResult RetornarAlgoSimples()
        {
            return Content("texto");
        }

        public IActionResult RetornarPdf()
        {
            return Content("texto", "application/pdf");
        }

        public IActionResult RetornarImagem()
        {
            return File("images/banner1.svg", "image/svg+xml");
        }

        public IActionResult RetonarTipoAnonimo()
        {
            var pessoa = new { ID = 1, Nome = "Fulano" };

            return new ObjectResult(pessoa);
        }

        public string RetornarInfoHttp()
        {
            var https = HttpContext.Request.IsHttps;
            var caminho = HttpContext.Request.Path;
            var status = HttpContext.Response.StatusCode;
            var conexao = HttpContext.Connection.ToString();

            return https + "\r\n" + caminho + "\r\n" + status + "\r\n" + conexao;
        }

        public IActionResult ReceberParametro1(int id)
        {
            return Content("valor do id = " + id);
            // exemplo1: https://localhost:5001/produto/ReceberParametro1/1 
            // só funciona por causa do mapeamento Controller no Startup id?

            // exemplo2 - queryString: https://localhost:5001/produto/ReceberParametro1?id=1 
        }

        public IActionResult ReceberParametro2(int? pagina, string ordem)
        {
            if (!pagina.HasValue)
                pagina = 1;

            if (String.IsNullOrEmpty(ordem))
                ordem = "Nome";

            //return Content(String.Format("pagina={0}&ordem={1}", pagina, ordem));
            return Content($"pagina={pagina}&ordem={ordem}");
            // sem rota, funciona apenas via queryString
        }

        // mapeado em MapControllerRoute na Startup
        public IActionResult DataLancamento1(int ano, int mes)
        {
            return Content(ano + "/" + mes);
        }

        public IActionResult DataLancamento2(int ano, int mes)
        {
            return Content(ano + "/" + mes);
        }
    }
}
