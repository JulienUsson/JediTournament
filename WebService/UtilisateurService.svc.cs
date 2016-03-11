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
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "UtilisateurService" à la fois dans le code, le fichier svc et le fichier de configuration.
    // REMARQUE : pour lancer le client test WCF afin de tester ce service, sélectionnez UtilisateurService.svc ou UtilisateurService.svc.cs dans l'Explorateur de solutions et démarrez le débogage.
    public class UtilisateurService : IUtilisateurService
    {
        private UtilisateurManager usem;

        public UtilisateurContract AddUtilisateur(UtilisateurContract user)
        {
            var login = UtilisateurAdapter.UtilisateurContractToUtilisateur(user).Login;
            var password = UtilisateurAdapter.UtilisateurContractToUtilisateur(user).Password;
            usem.AddUser(login, password);

            return user;
        }

        public bool CheckUtilisateurs(UtilisateurContract user)
        {
            var login = UtilisateurAdapter.UtilisateurContractToUtilisateur(user).Login;
            var password = UtilisateurAdapter.UtilisateurContractToUtilisateur(user).Password;
            usem.CheckConnexionUser(login, password);
        }
    }
}
