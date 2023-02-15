using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationFilters01.Filters
{
    public class DuracaoActionFilter : IActionFilter // global
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

            // adiciona o tempo calculado ao viewdata na viewresult
            ViewResult result = context.Result as ViewResult;
            if (result != null)
            {
                result.ViewData["duracaoDaAction"] = duracaoDaAction;
            }
        }
    }
}
