using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace AspCoreMvc_Filtros.Filtros
{
    public class TrataExceptionAttribute : ExceptionFilterAttribute
    {
        public override void OnException(ExceptionContext context)
        {
            var result = new ViewResult { ViewName = "Error" };
            var modelMetadata = new EmptyModelMetadataProvider();

            result.ViewData = new ViewDataDictionary(modelMetadata, context.ModelState);

            result.ViewData.Add("HandleException", context.Exception);
            context.Result = result;

            //indica que a exceção ja foi tratada
            context.ExceptionHandled = true;
        }
    }
}
