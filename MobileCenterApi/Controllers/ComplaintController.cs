using MobileCenterApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MobileCenterApi.Controllers
{
    public class ComplaintController : Controller
    {
        // GET: Complaint
        MobileCenterApiEntities obj = new MobileCenterApiEntities();

        public ActionResult ComplaintList()
        {
            return View(obj.TableComplaints.ToList());
        }

        // GET: Complaint/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Complaint/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Complaint/Create
        [HttpPost]
        public ActionResult Create([Bind(Exclude = "id")]TableComplaint complaint)
        {
            if (!ModelState.IsValid)
                return View();
            obj.TableComplaints.Add(complaint);
            obj.SaveChanges();
            return View();
        }

        // GET: Complaint/Edit/5
        public ActionResult Edit(int id)
        {
            var IdToEdit = (from m in obj.TableComplaints where m.id == id select m).First();
            return View(IdToEdit);
        }

        // POST: Complaint/Edit/5
        [HttpPost]
        public ActionResult Edit(TableComplaint complaint)
        {

            var orignalRecord = (from m in obj.TableComplaints where m.id == complaint.id select m).First();

            if (!ModelState.IsValid)
                return View(orignalRecord);
            obj.Entry(orignalRecord).CurrentValues.SetValues(complaint);

            obj.SaveChanges();
            return RedirectToAction("ComplaintList");


        }

        // GET: Complaint/Delete/5
        public ActionResult Delete(TableComplaint complaint)
        {
            var d = obj.TableComplaints.Where(x => x.id == complaint.id).FirstOrDefault();
            obj.TableComplaints.Remove(d);
            obj.SaveChanges();
            return RedirectToAction("ComplaintList");

        }

        // POST: Complaint/Delete/5
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
