using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratoire_2
{
    class Program
    {
        public enum Sorte { Coeur = 1, Pique =2, Carreau = 3, Trefle = 4 };

        static Random generateurNb = new Random();
        public struct Carte
        {
            public int valeur;
            public Sorte sorte;
            public Carte( int _valeur, Sorte _sorte ) : this()
            {
                valeur = _valeur;
                sorte = _sorte;
            }

        }
        public struct Joueur
        { 
            public string nom;
            public int vie;
            public Carte[] tabCarte;
            public Joueur(string _nom, int _vie) : this()
            {
                tabCarte = new Carte[3];
                for (int i = 0; i < tabCarte.Length; i++)
                {
                    tabCarte[i] = new Carte( generateurNb.Next(1,14),(Sorte)generateurNb.Next(1, 5) ) ;
                }
                nom = _nom;
                vie = _vie;
            }
        }

        static void Main(string[] args)
        {


           Joueur joueur1 = new Joueur("joueur1", 3);
            Joueur ordi = new Joueur("Ordi", 3);
            Carte carte1 = new Carte(generateurNb.Next(1, 14), (Sorte)generateurNb.Next(1, 5));
            Carte carte2 = new Carte(generateurNb.Next(1, 14), (Sorte)generateurNb.Next(1, 5));
            Carte carte3 = new Carte(generateurNb.Next(1, 14), (Sorte)generateurNb.Next(1, 5));
            Carte carteCentre = new Carte(generateurNb.Next(1, 14), (Sorte)generateurNb.Next(1, 5));
            int choix = 0;
            int total = 0;
            

            Console.WriteLine(joueur1);
            Console.WriteLine(carte1);
            Console.WriteLine(carte2);
            Console.WriteLine(carte3);
            Console.WriteLine(carteCentre);

            Console.WriteLine("Tour du Joueur 1");
            Console.WriteLine("Quel option voulez - vous effectue ? ");
            Console.WriteLine("1- Prendre une nouvelle carte et se débarrasser d’une de ses 3 cartes ");
            Console.WriteLine("2- Prendre la carte retournée et se débarrasser d’une de ses 3 cartes ");
            Console.WriteLine("3- Aviser les joueurs que c’est le dernier tour. ( il faut avoir plus de 21  pour  réaliser  cette  étape  ). ");
            choix = Convert.ToInt32(Console.ReadLine());
            if(choix==1)
            {
                
            }
            else if (choix==2)
            {

            }
            else if (choix==3)
            {
                Console.WriteLine("dernier tour");
            }
            Console.WriteLine("Tour de l'ordi");
            if(total<21)
            {
                
            }

            Console.ReadKey();
        }
    }
}
