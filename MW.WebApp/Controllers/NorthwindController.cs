using NW.Data;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MW.WebApp.Controllers
{
    public class NorthwindController : Controller
    {
        protected Repository r;

        protected override void Initialize(RequestContext requestContext)
        {
            base.Initialize(requestContext);
            string connStr = ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;
            r = new Repository(connStr);
        }
    }
}