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
    public class RangeWeaponsController : Controller
    {
        private ArmyConstractorDB db = new ArmyConstractorDB();

        // GET: RangeWeapons
        public ActionResult Index(int? sortOption)
        {
            var rangedWeapons = db.RangeWeapons.AsQueryable();

            if (sortOption == null)
                return View(rangedWeapons.ToList());
            else if (sortOption == 1)
            {
                rangedWeapons = rangedWeapons.OrderBy(u => u.RanWeapName);
                return View(rangedWeapons.ToList());
            }
            else
            {
                List<RangeWeapon> OrderedMelWeap = rangedWeapons.ToList();
                OrderedMelWeap.Sort(delegate (RangeWeapon x, RangeWeapon y)
                {
                    return x.Price.CompareTo(y.Price);
                });
                return View(OrderedMelWeap);
            }
        }

        // GET: RangeWeapons/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RangeWeapon rangeWeapon = db.RangeWeapons.Find(id);
            if (rangeWeapon == null)
            {
                return HttpNotFound();
            }
            return View(rangeWeapon);
        }

        // GET: RangeWeapons/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RangeWeapons/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "RangeWeaponID,RanWeapName,RanWeapAttBonus,RanWeapRange,RanWeapArmorIgnore,Description")] RangeWeapon rangeWeapon)
        {
            if (ModelState.IsValid)
            {
                db.RangeWeapons.Add(rangeWeapon);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(rangeWeapon);
        }

        // GET: RangeWeapons/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RangeWeapon rangeWeapon = db.RangeWeapons.Find(id);
            if (rangeWeapon == null)
            {
                return HttpNotFound();
            }
            return View(rangeWeapon);
        }

        // POST: RangeWeapons/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "RangeWeaponID,RanWeapName,RanWeapAttBonus,RanWeapRange,RanWeapArmorIgnore,Description")] RangeWeapon rangeWeapon)
        {
            if (ModelState.IsValid)
            {
                db.Entry(rangeWeapon).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(rangeWeapon);
        }

        // GET: RangeWeapons/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RangeWeapon rangeWeapon = db.RangeWeapons.Find(id);
            if (rangeWeapon == null)
            {
                return HttpNotFound();
            }
            return View(rangeWeapon);
        }

        // POST: RangeWeapons/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            RangeWeapon rangeWeapon = db.RangeWeapons.Find(id);
            db.RangeWeapons.Remove(rangeWeapon);
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
