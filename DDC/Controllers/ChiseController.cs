using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DDC.Controllers
{
    public class ChiseController : Controller
    {
        // GET: Chise
        public ActionResult Index()
        {
            return View();
        }

        // GET: Chise/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Chise/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Chise/Create
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

        // GET: Chise/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Chise/Edit/5
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

        // GET: Chise/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Chise/Delete/5
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
