using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo1_boucle_tableau
{
    class Program
    {
        static void Main(string[] args)
        {
          int chiffre1 = 0;
            int total=0;

            Console.WriteLine("Saisir nombre entier");

            chiffre1 = Convert.ToInt32(Console.ReadLine());


            for (int i = 0; i < chiffre1; ++i)
            {

                if (total < chiffre1)
                {
                    total = total * i;


                }
                else if (total >= chiffre1)
                {
                    Console.WriteLine(total);
                }
                Console.ReadKey();

            }
            
        }

    }
}
