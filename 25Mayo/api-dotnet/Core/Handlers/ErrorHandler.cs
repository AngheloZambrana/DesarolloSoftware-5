using Microsoft.AspNetCore.Mvc.Filters;

public class ErrorHandler : IActionFiler
{
    public void OnActionExecuted(ActionExecuteContext context)
    {
        if (context.Exception == null)
        {
            return;
        }
        var exception = (context.Exception is AbstractException)
            ? co
    }
    public void OnActionExecuting(ActionExecutingContext context)
    {

    }
}