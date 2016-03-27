using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WebService.Contract;

namespace WebService
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom d'interface "IService1" à la fois dans le code et le fichier de configuration.
    [ServiceContract]
    public interface IService
    {
        [OperationContract]
        List<JediContract> GetJedis();

        [OperationContract]
        JediContract GetJedi(int id);

        [OperationContract]
        JediContract AddJedis(JediContract jedi);

        [OperationContract]
        void UpdateJedis(JediContract jedi);

        [OperationContract]
        void DelJedis(JediContract jedi);

        [OperationContract]
        List<StadeContract> GetStades();

        [OperationContract]
        StadeContract AddStades(StadeContract sta);

        [OperationContract]
        void UpdateStades(StadeContract sta);

        [OperationContract]
        void DelStades(StadeContract sta);

        [OperationContract]
        List<TournoiContract> GetTournois();

        [OperationContract]
        TournoiContract GetTournoi(int id);

        [OperationContract]
        TournoiContract AddTournoi(TournoiContract tournoi);

        [OperationContract]
        void DelTournoi(TournoiContract tournoi);

        [OperationContract]
        void UpdateTournoi(TournoiContract tournoi);

        [OperationContract]
        bool CheckUtilisateurs(UtilisateurContract user);

        [OperationContract]
        UtilisateurContract AddUtilisateur(UtilisateurContract user);

        [OperationContract]
        List<MatchContract> GetMatchs();

        [OperationContract]
        MatchContract AddMatch(MatchContract match);

        [OperationContract]
        void UpdateMatch(MatchContract match);

        [OperationContract]
        void DelMatch(MatchContract match);
    }
}
