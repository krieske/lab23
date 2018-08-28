using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab23.Models;

namespace Lab23.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            lab23Entities ORM = new lab23Entities();
            ViewBag.Items = ORM.items.ToList();

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult NewUser()
        {
            return View();
        }

        public ActionResult SaveNewUser(newuser newUser)
        {
            lab23Entities ORM = new lab23Entities();

            //To Do: Validation!

            ORM.newusers.Add(newUser);

            ORM.SaveChanges();
            return RedirectToAction("Index");


        }
    }
}