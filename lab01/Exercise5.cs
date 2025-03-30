

public class Exercise5
{
    public static void Run()
    {
        Console.Write("Podaj liczbe calkowita: ");
        
        if (!int.TryParse(Console.ReadLine(), out int number))
        {
            Console.WriteLine("Podaj prawidlowa liczbe");
            Console.ReadKey();
            return;
        }
        
        if (IsPrime(number))
            Console.WriteLine($"{number} jest liczba pierwsza.");
        else
            Console.WriteLine($"{number} nie jest liczba pierwsza.");
        
        Console.ReadKey();
    }
    
    static bool IsPrime(int number)
    {
        // obsluga przypadkow specjalnych
        if (number <= 1)
            return false;
        if (number <= 3)
            return true;
        if (number % 2 == 0 || number % 3 == 0)
            return false;
        
      
        int i = 5;
        while (i * i <= number)
        {
            if (number % i == 0 || number % (i + 2) == 0)
                return false;
            i += 6;
        }
        
        return true;
    }
}