using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace task1MVC.Controllers
{
    public class haithamController : Controller
    {
        // GET: haitham
        public ActionResult action1()
        {
            return Content("action1");
        }
        public ActionResult action2()
        {
            return Content("action2");
        }

        public ActionResult action3()
        {
            return Content("action3");
        }

        public ActionResult action4()
        {
            return Content("action4");
        }



    }
}