using JediTournamentEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebService.Contract;

namespace WebService.Adapter
{
    public class UtilisateurAdapter
    {
        private UtilisateurAdapter()
        {
        }

        public static UtilisateurContract UtilisateurToUtilisateurContract(Utilisateur u)
        {
            UtilisateurContract user = new UtilisateurContract();
            user.ID = u.ID;
            user.Login = u.Login;
            user.Password = u.Password;

            return user;
        }

        public static Utilisateur UtilisateurContractToUtilisateur(UtilisateurContract u)
        {
            Utilisateur user = new Utilisateur();
            user.ID = u.ID;
            user.Login = u.Login;
            user.Password = u.Password;

            return user;
        }
    }
}