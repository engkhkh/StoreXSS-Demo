using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StoredXSS_Demo.Controllers
{
    public class ReflectedXSSController : Controller
    {
        //
        // GET: /ReflectedXSS/
        [ValidateInput(false;)]
        public ActionResult Index()
        {
            if (Request.QueryString["txtsearch"] != null)
            {
                //unvalidated
                ViewBag.results = "Search Results For : " + Request.QueryString["txtsearch"];

            }
            return View();
        }

        //
        // GET: /ReflectedXSS/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /ReflectedXSS/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /ReflectedXSS/Create

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

        //
        // GET: /ReflectedXSS/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /ReflectedXSS/Edit/5

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

        //
        // GET: /ReflectedXSS/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /ReflectedXSS/Delete/5

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
