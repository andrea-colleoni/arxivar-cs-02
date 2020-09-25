using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Esercizio_03;

namespace _09_web.Controllers
{
    public class AutomobiliController : Controller
    {
        private AutoDb db = new AutoDb();

        // GET: Automobili
        public ActionResult Index()
        {
            return View(db.Automobili.ToList());
        }

        // GET: Automobili/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Automobile automobile = db.Automobili.Find(id);
            if (automobile == null)
            {
                return HttpNotFound();
            }
            return View(automobile);
        }

        // GET: Automobili/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Automobili/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdAutomobile,Marca,Modello,Cilindrata,CapacitaSerbatoio,LivelloCarburante,ConsumoKmLitro")] Automobile automobile)
        {
            if (ModelState.IsValid)
            {
                db.Automobili.Add(automobile);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(automobile);
        }

        // GET: Automobili/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Automobile automobile = db.Automobili.Find(id);
            if (automobile == null)
            {
                return HttpNotFound();
            }
            return View(automobile);
        }

        // POST: Automobili/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdAutomobile,Marca,Modello,Cilindrata,CapacitaSerbatoio,LivelloCarburante,ConsumoKmLitro")] Automobile automobile)
        {
            if (ModelState.IsValid)
            {
                db.Entry(automobile).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(automobile);
        }

        // GET: Automobili/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Automobile automobile = db.Automobili.Find(id);
            if (automobile == null)
            {
                return HttpNotFound();
            }
            return View(automobile);
        }

        // POST: Automobili/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Automobile automobile = db.Automobili.Find(id);
            db.Automobili.Remove(automobile);
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
