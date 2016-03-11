using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WebService.Contract;

namespace WebService
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom d'interface "ITournoiService" à la fois dans le code et le fichier de configuration.
    [ServiceContract]
    public interface ITournoiService
    {
        [OperationContract]
        List<TournoiContract> GetTournois();

        [OperationContract]
        TournoiContract AddTournoi(TournoiContract tournoi);

        [OperationContract]
        void DelTournoi(TournoiContract tournoi);

        [OperationContract]
        void UpdateTournoi(TournoiContract tournoi);
    }
}
