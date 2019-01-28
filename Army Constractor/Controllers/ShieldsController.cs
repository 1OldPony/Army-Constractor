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
    public class ShieldsController : Controller
    {
        private ArmyConstractorDB db = new ArmyConstractorDB();

        // GET: Shields
        public ActionResult Index(int? sortOption)
        {
            var shields = db.Shields.AsQueryable();

            if (sortOption == null)
                return View(shields.ToList());
            else if (sortOption == 1)
            {
                shields = shields.OrderBy(u => u.ShieldName);
                return View(shields.ToList());
            }
            else
            {
                List<Shield> OrderedMelWeap = shields.ToList();
                OrderedMelWeap.Sort(delegate (Shield x, Shield y)
                {
                    return x.Price.CompareTo(y.Price);
                });
                return View(OrderedMelWeap);
            }
        }

        // GET: Shields/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Shield shield = db.Shields.Find(id);
            if (shield == null)
            {
                return HttpNotFound();
            }
            return View(shield);
        }

        // GET: Shields/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Shields/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ShieldID,ShieldName,ShieldDefBonus,Description")] Shield shield)
        {
            if (ModelState.IsValid)
            {
                db.Shields.Add(shield);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(shield);
        }

        // GET: Shields/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Shield shield = db.Shields.Find(id);
            if (shield == null)
            {
                return HttpNotFound();
            }
            return View(shield);
        }

        // POST: Shields/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ShieldID,ShieldName,ShieldDefBonus,Description")] Shield shield)
        {
            if (ModelState.IsValid)
            {
                db.Entry(shield).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(shield);
        }

        // GET: Shields/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Shield shield = db.Shields.Find(id);
            if (shield == null)
            {
                return HttpNotFound();
            }
            return View(shield);
        }

        // POST: Shields/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Shield shield = db.Shields.Find(id);
            db.Shields.Remove(shield);
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
