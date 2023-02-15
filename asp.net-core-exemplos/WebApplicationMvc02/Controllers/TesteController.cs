using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplicationMvc02.Controllers
{
    [Route("[controller]/[action]")]
    public class TesteController : Controller
    {
        public IActionResult Index()
        {
            // Fracamente tipado
            ViewData["Saudacao"] = "Olá...";
            ViewData["DataInicio"] = new DateTime(2017, 09, 01);
            ViewData["Endereco"] = new Endereco()
            {
                Nome = "Fulano",
                Rua = "Av Brasil",
                Cidade = "Curitiba",
                Estado = "SP"
            };

            return View();
        }
    }
}
