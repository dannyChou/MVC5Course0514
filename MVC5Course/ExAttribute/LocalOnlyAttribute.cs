﻿using System;
using System.Web.Mvc;

namespace MVC5Course.Controllers
{
    internal class LocalOnlyAttribute : ActionFilterAttribute
    {
        public string MyProperty { get; set; }
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (!filterContext.RequestContext.HttpContext.Request.IsLocal) {
                filterContext.Result = new RedirectResult("/");
            }
        }

    }
}