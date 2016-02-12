using JediTournamentEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebService.Contract;

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
            jedi.ID = j.ID;
            jedi.Nom = j.Nom;
            jedi.IsSith = j.IsSith;
            return jedi;
        }

        public static Jedi JediContractToJedi(JediContract j)
        {
            Jedi jedi = new Jedi();
            jedi.ID = j.ID;
            jedi.Nom = j.Nom;
            jedi.IsSith = j.IsSith;
            return jedi;
        }
    }
}