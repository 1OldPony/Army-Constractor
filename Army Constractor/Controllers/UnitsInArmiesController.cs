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
    public class UnitsInArmiesController : Controller
    {
        private ArmyConstractorDB db = new ArmyConstractorDB();

        // GET: UnitsInArmies
        public ActionResult Index()
        {
            return View(db.UnitsInArmies.ToList());
        }

        // GET: UnitsInArmies/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UnitsInArmy unitsInArmy = db.UnitsInArmies.Find(id);
            if (unitsInArmy == null)
            {
                return HttpNotFound();
            }
            return View(unitsInArmy);
        }

        // GET: UnitsInArmies/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UnitsInArmies/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "UnitsInArmyID")] UnitsInArmy unitsInArmy)
        {
            if (ModelState.IsValid)
            {
                db.UnitsInArmies.Add(unitsInArmy);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(unitsInArmy);
        }

        // GET: UnitsInArmies/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UnitsInArmy unitsInArmy = db.UnitsInArmies.Find(id);
            if (unitsInArmy == null)
            {
                return HttpNotFound();
            }
            return View(unitsInArmy);
        }

        // POST: UnitsInArmies/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "UnitsInArmyID")] UnitsInArmy unitsInArmy)
        {
            if (ModelState.IsValid)
            {
                db.Entry(unitsInArmy).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(unitsInArmy);
        }

        // GET: UnitsInArmies/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UnitsInArmy unitsInArmy = db.UnitsInArmies.Find(id);
            if (unitsInArmy == null)
            {
                return HttpNotFound();
            }
            return View(unitsInArmy);
        }

        // POST: UnitsInArmies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            UnitsInArmy unitsInArmy = db.UnitsInArmies.Find(id);
            db.UnitsInArmies.Remove(unitsInArmy);
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
