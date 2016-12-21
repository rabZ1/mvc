using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MvcApplication3.HtmlHelpers
{
    public static class CustomHtmlHelper
    {
        public static string MakeActive(this UrlHelper urlHelper, string controller)
    {
        string result = "active";

        string controllerName = urlHelper.RequestContext.RouteData.Values["controller"].ToString();

        if (!controllerName.Equals(controller, StringComparison.OrdinalIgnoreCase))
        {
            result = null;
        }

        return result;
    }
    }
}