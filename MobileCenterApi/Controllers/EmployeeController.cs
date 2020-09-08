using MobileCenterApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MobileCenterApi.Controllers
{
    public class EmployeeController : Controller
    {
        MobileCenterApiEntities obj = new MobileCenterApiEntities();
        // GET: Employee
        public ActionResult EmployeeList()
        {
            return View(obj.TableEmployees.ToList());
        }

        // GET: Employee/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Employee/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Employee/Create
        [HttpPost]
        public ActionResult Create([Bind(Exclude = "id")] TableEmployee employee)
        {

            if (!ModelState.IsValid)
                return View();
            obj.TableEmployees.Add(employee);
            obj.SaveChanges();
            return RedirectToAction("EmployeeList");

        }

        // GET: Employee/Edit/5
        public ActionResult Edit(int id)
        {
            var IdToEdit = (from m in obj.TableEmployees where m.ID== id select m).First();
            return View(IdToEdit);
        }

        // POST: Employee/Edit/5
        [HttpPost]
        public ActionResult Edit(TableEmployee employee)
        {

            var orignalRecord = (from m in obj.TableEmployees where m.ID == employee.ID select m).First();

            if (!ModelState.IsValid)
                return View(orignalRecord);
            obj.Entry(orignalRecord).CurrentValues.SetValues(employee);

            obj.SaveChanges();
            return RedirectToAction("EmployeeList");
        }

        // GET: Employee/Delete/5
        public ActionResult Delete(TableEmployee employee)
        {
            var d =obj.TableEmployees.Where(x => x.ID == employee.ID).FirstOrDefault();
            obj.TableEmployees.Remove(d);
            obj.SaveChanges();
            return RedirectToAction("EmployeeList");
            
        }

        // POST: Employee/Delete/5
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
