using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Army_Constractor.Models;

namespace Army_Constractor.Controllers
{
    public class ArmiesController : Controller
    {
        private ArmyConstractorDB db = new ArmyConstractorDB();

        // GET: Armies
        public ActionResult Index()
        {
            var armies = db.Armies.Include(a => a.UnitsInArmy);
            return View(armies.ToList());
        }

        // GET: Armies/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Army army = db.Armies.Find(id);
            if (army == null)
            {
                return HttpNotFound();
            }
            return View(army);
        }

        // GET: Armies/Create
        public ActionResult Create()
        {
            ViewBag.UnitsInArmyID = new SelectList(db.UnitsInArmies, "UnitsInArmyID", "UnitsInArmyID");
            return View();
        }

        // POST: Armies/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ArmyID,ArmyName,UnitsInArmyID,Description")] Army army)
        {
            if (ModelState.IsValid)
            {
                db.Armies.Add(army);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.UnitsInArmyID = new SelectList(db.UnitsInArmies, "UnitsInArmyID", "UnitsInArmyID", army.UnitsInArmyID);
            return View(army);
        }

        // GET: Armies/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Army army = db.Armies.Find(id);
            if (army == null)
            {
                return HttpNotFound();
            }
            ViewBag.UnitsInArmyID = new SelectList(db.UnitsInArmies, "UnitsInArmyID", "UnitsInArmyID", army.UnitsInArmyID);
            return View(army);
        }

        // POST: Armies/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ArmyID,ArmyName,UnitsInArmyID,Description")] Army army)
        {
            if (ModelState.IsValid)
            {
                db.Entry(army).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.UnitsInArmyID = new SelectList(db.UnitsInArmies, "UnitsInArmyID", "UnitsInArmyID", army.UnitsInArmyID);
            return View(army);
        }

        // GET: Armies/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Army army = db.Armies.Find(id);
            if (army == null)
            {
                return HttpNotFound();
            }
            return View(army);
        }

        // POST: Armies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Army army = db.Armies.Find(id);
            db.Armies.Remove(army);
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
