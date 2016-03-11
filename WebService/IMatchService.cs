using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WebService.Contract;

namespace WebService
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom d'interface "IMatchService" à la fois dans le code et le fichier de configuration.
    [ServiceContract]
    public interface IMatchService
    {
        [OperationContract]
        List<MatchContract> GetMatch();

        [OperationContract]
        MatchContract AddMatch(MatchContract match);

        [OperationContract]
        void UpdateMatch(MatchContract match);

        [OperationContract]
        void DelMatch(MatchContract match);
    }
}
