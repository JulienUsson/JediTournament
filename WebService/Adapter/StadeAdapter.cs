using JediTournamentEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebService.Contract;

namespace WebService.Adapter
{
    public class StadeAdapter
    {
        public StadeAdapter()
        {
        }

        public static StadeContract StadeToStadeContract(Stade s)
        {
            StadeContract stade = new StadeContract();
            stade.ID = s.ID;
            stade.NbPlaces = s.NbPlaces;
            stade.Planete = s.Planete;
            return stade;
        }

        public static Stade StadeContractToStade(StadeContract s)
        {
            Stade stade = new Stade();
            stade.ID = s.ID;
            stade.NbPlaces = s.NbPlaces;
            stade.Planete = s.Planete;
            return stade;
        }
    }
}