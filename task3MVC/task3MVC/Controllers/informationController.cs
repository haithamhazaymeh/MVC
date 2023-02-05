using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using task3MVC.Models;

namespace task3MVC.Controllers
{
    public class informationController : Controller
    {

        public ActionResult search() 
        {
            return View();
        }

        public ActionResult search(string Name)
        {
           
            return View();
        }



        private jordaninfoEntities2 db = new jordaninfoEntities2();

        // GET: information
        public ActionResult Index(string searchBy,string search)
        {
            if (searchBy == "Jop Titel")
            {

                var result = db.information.Where(x => x.JopTitel.Contains(search) || search == null).ToList();

                return View("index", result);


            }
            else if (searchBy == "First Name")
            {

                return View(db.information.Where(x => x.First_Name.Contains(search) || search == null).ToList());

            } else
            {
                return View(db.information.Where(x => x.Email.Contains(search) || search == null).ToList());

            }
        }

        // GET: information/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            information information = db.information.Find(id);
            if (information == null)
            {
                return HttpNotFound();
            }
            return View(information);
        }

        // GET: information/Create
        public ActionResult Create()
        {
            return View();
        }

        public ActionResult Create2()
        {
            return View();
        }

        // POST: information/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,First_Name,Last_Name,Email,Phone,Age,JopTitel,Gender,Imges,CV")] information information , HttpPostedFileBase Imges , HttpPostedFileBase CV)
        {
            if (ModelState.IsValid)
            {

                if (Imges != null && Imges.ContentLength > 0)
                {
                    var fileName = Path.GetFileName(Imges.FileName);
                    var path = Path.Combine(Server.MapPath("~/Imges"), fileName);
                    Imges.SaveAs(path);
                    information.Imges = fileName;
                }
                if (CV != null && CV.ContentLength > 0)
                {
                    var fileName = CV.FileName;
                    var path = Path.Combine(Server.MapPath("~/CV"), fileName);
                    CV.SaveAs(path);
                    information.CV = fileName;
                }


                db.information.Add(information);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(information);
        }

        // GET: information/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            information information = db.information.Find(id);
            if (information == null)
            {
                return HttpNotFound();
            }
            return View(information);
        }

        // POST: information/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,First_Name,Last_Name,Email,Phone,Age,JopTitel,Gender")] information information)
        {
            if (ModelState.IsValid)
            {
                db.Entry(information).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(information);
        }

        // GET: information/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            information information = db.information.Find(id);
            if (information == null)
            {
                return HttpNotFound();
            }
            return View(information);
        }

        // POST: information/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            information information = db.information.Find(id);
            db.information.Remove(information);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

    }
}
