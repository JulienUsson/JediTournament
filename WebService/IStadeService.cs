using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WebService.Contract;

namespace WebService
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom d'interface "IStadeService" à la fois dans le code et le fichier de configuration.
    [ServiceContract]
    public interface IStadeService
    {
        [OperationContract]
        List<StadeContract> GetStades();

        [OperationContract]
        StadeContract AddStades(StadeContract sta);

        [OperationContract]
        void UpdateStades(StadeContract sta);

        [OperationContract]
        void DelStades(StadeContract sta);
    }
}
