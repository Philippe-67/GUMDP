using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormationCS
{
    public static class Outils
    {
        public static int DemanderNombrePositifNonNul(string question)
        {
            //valide
            return DemanderNombreEntre(question, 1, int.MaxValue);
        }


        public static int DemanderNombreEntre(string question, int min, int max, string messageErreurPersonnalise=null)
        {
            //1 on appelle la f° DemanderNombre(question)
            int nombre = DemanderNombre(question);
            if ((nombre >= min) && (nombre <= max))
            {
                //valide 
                return nombre;
            }

            Console.WriteLine("Erreur le nombre doit etre compris entre " + min + " et " + max + " .");
            //ici plutôt que de faire une boucle while on utilise la recursivité : on rappelle la f° en cours pour recommencer le traitement jusqu'à obtention de la bonne réponse.
            return DemanderNombreEntre(question, min, max);
        }

        public static int DemanderNombre(string question)
        {
            while (true) // on utilise while pour créé une boucle qui tournera tant que la réponse attendue ne sera pas obtenue
            {
                //poser la question
                Console.Write(question);
                string reponse = Console.ReadLine(); //recuperation de l'entrée string du  user
                try // pour vérifier la bonne  réalisation de la conversion
                {
                    int reponseInt = int.Parse(reponse); // transformation du string en int pour disposer d'une variable numérique
                    return reponseInt; // retourne une valeur si on a bien une variable numérique le retur nous fait sortir de la boucle sinon on va vers le catch et on reboucle
                }
                catch
                {
                    Console.WriteLine("Erreur : vous devez enter un nombre");
                    Console.WriteLine();
                }
            }
        }
    }
}
