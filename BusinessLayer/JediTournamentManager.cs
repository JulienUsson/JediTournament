using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using JediTournamentEntities;
using System.Collections.ObjectModel;

namespace BusinessLayer
{
    public class JediTournamentManager
    {
        public IEnumerable<Stade> GetStades()
        {
            return DalManager.Instance.GetStades();
        }

        public IEnumerable<Jedi> GetSiths()
        {
            return DalManager.Instance.GetJedis().Where(j => j.IsSith);
        }

        public IEnumerable<Jedi> GetJedis()
        {
            return DalManager.Instance.GetJedis();
        }

        public IEnumerable<Match> GetMatchs()
        {
            return DalManager.Instance.GetMatchs();
        }

        public void AddJedi(Jedi jedi)
        {
            DalManager.Instance.AddJedi(jedi);
        }

        public void UpdateJedi(Jedi jedi)
        {
            DalManager.Instance.UpdateJedi(jedi);
        }

        public void DelJedi(Jedi jedi)
        {
            DalManager.Instance.DeleteJedi(jedi);
        }

        public void AddMatch(Match match)
        {
            DalManager.Instance.AddMatch(match);
        }

        public void DelMatch(Match match)
        {
            DalManager.Instance.DeleteMatch(match);
        }

        public void UpdateMatch(Match match)
        {
            DalManager.Instance.UpdateMatch(match);
        }

        public void UpdateTournoi(Tournoi tournoi)
        {
            DalManager.Instance.UpdateTournoi(tournoi);
        }

        public void AddStade(Stade stade)
        {
            DalManager.Instance.AddStade(stade);
        }

        public void DelStade(Stade stade)
        {
            DalManager.Instance.DeleteStade(stade);
        }

        public void UpdateStade(Stade stade)
        {
            DalManager.Instance.UpdateStade(stade);
        }

        public void AddTournoi(Tournoi tournoi)
        {
            DalManager.Instance.AddTournoi(tournoi);
        }

        public void DelTournoi(Tournoi tournoi)
        {
            DalManager.Instance.DeleteTournoi(tournoi);
        }

        public IEnumerable<Tournoi> GetTournois()
        {
            return DalManager.Instance.GetTournois();
        }

        public Tournoi GetTournoi(int id) 
        {
            return DalManager.Instance.GetTournoi(id);
        }
    }
}
