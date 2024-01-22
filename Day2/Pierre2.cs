using System;
using System.IO;
using System.Collections.Generic;
using System.Runtime.Intrinsics.X86;

public class Pierre2
{
    static void Main()
    {
        
        // récupère le fichier texte
        string inputPath = "../../../input.txt";
        // pas trouvé le moyen de le mettre en relatif
        
        //Je crée un liste vide qui va récupérer chaque ligne du fichier text
        List<string> listInput = new List<string>();
        
        // Vérifie si le fichier existe
        if (File.Exists(inputPath))
        {
            using (StreamReader streamReader = new StreamReader(inputPath))
            {
                // lit chaque ligne du fichier jusqu'à la fin
                while (!streamReader.EndOfStream)
                {

                    // lit une ligne du fichier
                    string lign = streamReader.ReadLine();
                    
                    // Ajout de la ligne dans la liste
                    listInput.Add(lign);
                    // Console.WriteLine(lign);
                }
            }
        }
        else
        {
            Console.WriteLine("Le fichier est introuvable");
        }

        int myScore = 0;

        Dictionary<string, Action> dict = new Dictionary<string, Action>
        {
            {"XA", () => myScore += 3},
            {"XB", () => myScore += 1},
            {"XC", () => myScore += 2},

            {"YA", () => myScore += 4},
            {"YB", () => myScore += 5},
            {"YC", () => myScore += 6},

            {"ZA", () => myScore += 8},
            {"ZB", () => myScore += 9},
            {"ZC", () => myScore += 7},
        };

        foreach (string t in listInput)
        {
            char playElfe = t[0];
            char playMe = t[2];
            
            Console.WriteLine($"Elfe play {playElfe} et Me play {playMe}");

            dict[$"{playMe}{playElfe}"]();

            Console.WriteLine($"Elfe : {playElfe} / Me : {playMe}");
            Console.WriteLine($"Voici mon score : {myScore}");
        }
        
        
        
        
    }
}