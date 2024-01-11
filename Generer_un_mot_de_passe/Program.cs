

//internal class Program
//{

//        public static int DemanderNombrePositifNonNul(string question)
//    {
//        //valide
//        return DemanderNombreEntre(question, 1, int.MaxValue);
//    }


//    public static int DemanderNombreEntre(string question, int min, int max)
//    {


//        //1 on appelle la f° DemanderNombre(question)
//        int nombre = DemanderNombre(question);
//        if ((nombre >= min) && (nombre <= max))
//        {
//            //valide 
//            return nombre;
//        }
//        Console.WriteLine("Erreur le nombre doit etre compris entre " + min + " et " + max + " .");
//        //ici plutôt que de faire une boucle while on utilise la recursivité : on rappelle la f° en cours pour recommencer le traitement jusqu'à obtention de la bonne réponse.
//        return DemanderNombreEntre(question, min, max);
//    }

//    public static int DemanderNombre(string question)
//    {
//        while (true) // on utilise while pour créé une boucle qui tournera tant que la réponse attendue ne sera pas obtenue
//        {
//            //poser la question
//            Console.Write(question);
//            string reponse = Console.ReadLine(); //recuperation de l'entrée string du  user
//            try // pour vérifier la bonne  réalisation de la conversion
//            {
//                int reponseInt = int.Parse(reponse); // transformation du string en int pour disposer d'une variable numérique
//                return reponseInt; // retourne une valeur si on a bien une variable numérique le retur nous fait sortir de la boucle sinon on va vers le catch et on reboucle
//            }
//            catch
//            {
//                Console.WriteLine("Erreur : vous devez enter un nombre");
//            }
//        }
//    }

using FormationCS;
class Program
{
    static void Main(string[] args)
    {
        const int NB_DE_MOTS_DE_PASSE = 10;

        // 1  - demander la longueur du mot de passe en utilisant la fonction DemanderNombre et en assignant le retour dans une variable
        int longueurMotDePasse = Outils.DemanderNombrePositifNonNul("Longueur du mot de passe :");
        Console.WriteLine();
        int choixAlphabet=Outils.DemanderNombreEntre("Vous voulez un mot de passe avec : \n" +
            "1 - uniquement des caractères en minuscule\n" +
            "2 - des caractères majuscules et minuscules\n" +
            "3 - des caractères et des chiffres\n" +
            "4 - caractères, chiffres et caractères spéciaux\n" +
            "votre choix : ", 1, 4);
        
        // 2 - alphabet "abcd1234"
        // 3 - comment choisir un caractère aléatoire
        string minuscules = ("abcdefghijklmnopqrstuvwxyz");
        string majuscules = minuscules.ToUpper();
        string chiffres = "0123456789";
        string caracteresSpeciaux = "#!ù*$";
        string motDePasse = "";
        string alphabet;
     //   int longueurAlphabet = alphabet.Length;
        Random rand = new Random();
        if (choixAlphabet == 1)
            alphabet = minuscules;
        else if (choixAlphabet == 2)
            alphabet = minuscules + majuscules;
        else if (choixAlphabet == 3)
            alphabet = majuscules + chiffres + minuscules;
        else
        {
            alphabet = majuscules + chiffres + minuscules + caracteresSpeciaux;
        }
            int longueurAlphabet = alphabet.Length;

        for (int j = 0; j < NB_DE_MOTS_DE_PASSE; j++)
        {
            motDePasse = "";
            for (int i = 0; i < longueurMotDePasse; i++)
            {
                int index = rand.Next(0, longueurAlphabet - 1);
                motDePasse += alphabet[index];
            }

            Console.WriteLine("mot de passe: " + motDePasse);
        }
         

        //   Console.WriteLine(majuscules);
        // Console.ReadKey();
    }

}
