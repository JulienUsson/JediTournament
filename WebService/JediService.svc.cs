using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WebService.Adapter;

namespace WebService
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "Service1" dans le code, le fichier svc et le fichier de configuration.
    // REMARQUE : pour lancer le client test WCF afin de tester ce service, sélectionnez Service1.svc ou Service1.svc.cs dans l'Explorateur de solutions et démarrez le débogage.
    public class JediService : IJediService
    {
        private JediTournamentManager jtm;

        public JediService()
        {
            jtm = new JediTournamentManager();
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
    }
}
