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
    public class JediService : IJediService
    {
        private JediTournamentManager jtm;

        public JediService()
        {
            jtm = new JediTournamentManager();
        }

        public JediContract AddJedis(JediContract j)
        {
            JediContract jedi = new JediContract();
            jtm.AddJedi(JediAdapter.JediContractToJedi(j));
            return jedi;
        }

        public bool DelJedis(JediContract jedi)
        {
            throw new NotImplementedException();
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

        public JediContract UpdateJedis(JediContract jedi)
        {
            throw new NotImplementedException();
        }
    }
}
