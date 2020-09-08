using MobileCenterApi.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MobileCenterApi.Controllers
{
    public class LoginController : Controller
    {
        MobileCenterApiEntities obj = new MobileCenterApiEntities();
        Contact contact = new Contact();
        // GET: Login
        public ActionResult AdminLogin()
        {
            return View();
        }


        public ActionResult Dashboard()
        {
            return View();
        }

        public ActionResult Wrong()
        {
            return View();
        }





        [HttpPost]
        public ActionResult loginVerfication(Login login)
        {
            //Pass the data to store the record into the table 

            DataTable tbl = new DataTable();
            tbl = contact.LoginVerification("select * from TableLogin where Name='" + login.UserField + "'and Password='" + login.PasswordField + "'");

            if (tbl.Rows.Count > 0)
            {
                return View("Dashboard");
            }
            else
            {
                return View("Wrong");
            }



        }



    }
}