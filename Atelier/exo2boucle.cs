using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo_2_boucle
{
    class Program
    {
        static void Main(string[] args)
        {
            int grandNbr=0;
            int petitNbr =0;
            int nb=0;

            int[] tabAge=new int[300];
            int choix = 0;
            Random generateurNb = new Random();
          
            for (int i=0; i<tabAge.Length; i++)
            {
                tabAge[i]= (int)generateurNb.Next(1, 10001); 
            }

            Console.WriteLine("Quel operation voulez-vous effectue?");
            Console.WriteLine("1- Trouver le plus grand ");
            Console.WriteLine("2- Trouver le plus petit ");
            Console.WriteLine("3- le nombre saisi est dans le tableau ");
            Console.WriteLine("4- Faire la moyenne  ");
            Console.WriteLine("5- Fermer le  programme ");
            choix = Convert.ToInt32(Console.ReadLine());

            switch( choix )
            {
                case 1: // trouver le plus grand 
                   
                    
                    break;

                case 2: // trouver le plus petit 

                    break;

                case 3: //verifier si le nombre saisi est dans le tableau

                    break;

                case 4: //Faire la moyenne 

                    break;

                case 5: // Fermer le  programme

                    break;

            }
            Console.ReadKey();


        }

    }
}
