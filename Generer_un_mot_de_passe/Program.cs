

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
