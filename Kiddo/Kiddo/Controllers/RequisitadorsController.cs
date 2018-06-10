using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Kiddo.Models;

namespace Kiddo.Controllers
{
    public class RequisitadorsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Requisitadors
        public ActionResult Index()
        {
            return View(db.Requisitadors.ToList());
        }

        // GET: Requisitadors/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Requisitador requisitador = db.Requisitadors.Find(id);
            if (requisitador == null)
            {
                return HttpNotFound();
            }
            return View(requisitador);
        }

        // GET: Requisitadors/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Requisitadors/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Contact,Payment")] Requisitador requisitador)
        {
            if (ModelState.IsValid)
            {
                db.Requisitadors.Add(requisitador);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(requisitador);
        }

        // GET: Requisitadors/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Requisitador requisitador = db.Requisitadors.Find(id);
            if (requisitador == null)
            {
                return HttpNotFound();
            }
            return View(requisitador);
        }

        // POST: Requisitadors/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Contact,Payment")] Requisitador requisitador)
        {
            if (ModelState.IsValid)
            {
                db.Entry(requisitador).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(requisitador);
        }

        // GET: Requisitadors/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Requisitador requisitador = db.Requisitadors.Find(id);
            if (requisitador == null)
            {
                return HttpNotFound();
            }
            return View(requisitador);
        }

        // POST: Requisitadors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Requisitador requisitador = db.Requisitadors.Find(id);
            db.Requisitadors.Remove(requisitador);
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
