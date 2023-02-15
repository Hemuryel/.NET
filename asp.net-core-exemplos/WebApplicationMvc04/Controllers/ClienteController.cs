using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplicationMvc04.Models;

namespace WebApplicationMvc04.Controllers
{
    public class ClienteController : Controller
    {
        [HttpGet] // Index() por padrão já é GET, não seria preciso definir [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Cliente cliente)
        {
            if (cliente?.Id == 0 || cliente?.Nome == null || cliente?.Email == null)
            {
                ViewBag.Erro = "Dados do cliente inválidos...";
                return View(); // retornar para View Index.cstml
            }
            return View("ExibirDados", cliente);
        }
    }
}
