using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer;

namespace JediTournamentConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            JediTournamentManager tm=new JediTournamentManager();
            string key;
            do {
                Console.Clear();
                Console.WriteLine("1 - Afficher la liste des stades");
                Console.WriteLine("2 - Afficher la liste des Jedis");
                Console.WriteLine("3 - Afficher la liste des Tournois");
                Console.WriteLine("4 - Afficher la liste des matchs");
                Console.WriteLine("5 - Quitter");
                key = Console.ReadLine();
                Console.Clear();
                switch (key)
                {
                    case "1":
                        foreach (var stade in tm.GetStades())
                        {
                            Console.WriteLine(stade);
                        }
                        Console.ReadKey();
                        break;
                    case "2":
                        foreach (var jedi in tm.GetJedis())
                        {
                            Console.WriteLine(jedi);
                        }
                        Console.ReadKey();
                        break;
                    case "3":
                        foreach (var tournoi in tm.GetTournois())
                        {
                            Console.WriteLine(tournoi);
                        }
                        Console.ReadKey();
                        break;
                    case "4":
                        foreach (var match in tm.GetMatchs())
                        {
                            Console.WriteLine(match);
                        }
                        Console.ReadKey();
                        break;
                }
            }while(key!="5");
        }
    }
}
