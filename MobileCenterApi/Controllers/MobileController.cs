using MobileCenterApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MobileCenterApi.Controllers
{
    public class MobileController : Controller
    {

        MobileCenterApiEntities obj = new MobileCenterApiEntities();

        // GET: Mobile
        public ActionResult ProductList()
        {
            return View(obj.TableMobiles.ToList());
        }

        public ActionResult ClientView()
        {
            return View(obj.TableMobiles.ToList());
        }


        // GET: Mobile/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Mobile/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Mobile/Create
        [HttpPost]
        public ActionResult Create([Bind(Exclude = "id")]TableMobile mobile)
        {

            if (!ModelState.IsValid)
                return View();
            obj.TableMobiles.Add(mobile);
            obj.SaveChanges();
            return RedirectToAction("ProductList");

        }

        // GET: Mobile/Edit/5
        public ActionResult Edit(int id)
        {
            var IdToEdit = (from m in obj.TableMobiles where m.id == id select m).First();
            return View(IdToEdit);
        }

        // POST: Mobile/Edit/5
        [HttpPost]
        public ActionResult Edit(TableMobile mobile)
        {

            var orignalRecord = (from m in obj.TableMobiles where m.id == mobile.id select m).First();

            if (!ModelState.IsValid)
                return View(orignalRecord);
            obj.Entry(orignalRecord).CurrentValues.SetValues(mobile);

            obj.SaveChanges();
            return RedirectToAction("ProductList");


        }

        // GET: Mobile/Delete/5
        public ActionResult Delete(TableMobile mobile)
        {

            var d = obj.TableMobiles.Where(x => x.id == mobile.id).FirstOrDefault();
            obj.TableMobiles.Remove(d);
            obj.SaveChanges();
            return RedirectToAction("ProductList");

        }

        // POST: Mobile/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
