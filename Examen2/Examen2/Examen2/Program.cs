using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2
{
    class Program
    {
        public enum Rareté { commun = 1, rare = 2, épique = 3, légendaire = 4 };
        
        static Random generateurNb = new Random();

        public struct Vaisseau
        {
            public string nom;
            public Rareté rareté;
            public int attaque;
            public int vie;
            public int prix;

            public Vaisseau(string _nom, Rareté _rareté, int _attaque, int _vie, int _prix) : this()
            {
                nom = _nom;
                rareté = _rareté;
                attaque = _attaque;
                vie = _vie;
                prix = _prix;
            }





        }

        static void Main(string[] args)
        {
            int choix = 0;
            int attaque = 0;
            int moy = 0;
            


            int[] tabVaisseau = new int[20];



            for (int i = 0; i < tabVaisseau.Length; i++)
            {
                tabVaisseau[i] = new Vaisseau(generateurNb.Next(1, 21), (Rareté)generateurNb.Next(1, 5));
            }







            Vaisseau Vaisseau = new Vaisseau(generateurNb.Next(1, 21), (Rareté)generateurNb.Next(1, 5));
            Console.WriteLine(Vaisseau);



            Console.WriteLine("Quel option voulez - vous effectue ? ");
            Console.WriteLine("1-Afficher les vaisseaux avec toutes les caractéristiques");
            Console.WriteLine("2-Vérifier si un vaisseau légendaire existe");
            Console.WriteLine("3-Trouver le vaisseau avec le plus d'attaque");
            Console.WriteLine("4-Afficher la moyenne des prix des vaisseaux");
            Console.WriteLine("5-Quitter le programme");
            choix = Convert.ToInt32(Console.ReadLine());
            if (choix == 1)
            {
                Console.WriteLine("Commun: attaque: 10 a 25 vie: 100 a 150 prix: 2000");
                Console.WriteLine("Rare: attaque: 23 a 50 vie: 140 a 250 prix: 4500");
                Console.WriteLine("Épique: attaque: 65 a 75 vie:200 a 600 prix: 8000");
                Console.WriteLine("Légendaire: attaque: 90 a 110 vie: 550 a 2000 prix: 20000");
            }
            else if (choix == 2)
            {

            }
            else if (choix == 3)
            {
                if (attaque>550)
                {
                    Console.WriteLine("Le Vaisseau légendaire possede le plus d'attaque ");
                }
            }
            else if (choix == 4)
            {
                moy = 2000 + 4500 + 8000 + 20000 / 4;
                Console.WriteLine(moy);
            }
            else if (choix == 5)
            {
                break;
            }
            Console.ReadKey();
        }

    }
}


