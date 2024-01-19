using System;
using System.IO;
using System.Collections.Generic;
public class Elfe
{
    static void Main()
    {
        
        // récupère le fichier texte
        string inputPath = "/home/punky/Code/Projets/adventofcode2022/Day1/input.txt";
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
                }
            }
        }
        else
        {
            Console.WriteLine("Le fichier est introuvable");
        }
        
        // Une liste de pas être obtenu en console sans un foreach ?
        
        //Console.WriteLine(listInput);
        // foreach (var input in listInput)
        // {
        //     Console.WriteLine(input);
        // }
        // Console.WriteLine(listInput.Count);
        
        // Autre manière de le faire
        listInput.ForEach(i => Console.Write("{0}\t", i));
        
        // Créer une variable qui stocke temporairement le total pour chaque elfe
        int totalElfe = 0;
        
        // Créer une liste qui contient le total pour chaque elfe
        List<int> listTotalElfe = new List<int>();

        for (int i = 0; i < listInput.Count; i++)
        {
            
            if (string.IsNullOrWhiteSpace(listInput[i]))
            {
                Console.WriteLine(listInput[i]);
                listTotalElfe.Add(totalElfe);
                Console.WriteLine("total section" + totalElfe);
                totalElfe = 0;
            }
            else
            {
                Console.WriteLine(listInput[i]);
                int listInputIntConvert = int.Parse(listInput[i]);
                totalElfe += listInputIntConvert;
                // Console.WriteLine("total partiel" + totalElfe);
            }
        }
        // On recherche la valeur max de la liste des total pour chaque elfe
        int maxValueForOneElfe = listTotalElfe.Max();
        
        Console.WriteLine("Le max est " + maxValueForOneElfe);



    }
}