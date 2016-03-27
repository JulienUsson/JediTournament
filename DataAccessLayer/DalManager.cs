﻿using JediTournamentEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DalManager
    {
        private static DalManager _instance;
        private static readonly Object padlock = new Object();

        private DataAccess _DataAccess;

        public Utilisateur GetUser(string login)
        {
            return _DataAccess.GetUser(login);
        }

        private DalManager()
        {
            _DataAccess = new AzureDataAccess();
        }

        public void AddUser(Utilisateur user)
        {
            _DataAccess.AddUser(user);
        }

        public List<Jedi> GetJedis()
        {
            return _DataAccess.GetJedis();
        }

        public Jedi GetJedi(int id)
        {
            return _DataAccess.GetJedi(id);
        }

        public List<Match> GetMatchs()
        {
            return _DataAccess.GetMatchs();
        }

        public List<Stade> GetStades()
        {
            return _DataAccess.GetStades();
        }

        public List<Tournoi> GetTournois()
        {
            return _DataAccess.GetTournois();
        }

        public Tournoi GetTournoi(int id)
        {
            return _DataAccess.GetTournoi(id);
        }

        public void AddJedi(Jedi jedi)
        {
            _DataAccess.AddJedi(jedi);
        }

        public void AddMatch(Match match)
        {
            _DataAccess.AddMatch(match);
        }

        public void AddStade(Stade stade)
        {
            _DataAccess.AddStade(stade);
        }

        public void AddTournoi(Tournoi tournoi)
        {
            _DataAccess.AddTournoi(tournoi);
        }

        public void UpdateJedi(Jedi jedi)
        {
            _DataAccess.UpdateJedi(jedi);
        }

        public void UpdateMatch(Match match)
        {
            _DataAccess.UpdateMatch(match);
        }

        public void UpdateStade(Stade stade)
        {
            _DataAccess.UpdateStade(stade);
        }

        public void UpdateTournoi(Tournoi tournoi)
        {
            _DataAccess.UpdateTournoi(tournoi);
        }

        public void DeleteJedi(Jedi jedi)
        {
            _DataAccess.DeleteJedi(jedi);
        }

        public void DeleteMatch(Match match)
        {
            _DataAccess.DeleteMatch(match);
        }

        public void DeleteStade(Stade stade)
        {
            _DataAccess.DeleteStade(stade);
        }

        public void DeleteTournoi(Tournoi tournoi)
        {
            _DataAccess.DeleteTournoi(tournoi);
        }

        public static DalManager Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (padlock)
                    {
                        if (_instance == null)
                        {
                            _instance = new DalManager();
                        }
                    }
                }
                return _instance;
            }
        }
    }
}
