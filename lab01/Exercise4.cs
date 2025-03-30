
public class Exercise4
{
    public static void Run()
    {
          Console.WriteLine("Program wykonujacy operacje na zbiorach");
        
        // wprowadzanie elementow zbioru A
        HashSet<int> setA = GetSetFromUser("A");
        
        // wprowadzanie elemtow zbioru B
        HashSet<int> setB = GetSetFromUser("B");
        
        // wyswietlanie zbiorow
        Console.WriteLine("\nZbiór A: " + string.Join(", ", setA));
        Console.WriteLine("Zbiór B: " + string.Join(", ", setB));
        
        // suma zbiorow
        HashSet<int> union = new HashSet<int>(setA);
        union.UnionWith(setB);
        Console.WriteLine("\nSuma zbiorow (A ∪ B): " + string.Join(", ", union));
        
        // roznica zbiorow A-B
        HashSet<int> difference = new HashSet<int>(setA);
        difference.ExceptWith(setB);
        Console.WriteLine("Roznica zbiorow (A - B): " + string.Join(", ", difference));
        
        // czesc wspolna zbiorow
        HashSet<int> intersection = new HashSet<int>(setA);
        intersection.IntersectWith(setB);
        Console.WriteLine("Czesc wspolna zbiorow : " + string.Join(", ", intersection));
        
        // roznica symetryczna zbiorow
        HashSet<int> symmetricDifference = new HashSet<int>(setA);
        symmetricDifference.SymmetricExceptWith(setB);
        Console.WriteLine("Roznica symetryczna zbiorow: " + string.Join(", ", symmetricDifference));
        
        Console.ReadKey();
    }
    
    static HashSet<int> GetSetFromUser(string setName)
    {
        HashSet<int> set = new HashSet<int>();
        
        Console.WriteLine($"\nWprowadzanie elementow zbioru {setName}");
        Console.WriteLine("Wprowadzaj liczby calkowite (wpisz 'koniec', aby zakończyć):");
        
        while (true)
        {
            string input = Console.ReadLine();
            
            if (input.ToLower() == "koniec")
                break;
                
            if (int.TryParse(input, out int number))
            {
                set.Add(number);
            }
            else
            {
                Console.WriteLine("zla liczba");
            }
        }
        
        return set;
    }
}