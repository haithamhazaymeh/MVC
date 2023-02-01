using MVCtask2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCtask2.Controllers
{
    public class studentController : Controller
    {
        // GET: student
        public ActionResult Index()
        {

            List<Student> ss = new List<Student>();

            ss.Add(new Student() { ID = 1, Name = "mosab", Major = "civil engineer", faculity = "engineering" });
            ss.Add(new Student() { ID = 2, Name = "ashraf", Major = "maths", faculity = "maths" });
            ss.Add(new Student() { ID = 3, Name = "Yazeed", Major = "civil engineer", faculity = "engineering" });


            return View(ss);
        }
    }
}