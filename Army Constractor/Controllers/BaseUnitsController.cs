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
    public class BaseUnitsController : Controller
    {
        private ArmyConstractorDB db = new ArmyConstractorDB();

        // GET: BaseUnits
        public ActionResult Index()
        {
            return View(db.BaseUnits.ToList());
        }

        // GET: BaseUnits/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BaseUnit baseUnit = db.BaseUnits.Find(id);
            if (baseUnit == null)
            {
                return HttpNotFound();
            }
            return View(baseUnit);
        }

        // GET: BaseUnits/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BaseUnits/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "BaseUnitID,BaseUnitName,BaseUnitRank,BaseUnitAttBonus,BaseUnitDefBonus,BaseUnitAbsorb,BaseUnitArmorIgnore,BaseUnitMove,BaseUnitBraveryBonus,Description")] BaseUnit baseUnit)
        {
            if (ModelState.IsValid)
            {
                db.BaseUnits.Add(baseUnit);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(baseUnit);
        }

        // GET: BaseUnits/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BaseUnit baseUnit = db.BaseUnits.Find(id);
            if (baseUnit == null)
            {
                return HttpNotFound();
            }
            return View(baseUnit);
        }

        // POST: BaseUnits/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "BaseUnitID,BaseUnitName,BaseUnitRank,BaseUnitAttBonus,BaseUnitDefBonus,BaseUnitAbsorb,BaseUnitArmorIgnore,BaseUnitMove,BaseUnitBraveryBonus,Description")] BaseUnit baseUnit)
        {
            if (ModelState.IsValid)
            {
                db.Entry(baseUnit).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(baseUnit);
        }

        // GET: BaseUnits/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BaseUnit baseUnit = db.BaseUnits.Find(id);
            if (baseUnit == null)
            {
                return HttpNotFound();
            }
            return View(baseUnit);
        }

        // POST: BaseUnits/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            BaseUnit baseUnit = db.BaseUnits.Find(id);
            db.BaseUnits.Remove(baseUnit);
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
