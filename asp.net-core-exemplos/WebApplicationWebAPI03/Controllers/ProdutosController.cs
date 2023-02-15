using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplicationWebAPI03.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplicationWebAPI03.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutosController : ControllerBase
    {
        static readonly IProdutoRepository repositorio = new ProdutoRepository();

        [HttpGet]
        public IEnumerable<Produto> GetTodos()
        {
            return repositorio.GetAll();
        }

        [HttpGet("{id}", Name = "GetProduto")]
        public IActionResult GetProdutoPorId(int id)
        {
            Produto produto = repositorio.Get(id);
            if (produto == null)
            {
                return NotFound();
            }
            return new ObjectResult(produto);
        }

        [HttpPost]
        public IActionResult CriarProduto([FromBody] Produto item)
        // [FromBody] = pega os dados do corpo da requisição
        {
            if (item == null)
            {
                return BadRequest();
            }

            item = repositorio.Add(item);
            return CreatedAtRoute("GetProduto", new { id = item.Id }, item);
        }

        [HttpPut("{id}")]
        public IActionResult AtualizarProduto(int id, [FromBody] Produto item)
        {
            if (item == null)
            {
                return BadRequest();
            }

            item.Id = id;
            if (!repositorio.Update(item))
            {
                return NotFound();
            }

            return new NoContentResult();
        }

        [HttpDelete("{id}")]
        public IActionResult DeletarProduto(int id)
        {
            Produto item = repositorio.Get(id);
            if (item == null)
            {
                return BadRequest();
            }
            repositorio.Remove(id);
            return new NoContentResult();
        }
    }
}
