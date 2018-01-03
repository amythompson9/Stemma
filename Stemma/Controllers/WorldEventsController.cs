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
    public class WorldEventsController : Controller
    {
        private STEMMAEntities db = new STEMMAEntities();

        // GET: WorldEvents
        public ActionResult Index()
        {
            //we're gonna switch this from showing
            return View(db.WorldEvents.ToList());
        }

        // GET: WorldEvents/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WorldEvent worldEvent = db.WorldEvents.Find(id);
            if (worldEvent == null)
            {
                return HttpNotFound();
            }
            return View(worldEvent);
        }

        // GET: WorldEvents/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: WorldEvents/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "WorldEventID,September11,MoonLanding,NixonResigns,ElvisDies,ChallengerExplodes,WorldWar2Ends,KennedyDies,NotableElection,MLKAssassination,Y2K,BerlinWall,OJSimpsonCarChase,EndOfProhibition,AnythingElse")] WorldEvent worldEvent)
        {
            if (ModelState.IsValid)
            {
                db.WorldEvents.Add(worldEvent);
                db.SaveChanges();
                //you changed the following instructions from "Index" to "Details"
                //Kyle recommends we delete the Index Action from this page
                //and delete the Index files too
                return RedirectToAction("Details", new { id = worldEvent.WorldEventID });
            }

            return View(worldEvent);
        }

        // GET: WorldEvents/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WorldEvent worldEvent = db.WorldEvents.Find(id);
            if (worldEvent == null)
            {
                return HttpNotFound();
            }
            return View(worldEvent);
        }

        // POST: WorldEvents/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "WorldEventID,September11,MoonLanding,NixonResigns,ElvisDies,ChallengerExplodes,WorldWar2Ends,KennedyDies,NotableElection,MLKAssassination,Y2K,BerlinWall,OJSimpsonCarChase,EndOfProhibition,AnythingElse")] WorldEvent worldEvent)
        {
            if (ModelState.IsValid)
            {
                db.Entry(worldEvent).State = EntityState.Modified;
                db.SaveChanges();
                //next line changed from Index to Details with ID
                return RedirectToAction("Details", new { id = worldEvent.WorldEventID });
            }
            return View(worldEvent);
        }

        // GET: WorldEvents/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WorldEvent worldEvent = db.WorldEvents.Find(id);
            if (worldEvent == null)
            {
                return HttpNotFound();
            }
            return View(worldEvent);
        }

        // POST: WorldEvents/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            WorldEvent worldEvent = db.WorldEvents.Find(id);
            db.WorldEvents.Remove(worldEvent);
            db.SaveChanges();
            //next line changed from Index to Create
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
