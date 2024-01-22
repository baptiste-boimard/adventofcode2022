namespace Day1;

public class Program
{
    static void Main()
    {
        
        // récupère le fichier texte
        string inputPath = "../../../input.txt";
        // pas trouvé le moyen de le mettre en relatif
        
        // Vérifie si le fichier existe
        if (!File.Exists(inputPath))
        {
            Console.WriteLine("Le fichier est introuvable");
            return;
        }

        //Je crée un liste vide qui va récupérer chaque ligne du fichier text
        string[] listInput = File.ReadAllText(inputPath).Split("\r\n").ToArray();
        
        // Une liste de pas être obtenu en console sans un foreach ?
        
        //Console.WriteLine(listInput);
        // foreach (var input in listInput)
        // {
        //     Console.WriteLine(input);
        // }
        // Console.WriteLine(listInput.Count);
        
        // Autre manière de le faire
        // listInput.ForEach(i => Console.Write("{0}\t", i));
        
        // Créer une variable qui stocke temporairement le total pour chaque elfe
        int totalElfe = 0;
        
        // Créer une liste qui contient le total pour chaque elfe
        List<int> listTotalElfe = new List<int>();

        foreach (string s in listInput)
        {
            if (string.IsNullOrWhiteSpace(s))
            {
                // Console.WriteLine(listInput[i]);
                listTotalElfe.Add(totalElfe);
                // Console.WriteLine("total section" + totalElfe);
                totalElfe = 0;
            }
            else
            {
                // Console.WriteLine(listInput[i]);
                int listInputIntConvert = int.Parse(s);
                totalElfe += listInputIntConvert;
                // Console.WriteLine("total partiel" + totalElfe);
            }
        }
       
        // Créée variable qui totalise la somme des calories des 3 + gros porteurs
        //int sommeDes3PlusGrosElfe = 0;

        //Itération sur la liste des totaux pour trouver le max
        // on l'ajoute à la somme puis on le delete de la liste
        // on refait l'opération 2 fois pour avoir les 3 1er
        /*for (int j = 0; j < 3; j++)
    {
        int maxValueOfList = listTotalElfe.Max();
        sommeDes3PlusGrosElfe += maxValueOfList;
        listTotalElfe.Remove(maxValueOfList);

        Console.WriteLine($"Elfe N°{j+1} => total = {sommeDes3PlusGrosElfe}");

    }*/

        int[] found = listTotalElfe.OrderByDescending(i => i)
            .Take(3)
            .ToArray();

        Console.WriteLine("Les Calories portées par les 3 + gros sont de : " + found.Sum());

    }
}