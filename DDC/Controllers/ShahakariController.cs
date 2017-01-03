using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DDC.Controllers
{
    public class ShahakariController : Controller
    {
        // GET: Shahakari
        public ActionResult Index()
        {
            return View();
        }

        // GET: Shahakari/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Shahakari/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Shahakari/Create
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

        // GET: Shahakari/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Shahakari/Edit/5
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

        // GET: Shahakari/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Shahakari/Delete/5
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
