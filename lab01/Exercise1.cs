
class Exercise1
{
    public static void Run()
    {
        Random random = new Random();
        int secretNumber = random.Next(1, 11); // losowanie liczby z zakresu 1-10
        int guess;
        int attempts = 0;
        
        do
        {
            Console.Write("Podaj swoją liczbe: ");
            if (!int.TryParse(Console.ReadLine(), out guess))
            {
                Console.WriteLine("Zle podana liczba.");
                continue;
            }
            
            attempts++;
            
            if (guess < secretNumber)
                Console.WriteLine("Za malo");
            else if (guess > secretNumber)
                Console.WriteLine("Za duzo");
            else
                Console.WriteLine($"Brawo! Odgladles liczbe {secretNumber} w {attempts} probach.");
                
        } while (guess != secretNumber);
        
        Console.WriteLine("nacisnij dowolny klawisz, aby zakonczyc...");
        Console.ReadKey();
    }
}