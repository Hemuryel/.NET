using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplicationEFCore02.Models;

namespace WebApplicationEFCore02.Controllers
{
    public class PaisesController : Controller
    {
        private readonly AplicacaoContext _context;

        public PaisesController(AplicacaoContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            List<Pais> listaPaises = new List<Pais>();

            listaPaises = (from pais in _context.Paises select pais).ToList();

            listaPaises.Insert(0, new Pais { Id = 0, Nome = "Selecione" });
            ViewBag.ListaPaises = listaPaises;

            return View();
        }

        [HttpPost]
        public IActionResult Index(Pais pais)
        {
            if(pais.Id == 0)
            {
                ModelState.AddModelError("", "Selecione um país");
            }

            ViewBag.ValorSelecionado = pais.Id;

            List<Pais> listaPaises = new List<Pais>();

            listaPaises = (from p in _context.Paises select p).ToList();

            listaPaises.Insert(0, new Pais { Id = 0, Nome = "Selecione" });
            ViewBag.ListaPaises = listaPaises;

            return View();
        }
    }
}
