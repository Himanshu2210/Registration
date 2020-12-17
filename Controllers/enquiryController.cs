using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Registration.Models;

namespace Registration.Controllers
{
    public class enquiryController : Controller
    {
        // GET: enquiry
        public ActionResult Index()
        {
           return View("View_enquiry");
        }

        // GET: enquiry/Details/5
        public ActionResult NewUser(FormCollection collection)
        {
            student_model student1 = new student_model();
            student service = new student();
            student1.city = collection["city"];
            student1.cnfpsw = collection["cnfpsw"];
            student1.fname = collection["fname"];
            student1.lname = collection["lname"];
            student1.psw = collection["psw"];
            student1.gender = collection["gender"];
            student1.gender1 = collection["gender1"];
            service.NewStudent(student1);
            //collection.
            return View();
        }
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: enquiry/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: enquiry/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: enquiry/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: enquiry/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: enquiry/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: enquiry/Delete/5
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
