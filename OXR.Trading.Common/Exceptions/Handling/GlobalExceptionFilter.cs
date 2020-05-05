using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace OXR.Trading.Common.Exceptions.Handling
{
    public class GlobalExceptionFilter : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            var response = new ResponseError()
            {
                ErrorType = ((TradingProcessingException)context.Exception).Type.ToString(),
                ErrorCode = ((int)((TradingProcessingException)context.Exception).Code),
                ErrorDescription = ((TradingProcessingException)context.Exception).Message
            };

            context.Result = new ObjectResult(response)
            {
                StatusCode = 500,
                DeclaredType = typeof(ResponseError)
            };

        }
    }
}
