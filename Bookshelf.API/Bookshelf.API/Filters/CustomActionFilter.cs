using Microsoft.AspNetCore.Mvc.Filters;

namespace Bookshelf.API.Filters
{
    public class CustomActionFilter:ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var dictionary = context.ActionArguments.Where(I=>true).FirstOrDefault();
            var obj = dictionary.Value;
            //....
            /*
                context.Result = new RedirectResult("\\some url");
             */
            // in controller -> [CustomActionFilter]
        }
    }
}
