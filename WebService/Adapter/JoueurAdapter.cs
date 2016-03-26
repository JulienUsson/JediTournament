using JediTournamentEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebService.Contract;

namespace WebService.Adapter
{
    public class JoueurAdapter
    {
        private JoueurAdapter()
        {
        }

        public static JoueurContract JoueurToJoueurContract(Joueur p)
        {
            JoueurContract player = new JoueurContract();
            player.ID = p.ID;
            player.Nom = p.Nom;
            player.Score = p.Score;

            return player;
        }

        public static Joueur JoueurContractToJoueur(JoueurContract p)
        {
            Joueur player = new Joueur();
            player.ID = p.ID;
            player.Nom = p.Nom;
            player.Score = p.Score;

            return player;
        }
    }
}