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
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "TournoiService" à la fois dans le code, le fichier svc et le fichier de configuration.
    // REMARQUE : pour lancer le client test WCF afin de tester ce service, sélectionnez TournoiService.svc ou TournoiService.svc.cs dans l'Explorateur de solutions et démarrez le débogage.
    public class TournoiService : ITournoiService
    {
        private JediTournamentManager jtm;

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
    }
}
