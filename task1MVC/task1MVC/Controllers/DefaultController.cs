using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace task1MVC.Content
{
    public class DefaultController : Controller
    {
        // GET: Default
        public string Index()
        {
            return ("<a download='jkjhniihjuliuui.png' href='jkjhniihjuliuui.png'><img src='return (\"<a download='juice.png' href='jkjhniihjuliuui.png'><img src='jkjhniihjuliuui.png'/></a>\");\r\n'/></a>");
        }

        public ActionResult AboutUs()
        {
            return Content("About");
        }
        public ActionResult ContactUs()
        {
            return Content("Contact");
        }
    }
}