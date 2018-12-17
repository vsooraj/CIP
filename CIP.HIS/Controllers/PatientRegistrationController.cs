using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CIP.HIS.Controllers
{
    public class PatientRegistrationController : Controller
    {
        // GET: PatientRegistration
        public ActionResult Index()
        {
            return View();
        }

        // GET: PatientRegistration/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PatientRegistration/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PatientRegistration/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PatientRegistration/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PatientRegistration/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PatientRegistration/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PatientRegistration/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}