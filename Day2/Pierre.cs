using System;
using System.IO;
using System.Collections.Generic;
using System.Runtime.Intrinsics.X86;

public class Pierre
{
    static void Main2()
    {
        
        // récupère le fichier texte
        string inputPath = "/home/punky/Code/Projets/adventofcode2022/Day2/input.txt";
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
        
        for (int i = 0; i < listInput.Count; i++)
        {
            char playElfe = listInput[i][0];
            char playMe = listInput[i][2];
            
            Console.WriteLine($"Elfe play {playElfe} et Me play {playMe}");

            switch (playMe)
            {
                case 'X':
                    myScore += 1;
                    switch (playElfe)
                    {
                        case 'A':
                            myScore += 3;
                            break;
                        case 'C':
                            myScore += 6;
                            break;
                    }
                    break;
                case 'Y':
                    myScore += 2;
                    switch (playElfe)
                    {
                        case 'B':
                            myScore += 3;
                            break;
                        case 'A':
                            myScore += 6;
                            break;
                    }
                    break;
                case 'Z':
                    myScore += 3;
                    switch (playElfe)
                    {
                        case 'C':
                            myScore += 3;
                            break;
                        case 'B':
                            myScore += 6;
                            break;
                    }
                    break;
            }

            Console.WriteLine($"Elfe : {playElfe} / Me : {playMe}");
            Console.WriteLine($"Voici mon score : {myScore}");
        }
        
        
        
        
    }
}