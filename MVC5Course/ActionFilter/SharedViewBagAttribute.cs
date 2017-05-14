﻿using System;
using System.Web.Http.Controllers;
using System.Web.Mvc;

namespace MVC5Course.ActionFilter
{
    internal class SharedViewBagAttribute : System.Web.Mvc.ActionFilterAttribute
    {

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            filterContext.Controller.ViewBag.Message = "Your application description page.";
            base.OnActionExecuting(filterContext);
        }


       
    }
}