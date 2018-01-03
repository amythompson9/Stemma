using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Stemma.Models;

namespace Stemma.Controllers
{
    public class HobbyTablesController : Controller
    {
        private STEMMAEntities db = new STEMMAEntities();

        // GET: HobbyTables
        public ActionResult Index()
        {
            return View(db.HobbyTables.ToList());
        }

        // GET: HobbyTables/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HobbyTable hobbyTable = db.HobbyTables.Find(id);
            if (hobbyTable == null)
            {
                return HttpNotFound();
            }
            return View(hobbyTable);
        }

        // GET: HobbyTables/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HobbyTables/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "HobbyID,PlaySports,InAShow,Travel,OutdoorPerson,TravelAbroad,Passions,Talents,Trophies,Exercise,FamilyVacation,ChildhoodVacation,AnythingElse")] HobbyTable hobbyTable)
        {
            if (ModelState.IsValid)
            {
                db.HobbyTables.Add(hobbyTable);
                db.SaveChanges();
                //next line changed from Index to Details and id added
                return RedirectToAction("Details", new { id = hobbyTable.HobbyID });
            }

            return View(hobbyTable);
        }

        // GET: HobbyTables/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HobbyTable hobbyTable = db.HobbyTables.Find(id);
            if (hobbyTable == null)
            {
                return HttpNotFound();
            }
            return View(hobbyTable);
        }

        // POST: HobbyTables/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "HobbyID,PlaySports,InAShow,Travel,OutdoorPerson,TravelAbroad,Passions,Talents,Trophies,Exercise,FamilyVacation,ChildhoodVacation,AnythingElse")] HobbyTable hobbyTable)
        {
            if (ModelState.IsValid)
            {
                db.Entry(hobbyTable).State = EntityState.Modified;
                db.SaveChanges();
                //next line changed from Index to Details, and id
                return RedirectToAction("Details", new { id = hobbyTable.HobbyID });
            }
            return View(hobbyTable);
        }

        // GET: HobbyTables/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HobbyTable hobbyTable = db.HobbyTables.Find(id);
            if (hobbyTable == null)
            {
                return HttpNotFound();
            }
            return View(hobbyTable);
        }

        // POST: HobbyTables/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            HobbyTable hobbyTable = db.HobbyTables.Find(id);
            db.HobbyTables.Remove(hobbyTable);
            db.SaveChanges();
            //changed Index to Create on next line
            return RedirectToAction("Create");
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
