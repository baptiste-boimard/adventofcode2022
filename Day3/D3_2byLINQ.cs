using System;
using System.IO;
using System.Linq;


namespace Day3;

class D3_2byLINQ
{
    static void Main2()
    {
        // Path de notre fichier d'input
        string inputPath = "../../../input.txt";

        var split3Lines = File.ReadAllText(inputPath)
            .Split("\n")
            .TakeWhile(j => !string.IsNullOrWhiteSpace(j))
            .Select(line =>
            {
                for (int i = 0; i < 3; i++)
                {
                    
                }
                // return new string[] { };
            })
            .ToArray();


        // int sum = 0;
        //
        // foreach (var splitLine in splitLines)
        // {
        //     char found = splitLine[0].Intersect(splitLine[1]).First();
        //     
        //     sum += GetCharIndex(found);
        // }
        //
        // Console.WriteLine($"Résultat : {sum}");
    }

    private static int GetCharIndex(char c)
    {
        if (c >= 'a' && c <= 'z')
            return (c - 'a' + 1);
        return (c - 'A' + 27);
    }
 
}




