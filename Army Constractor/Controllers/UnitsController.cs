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
    public class UnitsController : Controller
    {
        private ArmyConstractorDB db = new ArmyConstractorDB();

        // GET: Units
        public ActionResult Index(int? sortOrder)
        {
            var units = db.Units.Include(u => u.Armor).Include(u => u.Mount).Include(u => u.RangeWeapon).Include(u => u.RecrutType).Include(u => u.Shield).Include(u => u.MeleeWeapon);

            if (sortOrder == null)
                return View(units.ToList());
            else
            {
                if (sortOrder == 1)
                {
                    List<Unit> orderedUnits = units.ToList();
                    orderedUnits.Sort(delegate(Unit x, Unit y)
                    {
                        if (x.Price == null && y.Price == null) return 0;
                        else if (x.Price == null) return -1;
                        else if (y.Price == null) return 1;
                        else return x.Price.CompareTo(y.Price);
                    });
                    return View(orderedUnits);
                }
                    else
                {
                    units = units.OrderBy(o => o.UnitName);
                    return View(units.ToList());
                }

            }
            
        }

        // GET: Units/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Unit unit = db.Units.Find(id);
            if (unit == null)
            {
                return HttpNotFound();
            }
            return View(unit);
        }

        // GET: Units/Create
        public ActionResult Create()
        {
            ViewBag.ArmorID = new SelectList(db.Armors, "ArmorID", "ArmorName");
            ViewBag.MountID = new SelectList(db.Mounts, "MountID", "MountName");
            ViewBag.MeleeWeaponID = new SelectList(db.MeleeWeapons, "MeleeWeaponID", "MelWeapName");
            ViewBag.SecondWeaponID = new SelectList(db.MeleeWeapons, "MeleeWeaponID", "MelWeapName");
            ViewBag.RangeWeaponID = new SelectList(db.RangeWeapons, "RangeWeaponID", "RanWeapName");
            ViewBag.RecrutTypeID = new SelectList(db.RecrutTypes, "RecrutTypeID", "RecrutTypeName");
            ViewBag.ShieldID = new SelectList(db.Shields, "ShieldID", "ShieldName");
            return View();
        }

        // POST: Units/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "UnitID,UnitName,RecrutTypeID,ArmorID,MeleeWeaponID,RangeWeaponID,SecondWeaponID,ShieldID,MountID,NumberOfCombatants,Description")] Unit unit)
        {
            if (ModelState.IsValid)
            {
                db.Units.Add(unit);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ArmorID = new SelectList(db.Armors, "ArmorID", "ArmorName", unit.ArmorID);
            ViewBag.MountID = new SelectList(db.Mounts, "MountID", "MountName", unit.MountID);
            ViewBag.MeleeWeaponID = new SelectList(db.MeleeWeapons, "MeleeWeaponID", "MelWeapName", unit.MeleeWeaponID);
            ViewBag.SecondWeaponID = new SelectList(db.MeleeWeapons, "MeleeWeaponID", "MelWeapName", unit.SecondWeaponID);
            ViewBag.RangeWeaponID = new SelectList(db.RangeWeapons, "RangeWeaponID", "RanWeapName", unit.RangeWeaponID);
            ViewBag.RecrutTypeID = new SelectList(db.RecrutTypes, "RecrutTypeID", "RecrutTypeName", unit.RecrutTypeID);
            ViewBag.ShieldID = new SelectList(db.Shields, "ShieldID", "ShieldName", unit.ShieldID);
            return View(unit);
        }

        // GET: Units/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Unit unit = db.Units.Find(id);
            if (unit == null)
            {
                return HttpNotFound();
            }
            ViewBag.ArmorID = new SelectList(db.Armors, "ArmorID", "ArmorName", unit.ArmorID);
            ViewBag.MountID = new SelectList(db.Mounts, "MountID", "MountName", unit.MountID);
            ViewBag.MeleeWeaponID = new SelectList(db.MeleeWeapons, "MeleeWeaponID", "MelWeapName", unit.MeleeWeaponID);
            ViewBag.SecondWeaponID = new SelectList(db.MeleeWeapons, "MeleeWeaponID", "MelWeapName", unit.SecondWeaponID);
            ViewBag.RangeWeaponID = new SelectList(db.RangeWeapons, "RangeWeaponID", "RanWeapName", unit.RangeWeaponID);
            ViewBag.RecrutTypeID = new SelectList(db.RecrutTypes, "RecrutTypeID", "RecrutTypeName", unit.RecrutTypeID);
            ViewBag.ShieldID = new SelectList(db.Shields, "ShieldID", "ShieldName", unit.ShieldID);
            return View(unit);
        }

        // POST: Units/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "UnitID,UnitName,RecrutTypeID,ArmorID,MeleeWeaponID,RangeWeaponID,SecondWeaponID,ShieldID,MountID,NumberOfCombatants,Description")] Unit unit)
        {
            if (ModelState.IsValid)
            {
                db.Entry(unit).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ArmorID = new SelectList(db.Armors, "ArmorID", "ArmorName", unit.ArmorID);
            ViewBag.MountID = new SelectList(db.Mounts, "MountID", "MountName", unit.MountID);
            ViewBag.MeleeWeaponID = new SelectList(db.MeleeWeapons, "MeleeWeaponID", "MelWeapName", unit.MeleeWeaponID);
            ViewBag.SecondWeaponID = new SelectList(db.MeleeWeapons, "MeleeWeaponID", "MelWeapName", unit.SecondWeaponID);
            ViewBag.RangeWeaponID = new SelectList(db.RangeWeapons, "RangeWeaponID", "RanWeapName", unit.RangeWeaponID);
            ViewBag.RecrutTypeID = new SelectList(db.RecrutTypes, "RecrutTypeID", "RecrutTypeName", unit.RecrutTypeID);
            ViewBag.ShieldID = new SelectList(db.Shields, "ShieldID", "ShieldName", unit.ShieldID);
            return View(unit);
        }

        // GET: Units/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Unit unit = db.Units.Find(id);
            if (unit == null)
            {
                return HttpNotFound();
            }
            return View(unit);
        }

        // POST: Units/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Unit unit = db.Units.Find(id);
            db.Units.Remove(unit);
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
