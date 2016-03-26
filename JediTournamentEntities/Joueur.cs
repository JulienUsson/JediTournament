
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JediTournamentEntities
{
    public class Joueur : EntityObject
    {
        public string Nom { get; set; }

        public int Score { get; set; }

        public Joueur() : base(0)
        {
        }

        public Joueur(int id,string nom,int score):base(id)
        {
            Nom = nom;
            Score = score;
        }
    }
}
