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
    public class MeleeWeaponsController : Controller
    {
        private ArmyConstractorDB db = new ArmyConstractorDB();

        // GET: MeleeWeapons
        public ActionResult Index(int? sortOption)
        {
            var meleeWeapons = db.MeleeWeapons.AsQueryable();

            if (sortOption == null)
                return View(meleeWeapons.ToList());
            else if (sortOption == 1)
            {
                meleeWeapons = meleeWeapons.OrderBy(u => u.MelWeapName);
                return View(meleeWeapons.ToList());
            }
            else
            {
                List<MeleeWeapon> OrderedMelWeap = meleeWeapons.ToList();
                OrderedMelWeap.Sort(delegate (MeleeWeapon x, MeleeWeapon y)
                {
                    return x.Price.CompareTo(y.Price);
                });
                return View(OrderedMelWeap);
            }
        }

        // GET: MeleeWeapons/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MeleeWeapon meleeWeapon = db.MeleeWeapons.Find(id);
            if (meleeWeapon == null)
            {
                return HttpNotFound();
            }
            return View(meleeWeapon);
        }

        // GET: MeleeWeapons/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MeleeWeapons/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MeleeWeaponID,MelWeapName,Range,MelWeapArmorIgnore,TwoHanded,Pare,Description")] MeleeWeapon meleeWeapon)
        {
            if (ModelState.IsValid)
            {
                db.MeleeWeapons.Add(meleeWeapon);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(meleeWeapon);
        }

        // GET: MeleeWeapons/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MeleeWeapon meleeWeapon = db.MeleeWeapons.Find(id);
            if (meleeWeapon == null)
            {
                return HttpNotFound();
            }
            return View(meleeWeapon);
        }

        // POST: MeleeWeapons/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MeleeWeaponID,MelWeapName,Range,MelWeapArmorIgnore,TwoHanded,Pare,Description")] MeleeWeapon meleeWeapon)
        {
            if (ModelState.IsValid)
            {
                db.Entry(meleeWeapon).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(meleeWeapon);
        }

        // GET: MeleeWeapons/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MeleeWeapon meleeWeapon = db.MeleeWeapons.Find(id);
            if (meleeWeapon == null)
            {
                return HttpNotFound();
            }
            return View(meleeWeapon);
        }

        // POST: MeleeWeapons/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MeleeWeapon meleeWeapon = db.MeleeWeapons.Find(id);
            db.MeleeWeapons.Remove(meleeWeapon);
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
