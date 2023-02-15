using AspCoreMvc_Filtros.Filtros;
using AspCoreMvc_Filtros.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspCoreMvc_Filtros.Controllers
{
    [Produces("application/json")]
    [Route("api/Autores")]
    [ValidarModelo]
    public class AutoresController : Controller
    {
        private readonly IAutorRepositorio _context;

        public AutoresController(IAutorRepositorio autorRepositorio)
        {
            _context = autorRepositorio;
        }

        // GET: api/autores
        [HttpGet]
        public async Task<List<Autor>> Get()
        {
            return await _context.ListAsync();
        }

        // GET api/autores/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get([FromRoute] int id)
        {
            //if (!ModelState.IsValid)
            //{
            //    return BadRequest(ModelState);
            //}

            if ((await _context.ListAsync()).All(a => a.Id != id))
            {
                return NotFound(id);
            }
            return Ok(await _context.GetByIdAsync(id));
        }


        // PUT api/autores/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put([FromRoute] int id, [FromBody]Autor autor)
        {
            //if (!ModelState.IsValid)
            //{
            //    return BadRequest(ModelState);
            //}

            if ((await _context.ListAsync()).All(a => a.Id != id))
            {
                return NotFound(id);
            }

            autor.Id = id;
            await _context.UpdateAsync(autor);
            return Ok();
        }

        // POST api/autores
        [HttpPost]
        public async Task<IActionResult> Post([FromBody]Autor autor)
        {
            //if (!ModelState.IsValid)
            //{
            //    return BadRequest(ModelState);
            //}
            await _context.AddAsync(autor);
            return Ok(autor);
        }

        // DELETE api/autores/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            if ((await _context.ListAsync()).All(a => a.Id != id))
            {
                return NotFound(id);
            }

            await _context.DeleteAsync(id);
            return Ok();
        }
    }
}