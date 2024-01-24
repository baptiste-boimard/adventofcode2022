using System;
using System.IO;
using System.Collections.Generic;
using System.Runtime.Intrinsics.X86;
using System.Linq;


namespace Day3;

public class Program
{
    static void Main2()
    {
        
        // récupère le fichier texte
        string inputPath = "../../../input.txt";
        
        
        // Vérifie si le fichier existe
        if (!File.Exists(inputPath))
        {
            Console.WriteLine("Le fichier est introuvable");
            return;
        }

        // Création d'un tableau avec les entrées de chaque ligne du fichier
        string[] listInput = File.ReadAllText(inputPath).Split("\n").ToArray();
        
        // On définit notre variable sum qui récupére la somme de chaque priorité
        int sum = 0;
        
        // foreach pour traiter chaque index un par un
        foreach (var s in listInput)
        {   
            // Coupe la string en 2 morceaux
            // Console.WriteLine(s.Length);
            string split1 = s.Substring(0, s.Length / 2);
            string split2 = s.Substring(s.Length / 2);
            Console.WriteLine($"{split1} /// {split2}");
            
            // Cherche le caractere commmun
            var caractereCommun = split1.Intersect(split2);
            // Console.WriteLine(string.Join("", caractereCommun));
            char[] result = caractereCommun.ToArray();
            
            // Attribution d'une valeur au caracrete
            char[] lettres = new char[26 * 2];
            // Remplir le tabeau avec les caratere de a à Z
            for (int i = 0; i < 26; i++)
            {
                lettres[i] = (char)('a' + i);
            }
            // Remplir avec les caractères de A à Z
            for (int i = 0; i < 26; i++)
            {
                lettres[i + 26] = (char)('A' + i);
            }
            //recherche dans la liste de lettres une correspondance avec le caractére commun
            // on en resort l'index + 1 qui réprésentera la prioriété
            int priorite = Array.IndexOf(lettres, result[0]) + 1;
            sum += priorite;
            // Console.WriteLine($"Priorite : {priorite}");
        }
        
        Console.WriteLine(sum);
        
    }
}