using System;
using System.IO;
using System.Linq;


namespace Day3;

class D3_1byLINQ
{
    static void Main2()
    {
        // Path de notre fichier d'input
        string inputPath = "../../../input.txt";

        var splitLines = File.ReadAllLines(inputPath)
            .Select(line =>
            {
                return new string[]
                    { line.Substring(0, line.Length / 2), line.Substring(line.Length / 2, line.Length / 2) };
            })
            .ToArray();

        int sum = 0;
        
        foreach (var splitLine in splitLines)
        {
            char found = splitLine[0].Intersect(splitLine[1]).First();
            
            sum += GetCharIndex(found);
        }

        Console.WriteLine($"Résultat : {sum}");
    }

    private static int GetCharIndex(char c)
    {
        if (c >= 'a' && c <= 'z')
            return (c - 'a' + 1);
        return (c - 'A' + 27);
    }
 
}




