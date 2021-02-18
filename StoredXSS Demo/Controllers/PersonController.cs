using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using StoredXSS_Demo.Models;
using System.Data;
using System.Web.Configuration;

namespace StoredXSS_Demo.Controllers
{
    public class PersonController : Controller
    {
        //
        // GET: /Person/
        SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["U001"].ConnectionString);
        DataTable dt = new DataTable();

        public ActionResult Index()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from Person",con);
            da.Fill(dt);
            return View(dt);
        }

        //
        // GET: /Person/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Person/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Person/Create
        [ValidateInput(false)]
        [HttpPost]
        public ActionResult Create(Person p)
        {
            SqlCommand cmd = new SqlCommand(" insert into Person (FullName,Job) values ('"+p.FullName+"','"+p.Job+"') ",con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            return RedirectToAction("Index");
            
        }

        //
        // GET: /Person/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Person/Edit/5

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
        // GET: /Person/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Person/Delete/5

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
