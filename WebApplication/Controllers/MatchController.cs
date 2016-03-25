using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication.WebService;

namespace WebApplication.Controllers
{
    public class MatchController : Controller
    {
        // GET: Match
        public ActionResult Index()
        {
            ServiceClient webService = new ServiceClient();
            ViewBag.Matchs = webService.GetMatchs();
            webService.Close();
            return View();
        }

        // GET: Match/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Match/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Match/Create
        [HttpPost]
        public ActionResult Create(MatchContract match)
        {
            ServiceClient webService = new ServiceClient();

            try
            {
                webService.AddMatch(match);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Match/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Match/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, MatchContract match)
        {
            ServiceClient webService = new ServiceClient();

            try
            {
                webService.UpdateMatch(match);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Match/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Match/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, MatchContract match)
        {
            ServiceClient webService = new ServiceClient();

            try
            {
                webService.DelMatch(match);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
