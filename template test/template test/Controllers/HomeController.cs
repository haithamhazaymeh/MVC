using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using template_test.Models;

namespace template_test.Controllers
{
    public class HomeController : Controller
    {

        RestoranEntities2 rest = new RestoranEntities2();
        public ActionResult Index()
        {
            var products = rest.Product.ToList();
            var category = rest.category.ToList();
            return View(Tuple.Create(products,category));
        }
        public ActionResult book()
        {
            return View();
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}