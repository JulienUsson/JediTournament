using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication.WebService;

namespace WebApplication.Controllers
{
    public class StadeController : Controller
    {
        // GET: Stade
        public ActionResult Index()
        {
            ServiceClient webService = new ServiceClient();
            ViewBag.Stades = webService.GetStades();
            webService.Close();
            return View();
        }

        // GET: Stade/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Stade/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Stade/Create
        [HttpPost]
        public ActionResult Create(StadeContract stade)
        {
            ServiceClient webService = new ServiceClient();

            try
            {
                webService.AddStades(stade);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Stade/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Stade/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, StadeContract stade)
        {
            ServiceClient webService = new ServiceClient();

            try
            {
                webService.UpdateStades(stade);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Stade/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Stade/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, StadeContract stade)
        {
            ServiceClient webService = new ServiceClient();
            try
            {
                webService.DelStades(stade);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
