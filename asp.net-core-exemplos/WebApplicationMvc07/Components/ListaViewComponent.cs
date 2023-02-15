using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplicationMvc07.Components
{
    public class ListaViewComponent: ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(string sequencia)
        {
            var resultado = await Task.FromResult(sequencia.Split(new char[] { ',' }));
            return View("Lista", resultado); //se não definisse, seria "Default.cshtml"
        }
    }
}
