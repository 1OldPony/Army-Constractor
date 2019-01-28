﻿using System;
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
    public class RecrutTypesController : Controller
    {
        private ArmyConstractorDB db = new ArmyConstractorDB();

        // GET: RecrutTypes
        public ActionResult Index(int? sortOption)
        {
            var recrutTypes = db.RecrutTypes.AsQueryable();

            if (sortOption == null)
                return View(recrutTypes.ToList());
            else if (sortOption == 1)
            {
                recrutTypes = recrutTypes.OrderBy(u => u.RecrutTypeName);
                return View(recrutTypes.ToList());
            }
            else
            {
                List<RecrutType> OrderedMelWeap = recrutTypes.ToList();
                OrderedMelWeap.Sort(delegate (RecrutType x, RecrutType y)
                {
                    return x.Price.CompareTo(y.Price);
                });
                return View(OrderedMelWeap);
            }
        }

        // GET: RecrutTypes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RecrutType recrutType = db.RecrutTypes.Find(id);
            if (recrutType == null)
            {
                return HttpNotFound();
            }
            return View(recrutType);
        }

        // GET: RecrutTypes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RecrutTypes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "RecrutTypeID,RecrutTypeName,RecrutTypeRank,RecrutTypeAttBonus,RecrutTypeDefBonus,RecrutTypeAbsorb,RecrutTypeArmorIgnore,RecrutTypeMove,RecrutTypeBraveryBonus,Description")] RecrutType recrutType)
        {
            if (ModelState.IsValid)
            {
                db.RecrutTypes.Add(recrutType);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(recrutType);
        }

        // GET: RecrutTypes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RecrutType recrutType = db.RecrutTypes.Find(id);
            if (recrutType == null)
            {
                return HttpNotFound();
            }
            return View(recrutType);
        }

        // POST: RecrutTypes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "RecrutTypeID,RecrutTypeName,RecrutTypeRank,RecrutTypeAttBonus,RecrutTypeDefBonus,RecrutTypeAbsorb,RecrutTypeArmorIgnore,RecrutTypeMove,RecrutTypeBraveryBonus,Description")] RecrutType recrutType)
        {
            if (ModelState.IsValid)
            {
                db.Entry(recrutType).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(recrutType);
        }

        // GET: RecrutTypes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RecrutType recrutType = db.RecrutTypes.Find(id);
            if (recrutType == null)
            {
                return HttpNotFound();
            }
            return View(recrutType);
        }

        // POST: RecrutTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            RecrutType recrutType = db.RecrutTypes.Find(id);
            db.RecrutTypes.Remove(recrutType);
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
