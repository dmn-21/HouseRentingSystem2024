using HouseRentingSystem.Core.Contracts;
using Microsoft.AspNetCore.Mvc.Filters;

namespace HouseRentingSystem.Attributes
{
    public class NoteAnAgentAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            base.OnActionExecuting(context);

        }
    }
}
