using MobileCenterApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MobileCenterApi.Controllers
{
    public class HomeController : Controller
    {
        MobileCenterApiEntities obj = new MobileCenterApiEntities();

        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        public ActionResult ContactRecord()
        {
            

            return View(obj.TableContacts.ToList());
        }

        // GET: Complaint/Delete/5
        public ActionResult Delete(TableContact contact)
        {
            var d = obj.TableContacts.Where(x => x.Id == contact.Id).FirstOrDefault();
            obj.TableContacts.Remove(d);
            obj.SaveChanges();
            return RedirectToAction("ContactRecord");

        }


        public ActionResult Contact()
        {
            ViewBag.Title = "Contact Page";
            return View();
        }


        [HttpPost]
        public ActionResult SendMessage(Contact contact)
        {
            //Pass the data to store the record into the table 

            contact.Addcontact("insert into TableContact(Name,Email,Mssg) values('" + contact.Namefield + "','" + contact.Emailfield + "','" + contact.Messagefield + "')");

            return View("thanks");



        }

        public ActionResult thanks()
        {
            ViewBag.Title = "Contact Page";

            return View();
        }



    }
}
