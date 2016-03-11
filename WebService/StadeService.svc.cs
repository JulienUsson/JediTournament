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
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "StadeService" à la fois dans le code, le fichier svc et le fichier de configuration.
    // REMARQUE : pour lancer le client test WCF afin de tester ce service, sélectionnez StadeService.svc ou StadeService.svc.cs dans l'Explorateur de solutions et démarrez le débogage.
    public class StadeService : IStadeService
    {
        private JediTournamentManager jtm;

        public StadeService()
        {
            jtm = new JediTournamentManager();
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
    }
}
