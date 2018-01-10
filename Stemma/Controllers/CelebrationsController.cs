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
    public class CelebrationsController : Controller
    {
        private STEMMAEntities db = new STEMMAEntities();

        // GET: Celebrations
        public ActionResult Index()
        {
            return View(db.Celebrations.ToList());
        }

        // GET: Celebrations/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Celebration celebration = db.Celebrations.Find(id);
            if (celebration == null)
            {
                return HttpNotFound();
            }
            return View(celebration);
        }

        // GET: Celebrations/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Celebrations/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CelebrationID,HolidayRecently,PartyRecently,MilestoneRecently,CelebrateChristmas,CelebrateNYE,CelebrateThanksgiving,CelebrateValentine,CelebrateEaster,CelebrateIndependenceDay,CelebrateHalloween,CelebrateMemorialDay,CelebrateLaborDay,CelebrateMothersDay,CelebrateFathersDay,CelebrateChaunakah,CelebratePassover,CelebrateRoshHashanah,CelerateYomKippur,CelebrateRamadan,CelebrateEID,CelebrateSTPat,CelebrateBirthdays,CelebrateChineseNewYear,CelebrateQuinceanera,CelebrateBarBatMitzvah,CelebrateDayOfTheDead,CelebrateVeteransDay,CelebrateCincoDeMayo,AnythingElse")] Celebration celebration)
        {
            if (ModelState.IsValid)
            {
                db.Celebrations.Add(celebration);
                db.SaveChanges();
                //changed Index to Details/id on next line
                return RedirectToAction("Details", new { id = celebration.CelebrationID });
            }

            return View(celebration);
        }

        // GET: Celebrations/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Celebration celebration = db.Celebrations.Find(id);
            if (celebration == null)
            {
                return HttpNotFound();
            }
            return View(celebration);
        }

        // POST: Celebrations/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CelebrationID,HolidayRecently,PartyRecently,MilestoneRecently,CelebrateChristmas,CelebrateNYE,CelebrateThanksgiving,CelebrateValentine,CelebrateEaster,CelebrateIndependenceDay,CelebrateHalloween,CelebrateMemorialDay,CelebrateLaborDay,CelebrateMothersDay,CelebrateFathersDay,CelebrateChaunakah,CelebratePassover,CelebrateRoshHashanah,CelerateYomKippur,CelebrateRamadan,CelebrateEID,CelebrateSTPat,CelebrateBirthdays,CelebrateChineseNewYear,CelebrateQuinceanera,CelebrateBarBatMitzvah,CelebrateDayOfTheDead,CelebrateVeteransDay,CelebrateCincoDeMayo,AnythingElse")] Celebration celebration)
        {
            if (ModelState.IsValid)
            {
                db.Entry(celebration).State = EntityState.Modified;
                db.SaveChanges();
                //changed Index to Details/id on next line
                return RedirectToAction("Details", new { id = celebration.CelebrationID });
            }
            return View(celebration);
        }

        // GET: Celebrations/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Celebration celebration = db.Celebrations.Find(id);
            if (celebration == null)
            {
                return HttpNotFound();
            }
            return View(celebration);
        }

        // POST: Celebrations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Celebration celebration = db.Celebrations.Find(id);
            db.Celebrations.Remove(celebration);
            db.SaveChanges();
            //changed Index to Create on next line.
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
