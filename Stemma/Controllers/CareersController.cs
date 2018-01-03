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
    public class CareersController : Controller
    {
        private STEMMAEntities db = new STEMMAEntities();

        // GET: Careers
        public ActionResult Index()
        {
            return View(db.Careers.ToList());
        }

        // GET: Careers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Career career = db.Careers.Find(id);
            if (career == null)
            {
                return HttpNotFound();
            }
            return View(career);
        }

        // GET: Careers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Careers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CareerID,AttendedCollege,Graduations,HaveJob,HadJob,Accomplishments,FirstDayOfSchool,ArmedForces,Volunteer,Legacies,TechSchool,LicensesCertifications,FirstJob,WorstJob")] Career career)
        {
            if (ModelState.IsValid)
            {
                db.Careers.Add(career);
                db.SaveChanges();
                //change next line from Index to Details, to skip the Index page
                //don't forget to change the Edit part the same way
                return RedirectToAction("Details", new { id = career.CareerID });
            }

            return View(career);
        }

        // GET: Careers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Career career = db.Careers.Find(id);
            if (career == null)
            {
                return HttpNotFound();
            }
            return View(career);
        }

        // POST: Careers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CareerID,AttendedCollege,Graduations,HaveJob,HadJob,Accomplishments,FirstDayOfSchool,ArmedForces,Volunteer,Legacies,TechSchool,LicensesCertifications,FirstJob,WorstJob")] Career career)
        {
            if (ModelState.IsValid)
            {
                db.Entry(career).State = EntityState.Modified;
                db.SaveChanges();
                //you changed this next line to Details/id. Hopefully it takes you to the right screen.
                return RedirectToAction("Details", new { id = career.CareerID });
            }
            return View(career);
        }

        // GET: Careers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Career career = db.Careers.Find(id);
            if (career == null)
            {
                return HttpNotFound();
            }
            return View(career);
        }

        // POST: Careers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Career career = db.Careers.Find(id);
            db.Careers.Remove(career);
            db.SaveChanges();
            //you changed Index to Create in the line below
            //but a better outcome will be to not let people delete it in the first place
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
