using System;
using System.IO;

public class Elfe
{
    static void Main()
    {
        // récupère le fichier texte
        string inputPath = "/home/baptiste/RiderProjects/AdventofCode/Day1/input.txt";
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

                    listInput.Add(lign);

                    //Console.WriteLine(lign);
                }
            }
        }
        else
        {
            Console.WriteLine("Le fichier est introuvable");
        }
        // Une liste de pas être obtenu en console sans un foreach ?
        //Console.WriteLine(listInput);
        foreach (var input in listInput)
        {
            Console.WriteLine(input);
        }
        Console.WriteLine(listInput.Count);
        
        
        
        
    }
}