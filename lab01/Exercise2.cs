class Exercise2
{
    public static void Run()
    {
        Console.WriteLine("Program zliczający unikatowe wartości");
        Console.WriteLine("Wprowadzaj liczby całkowite (wpisz 'koniec' aby zakończyć):");
        
        HashSet<int> uniqueNumbers = new HashSet<int>();
        string input;
        
        while (true)
        {
            input = Console.ReadLine();
            
            if (input.ToLower() == "koniec")
                break;
                
            if (int.TryParse(input, out int number))
            {
                uniqueNumbers.Add(number); // HashSet automatycznie ignoruje duplikaty
            }
            else
            {
                Console.WriteLine("To nie jest prawidłowa liczba, sprobuj ponownie.");
            }
        }
        
        Console.WriteLine($"Liczba unikatowych wartości: {uniqueNumbers.Count}");
        Console.Write("Unikatowe wartości: ");
        foreach (int number in uniqueNumbers)
        {
            Console.Write($"{number} ");
        }
        
        Console.WriteLine("\nNacisnij dowolny klawisz, aby zakonczyc");
        Console.ReadKey();
    }
}