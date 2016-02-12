using JediTournamentEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebService.Adapter
{
    public class JediAdapter
    {
        private JediAdapter()
        {
        }

        public static JediContract JediToJediContract(Jedi j)
        {
            JediContract jedi = new JediContract();
            jedi.Nom = j.Nom;
            jedi.IsSith = j.IsSith;
            return jedi;
        }
    }
}