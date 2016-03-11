using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WebService.Adapter;
using WebService.Contract;

namespace WebService
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "MatchService" à la fois dans le code, le fichier svc et le fichier de configuration.
    // REMARQUE : pour lancer le client test WCF afin de tester ce service, sélectionnez MatchService.svc ou MatchService.svc.cs dans l'Explorateur de solutions et démarrez le débogage.
    public class MatchService : IMatchService
    {
        private JediTournamentManager jtm;

        public MatchService()
        {
            jtm = new JediTournamentManager();
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

        public List<MatchContract> GetMatch()
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
    }
}
