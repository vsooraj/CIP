using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CIP.HIS.Controllers
{
    public class RadiologyController : Controller
    {
        // GET: Radiology
        public ActionResult Index()
        {
            return View();
        }

        // GET: Radiology/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Radiology/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Radiology/Create
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

        // GET: Radiology/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Radiology/Edit/5
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

        // GET: Radiology/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Radiology/Delete/5
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