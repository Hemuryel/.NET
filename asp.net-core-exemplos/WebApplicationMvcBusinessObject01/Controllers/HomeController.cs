using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApplicationMvcBusinessObject01.Models;

namespace WebApplicationMvcBusinessObject01.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IAlunoBLL _alunoBLL;

        public HomeController(ILogger<HomeController> logger, IAlunoBLL alunoBLL)
        {
            _logger = logger;

            // D.I.
            _alunoBLL = alunoBLL;
        }

        public IActionResult Index()
        {
            // sem D.I.
            // AlunoBLL alunoBLL = new AlunoBLL(); 
            List<Aluno> alunos = _alunoBLL.GetAlunos().ToList();

            return View("Lista", alunos); // Lista.cshtml
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Aluno aluno)
        {
            /*Validação no Controller por ModelState*/
            /*Desativado para usar validação na Model por DataAnnotations*/
            /*if (string.IsNullOrEmpty(aluno?.Nome))
                ModelState.AddModelError("Nome", "O nome é obrigatório.");

            if (string.IsNullOrEmpty(aluno?.Email))
                ModelState.AddModelError("Email", "O e-mail é obrigatório.");

            if (string.IsNullOrEmpty(aluno?.Sexo))
                ModelState.AddModelError("Sexo", "O sexo é obrigatório.");

            if (aluno?.Nascimento <= DateTime.Now.AddYears(-18))
                ModelState.AddModelError("Nascimento", "Data de nascimento é inválida.");*/

            if (!ModelState.IsValid)
                return View();
            else
            {
                //AlunoBLL _aluno = new AlunoBLL();
                _alunoBLL.IncluirAluno(aluno);
                return RedirectToAction("Index");
            }

            //if (aluno?.Nome == null || aluno?.Email == null || aluno?.Sexo == null || aluno?.Nascimento == null)
            //{
            //    ViewBag.Erro = "Dados inválidos!";
            //    return View();
            //}
            //else
            //{
            //  AlunoBLL _alunoBLL = new AlunoBLL();
            //    _alunoBLL.IncluirAluno(aluno);
            //    return RedirectToAction("Index");
            //}        
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            // sem D.I.
            // AlunoBLL _alunoBLL = new AlunoBLL();
            Aluno aluno = _alunoBLL.GetAlunos().Single(x => x.Id == id);
            return View(aluno);
        }

        [HttpPost]
        public IActionResult Edit(Aluno aluno)
        {
            if (ModelState.IsValid)
            {
                // sem D.I.
                // AlunoBLL _alunoBLL = new AlunoBLL();
                _alunoBLL.AtualizarAluno(aluno);
                return RedirectToAction("Index");
            }
            return View(aluno);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            //_alunoBLL.DeletarAluno(id);
            //return RedirectToAction("Index");

            Aluno aluno = _alunoBLL.GetAlunos().Single(x => x.Id == id);
            return View(aluno);
        }

        [HttpPost]
        public IActionResult Delete(Aluno aluno)
        {
            _alunoBLL.DeletarAluno(aluno.Id);
            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            Aluno aluno = _alunoBLL.GetAlunos().Single(a => a.Id == id);
            return View(aluno);
        }

        public IActionResult Procurar(string procurarPor, string criterio)
        {
            if(procurarPor == "Email")
            {
                Aluno aluno = _alunoBLL.GetAlunos().SingleOrDefault(a => a.Email == criterio);
                return View(aluno);
            }
            else
            {
                Aluno aluno = _alunoBLL.GetAlunos().SingleOrDefault(a => a.Nome == criterio);
                return View(aluno);
            }
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
