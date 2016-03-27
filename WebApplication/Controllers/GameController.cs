using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication.WebService;

namespace WebApplication.Controllers
{
    public class GameController : Controller
    {
        // GET: Game
        public ActionResult Index()
        {
            ServiceClient webService = new ServiceClient();
            ViewBag.Tournois = webService.GetTournois().Select(t => new SelectListItem { Text = t.Nom, Value = t.ID.ToString()});
            webService.Close();
            return View();
        }

        // POST: Game/Bet
        [HttpPost]
        public ActionResult Bet(string Tournois)
        {
            ServiceClient webService = new ServiceClient();
            TournoiContract tournoi= webService.GetTournoi(int.Parse(Tournois));
            var jedis= tournoi.Matchs.Select(m => m.Jedi1).Union(tournoi.Matchs.Select(m => m.Jedi2));
            ViewBag.Tournoi = tournoi;
            ViewBag.Jedis = jedis.Select(t => new SelectListItem { Text = t.Nom, Value = t.ID.ToString() });
            webService.Close();
            return View();
        }

        // POST: Game/Result
        [HttpPost]
        public ActionResult Result(string Tournoi, string Jedis)
        {
            ServiceClient webService = new ServiceClient();
            Random rdm = new Random();
            ViewBag.Tournoi = webService.GetTournoi(int.Parse(Tournoi));
            ViewBag.Jedi = webService.GetJedi(int.Parse(Jedis));
            ViewBag.HasWin = (rdm.Next(2)==1);
            webService.Close();
            return View();
        }
    }
}