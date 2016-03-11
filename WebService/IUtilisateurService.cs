using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WebService.Contract;

namespace WebService
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom d'interface "IUtilisateurService" à la fois dans le code et le fichier de configuration.
    [ServiceContract]
    public interface IUtilisateurService
    {
        [OperationContract]
        bool CheckUtilisateurs();

        [OperationContract]
        UtilisateurContract AddUtilisateur(UtilisateurContract user);
    }
}
