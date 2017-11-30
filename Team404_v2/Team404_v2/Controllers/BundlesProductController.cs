using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Team404_v2.Models;

namespace Team404_v2.Controllers
{
    public class BundlesProductController : Controller
    {
        private MyModel db = new MyModel();

        // GET: BundlesProduct
        public ActionResult Index()
        {
            return View(db.Bundles.ToList());
        }

        // GET: BundlesProduct/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Bundles bundles = db.Bundles.Find(id);
            if (bundles == null)
            {
                return HttpNotFound();
            }
            return View(bundles);
        }

        // GET: BundlesProduct/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BundlesProduct/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,ProductCategory,BundleTitle,BundlePrice,BundleLink,ProductName1,ProductName2,ProductName3,Wishlist,RemoveDetails,MiniDescription11,MiniDescription12,MiniDescription13,MiniDescription21,MiniDescription22,MiniDescription23,MiniDescription31,MiniDescription32,MiniDescription33")] Bundles bundles)
        {
            if (ModelState.IsValid)
            {
                db.Bundles.Add(bundles);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(bundles);
        }

        // GET: BundlesProduct/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Bundles bundles = db.Bundles.Find(id);
            if (bundles == null)
            {
                return HttpNotFound();
            }
            return View(bundles);
        }

        // POST: BundlesProduct/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,ProductCategory,BundleTitle,BundlePrice,BundleLink,ProductName1,ProductName2,ProductName3,Wishlist,RemoveDetails,MiniDescription11,MiniDescription12,MiniDescription13,MiniDescription21,MiniDescription22,MiniDescription23,MiniDescription31,MiniDescription32,MiniDescription33")] Bundles bundles)
        {
            if (ModelState.IsValid)
            {
                db.Entry(bundles).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(bundles);
        }

        // GET: BundlesProduct/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Bundles bundles = db.Bundles.Find(id);
            if (bundles == null)
            {
                return HttpNotFound();
            }
            return View(bundles);
        }

        // POST: BundlesProduct/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Bundles bundles = db.Bundles.Find(id);
            db.Bundles.Remove(bundles);
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
