using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication.WebService;

namespace WebApplication.Controllers
{
    public class JediController : Controller
    {

        // GET: Jedi
        public ActionResult Index()
        {
            ServiceClient webService = new ServiceClient();

            ViewBag.Jedis = webService.GetJedis();
            webService.Close();
            return View();
        }

        // GET: Jedi/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Jedi/Create
        public ActionResult Create()
        {    
            return View();
        }

        // POST: Jedi/Create
        [HttpPost]
        public ActionResult Create(JediContract jedi)
        {
            ServiceClient webService = new ServiceClient();

            try
            {
                webService.AddJedis(jedi);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Jedi/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Jedi/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, JediContract jedi)
        {
            ServiceClient webService = new ServiceClient();

            try
            {
                webService.UpdateJedis(jedi);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Jedi/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Jedi/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, JediContract jedi)
        {
            ServiceClient webService = new ServiceClient();

            try
            {
                webService.DelJedis(jedi);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
