using System;
using System.IO;
using System.Linq;


namespace Day3;

class D3_2byLINQ
{
    static void Main()
    {
        // Path de notre fichier d'input
        string inputPath = "../../../input.txt";

        int count = 0;

        var splitLines = File.ReadAllText(inputPath)
            .Split("\n")
            .TakeWhile(j => !string.IsNullOrWhiteSpace(j))
            .ToArray();

        List<string[]> split3Lines = new List<string[]>();
        
        while (count < splitLines.Length)
        {
            split3Lines.Add(
                splitLines[count .. (count + 3)]
                );
            count += 3;
        }

        foreach (var split3Line in split3Lines)
        {
            Console.WriteLine($" Lot de 3 : {split3Line[0]} /// {split3Line[1]} /// {split3Line[2]}");
        }


        int sum = 0;

        foreach (var split3Line in split3Lines)
        {
            char found = split3Line[0].Intersect(split3Line[1]).Intersect(split3Line[2]).First();

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




