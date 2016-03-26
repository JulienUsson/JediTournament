using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WebService.Adapter;
using WebService.Contract;

namespace WebService
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "Service1" dans le code, le fichier svc et le fichier de configuration.
    // REMARQUE : pour lancer le client test WCF afin de tester ce service, sélectionnez Service1.svc ou Service1.svc.cs dans l'Explorateur de solutions et démarrez le débogage.
    public class Service : IService
    {
        private JediTournamentManager jtm;
        private UtilisateurManager um;

        public Service()
        {
            jtm = new JediTournamentManager();
            um = new UtilisateurManager();
        }

        public JediContract AddJedis(JediContract jedi)
        {
            jtm.AddJedi(JediAdapter.JediContractToJedi(jedi));
            return jedi;
        }

        public void DelJedis(JediContract jedi)
        {
            jtm.DelJedi(JediAdapter.JediContractToJedi(jedi));
        }

        public List<JediContract> GetJedis()
        {
            List<JediContract> jedis = new List<JediContract>();
            foreach (var j in jtm.GetJedis())
            {
                jedis.Add(JediAdapter.JediToJediContract(j));
            }
            return jedis;
        }

        public void UpdateJedis(JediContract jedi)
        {
            jtm.UpdateJedi(JediAdapter.JediContractToJedi(jedi));
        }

        public MatchContract AddMatch(MatchContract match)
        {
            jtm.AddMatch(MatchAdapter.MatchContractToMatch(match));

            return match;
        }

        public void DelMatch(MatchContract match)
        {
            jtm.DelMatch(MatchAdapter.MatchContractToMatch(match));
        }

        public List<MatchContract> GetMatchs()
        {
            List<MatchContract> matchs = new List<MatchContract>();
            foreach (var match in jtm.GetMatchs())
            {
                matchs.Add(MatchAdapter.MatchToMatchContract(match));
            }
            return matchs;
        }

        public void UpdateMatch(MatchContract match)
        {
            jtm.UpdateMatch(MatchAdapter.MatchContractToMatch(match));
        }
        public StadeContract AddStades(StadeContract sta)
        {
            jtm.AddStade(StadeAdapter.StadeContractToStade(sta));
            return sta;
        }

        public void DelStades(StadeContract sta)
        {
            jtm.DelStade(StadeAdapter.StadeContractToStade(sta));
        }

        public List<StadeContract> GetStades()
        {
            List<StadeContract> stades = new List<StadeContract>();
            foreach (var sta in jtm.GetStades())
            {
                stades.Add(StadeAdapter.StadeToStadeContract(sta));
            }
            return stades;
        }

        public void UpdateStades(StadeContract sta)
        {
            jtm.UpdateStade(StadeAdapter.StadeContractToStade(sta));
        }

        public TournoiContract AddTournoi(TournoiContract tournoi)
        {
            jtm.AddTournoi(TournoiAdapter.TournoiContractToTournoi(tournoi));

            return tournoi;
        }

        public void DelTournoi(TournoiContract tournoi)
        {
            jtm.DelTournoi(TournoiAdapter.TournoiContractToTournoi(tournoi));
        }

        public List<TournoiContract> GetTournois()
        {
            List<TournoiContract> tournois = new List<TournoiContract>();

            foreach (var t in jtm.GetTournois())
            {
                tournois.Add(TournoiAdapter.TournoiToTournoiContract(t));
            }

            return tournois;
        }

        public void UpdateTournoi(TournoiContract tournoi)
        {
            jtm.UpdateTournoi(TournoiAdapter.TournoiContractToTournoi(tournoi));
        }

        public UtilisateurContract AddUtilisateur(UtilisateurContract user)
        {
            var u = UtilisateurAdapter.UtilisateurContractToUtilisateur(user);
            um.AddUser(u.Login, u.Password);

            return user;
        }

        public bool CheckUtilisateurs(UtilisateurContract user)
        {
            var u = UtilisateurAdapter.UtilisateurContractToUtilisateur(user);
            return um.CheckConnexionUser(u.Login, u.Password);
        }
    }
}
