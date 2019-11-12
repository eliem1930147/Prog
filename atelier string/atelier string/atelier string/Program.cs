using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atelier_string
{
    class Program
    {
        static void Main(string[] args)
        {
            string maPhrase = "salut tout le monde";
            int premierE = maPhrase.IndexOf("e");
            string premierMot = maPhrase.Substring(0, premierE);
            int premierEspace = maPhrase.IndexOf(" ");
            string premierPhrase = maPhrase.Substring(0, premierEspace);
            int dernierEspace = maPhrase.LastIndexOf(" ");
            string dernierMot = maPhrase.Substring(dernierEspace + 1);
            string phraseenmajuscule = maPhrase.ToUpper();
            string phraseenminuscule = maPhrase.ToLower();

            if (maPhrase.Contains("octopus")==true)
            {
                Console.WriteLine("Ma phrase contient octopus");
            }
            else
            {
                Console.WriteLine("Ma phrase ne contient pas octopus");
            }
            Console.WriteLine(premierE);
            Console.WriteLine(premierPhrase);
            Console.WriteLine(dernierMot);
            Console.WriteLine(phraseenmajuscule);
            Console.WriteLine(phraseenminuscule);

                

            Console.ReadKey();
                
        }
    }
}
