using NW.Data;
using NW.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MW.WebApp.Controllers
{
    public class CategoryController : NorthwindController
    {
        public ActionResult Index()
        {
            IEnumerable<Category> cats;
            try
            {
                cats = r.GetAllCategories();
            } catch
            {
                return View("Error");
            }
            return View(cats);
        }
    }
}