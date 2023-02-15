using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;

namespace AspCoreMvc_Filtros.Filtros
{
    public class SaudacaoFilterAttribute : ActionFilterAttribute
    {
        //executar antes da Action
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            ViewResult result = context.Result as ViewResult;
            if (result != null)
            {
                result.ViewData["ola"] = "Olá, Filtro SaudacaoFilterAttribute... " + DateTime.Now.ToLongTimeString();
            }
            base.OnActionExecuting(context);
        }

        //executar depois da Action
        public override void OnActionExecuted(ActionExecutedContext context)
        {
            base.OnActionExecuted(context);
            ViewResult result = context.Result as ViewResult;
            if (result != null)
            {
                result.ViewData["adeus"] = "Tchau, Filtro SaudacaoFilterAttribute ... " + DateTime.Now.ToLongTimeString();
            }
        }
    }
}
