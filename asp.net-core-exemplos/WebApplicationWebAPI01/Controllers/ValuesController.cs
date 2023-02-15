using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebApplicationWebAPI01.Models;

namespace WebApplicationWebAPI01.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private readonly UserManager<MeuUserIdentity> _userManager;

        public ValuesController(UserManager<MeuUserIdentity> userManager)
        {
            this._userManager = userManager;
        }

        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            MeuUserIdentity usuario = _userManager.GetUserAsync(HttpContext.User).Result;
            ViewBag.Usuario = usuario.Email;

            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return $"value {id}";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
