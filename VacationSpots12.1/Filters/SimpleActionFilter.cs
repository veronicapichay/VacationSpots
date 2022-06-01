using System;
using System.Diagnostics;
using System.Web;
using Microsoft.AspNetCore.Mvc.Filters;

namespace VacationSpots12._1.Filters
{
    public class SimpleActionFilter : ActionFilterAttribute
    {
        public override void OnActionExecuted(ActionExecutedContext context)
        {
            Debug.WriteLine("In Home Index Action");
            //base.OnActionExecuted(context);
        }




    }
}
