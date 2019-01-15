using Financeiro.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Financeiro.Web.Filter
{
    public class CustomExceptionFilter : ExceptionFilterAttribute
    {
        public override void OnException(ExceptionContext context)
        {
            bool isAjaxCall = context.HttpContext.Request.Headers["x-request-with"] == "XMLHttpRequest";

            if(isAjaxCall)
            {
                context.HttpContext.Response.ContentType = "application/json";
                context.HttpContext.Response.StatusCode = 500;
                var message = context.Exception is DomainException? context.Exception.Message : "An Erro ocorred";
                context.Result = new JsonResult(message);
                context.ExceptionHandled = true;
            }
            base.OnException(context);
        }
    }
}