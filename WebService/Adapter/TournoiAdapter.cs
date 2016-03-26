using JediTournamentEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebService.Contract;

namespace WebService.Adapter
{
    public class TournoiAdapter
    {
        private TournoiAdapter()
        {
        }
    
        public static TournoiContract TournoiToTournoiContract(Tournoi t)
        {
            TournoiContract tournoi = new TournoiContract();
            tournoi.ID = t.ID;
            tournoi.Nom = t.Nom;
            foreach (var m in t.Matchs)
            {
                tournoi.Matchs.Add(MatchAdapter.MatchToMatchContract(m));
            }

            return tournoi;
        } 

        public static Tournoi TournoiContractToTournoi(TournoiContract t)
        {
            Tournoi tournoi = new Tournoi();
            tournoi.ID = t.ID;
            tournoi.Nom = t.Nom;
            foreach (var m in t.Matchs)
            {
                tournoi.Matchs.Add(MatchAdapter.MatchContractToMatch(m));
            }

            return tournoi;
        }
    }
}