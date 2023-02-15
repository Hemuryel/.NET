using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationFilters01.Filters
{
    public class SaudacaoFilterAttribute : ActionFilterAttribute // somente para action ou controller
    {
        // executa antes da action
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            // nunca será exibida, pois executa antes da action, não tendo result
            ViewResult result = context.Result as ViewResult;
            if (result != null)
            {
                result.ViewData["ola"] = "Olá, Filtro SaudacaoFilterAttribute" + DateTime.Now.ToString();
            }
            base.OnActionExecuting(context);
        }

        // executa depois da action
        public override void OnActionExecuted(ActionExecutedContext context)
        {
            base.OnActionExecuted(context);
            ViewResult result = context.Result as ViewResult;
            if (result != null)
            {
                result.ViewData["adeus"] = "Tchau, Filtro SaudacaoFilterAttribute" + DateTime.Now.ToString();
            }
        }
    }
}
