using JediTournamentEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebService.Contract;

namespace WebService.Adapter
{
    public class MatchAdapter
    {
        private MatchAdapter()
        {
        }

        public static MatchContract MatchToMatchContract(Match m)
        {
            MatchContract match = new MatchContract();
            match.ID = m.ID;
            match.Jedi1 = JediAdapter.JediToJediContract(m.Jedi1);
            match.Jedi2 = JediAdapter.JediToJediContract(m.Jedi2);
            match.Vainqueur = JediAdapter.JediToJediContract(m.Vainqueur);
            match.PhaseTournoi = (EPhaseTournoiContract)m.PhaseTournoi;
            match.Stade = StadeAdapter.StadeToStadeContract(m.Stade);

            return match;
        }

        public static Match MatchContractToMatch(MatchContract m)
        {
            Match match = new Match();
            match.ID = m.ID;
            match.Jedi1 = JediAdapter.JediContractToJedi(m.Jedi1);
            match.Jedi2 = JediAdapter.JediContractToJedi(m.Jedi2);
            match.Vainqueur = JediAdapter.JediContractToJedi(m.Vainqueur);
            match.PhaseTournoi = (EPhaseTournoi)m.PhaseTournoi;
            match.Stade = StadeAdapter.StadeContractToStade(m.Stade);

            return match;
        }
    }
}