using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Diagnostics;

namespace AspCoreMvc_Filtros.Filtros
{
    public class DuracaoActionFilter : IActionFilter
    {
        private Stopwatch _stopwatch;

        public void OnActionExecuting(ActionExecutingContext context)
        {
            _stopwatch = Stopwatch.StartNew();
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            var duracaoDaAction = _stopwatch.ElapsedMilliseconds;
            _stopwatch.Stop();

            //adiciona o tempo calculado ao viewdata na viewresult
            ViewResult result = context.Result as ViewResult;
            if (result != null)
            {
                result.ViewData["duracaoDaAction"] = duracaoDaAction;
            }
        }
    }
}
