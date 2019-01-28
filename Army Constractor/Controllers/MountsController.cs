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
    public class MountsController : Controller
    {
        private ArmyConstractorDB db = new ArmyConstractorDB();

        // GET: Mounts
        public ActionResult Index(int? sortOption)
        {
            var mounts = db.Mounts.AsQueryable();

            if (sortOption == null)
                return View(mounts.ToList());
            else if (sortOption == 1)
            {
                mounts = mounts.OrderBy(u => u.MountName);
                return View(mounts.ToList());
            }
            else
            {
                List<Mount> OrderedMelWeap = mounts.ToList();
                OrderedMelWeap.Sort(delegate (Mount x, Mount y)
                {
                    return x.Price.CompareTo(y.Price);
                });
                return View(OrderedMelWeap);
            }
        }

        // GET: Mounts/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Mount mount = db.Mounts.Find(id);
            if (mount == null)
            {
                return HttpNotFound();
            }
            return View(mount);
        }

        // GET: Mounts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Mounts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MountID,MountName,MountRange,MountRank,MountArmorIgnore,MountAbsorb,MountDefBonus,MountAttBonus,MountMove,Flying,Description")] Mount mount)
        {
            if (ModelState.IsValid)
            {
                db.Mounts.Add(mount);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(mount);
        }

        // GET: Mounts/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Mount mount = db.Mounts.Find(id);
            if (mount == null)
            {
                return HttpNotFound();
            }
            return View(mount);
        }

        // POST: Mounts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MountID,MountName,MountRange,MountRank,MountArmorIgnore,MountAbsorb,MountDefBonus,MountAttBonus,MountMove,Flying,Description")] Mount mount)
        {
            if (ModelState.IsValid)
            {
                db.Entry(mount).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(mount);
        }

        // GET: Mounts/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Mount mount = db.Mounts.Find(id);
            if (mount == null)
            {
                return HttpNotFound();
            }
            return View(mount);
        }

        // POST: Mounts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Mount mount = db.Mounts.Find(id);
            db.Mounts.Remove(mount);
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
