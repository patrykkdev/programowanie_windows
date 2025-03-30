

public class Exercise6
{
    public static void Run()
    {
         
        Console.WriteLine("Konwerter temperatur. Wybierz konwersje:");
        Console.WriteLine("1. Celsjusz -> Fahrenheit");
        Console.WriteLine("2. Fahrenheit -> Celsjusz");
        
        int wybor = int.Parse(Console.ReadLine());
        
        if (wybor == 1)
        {
            Console.Write("Podaj temperature w stopniach Celsjusza: ");
            double celsius = double.Parse(Console.ReadLine());
            double fahrenheit = (celsius * 9 / 5) + 32;
            Console.WriteLine($"{celsius}°C = {fahrenheit:F2}°F");
        }
        else if (wybor == 2)
        {
            Console.Write("Podaj temperature w stopniach Fahrenheita: ");
            double fahrenheit = double.Parse(Console.ReadLine());
            double celsius = (fahrenheit - 32) * 5 / 9;
            Console.WriteLine($"{fahrenheit}°F = {celsius:F2}°C");
        }
        else
        {
            Console.WriteLine("zle");
        }
        
        Console.WriteLine("\nNacisnij dowolny klawisz, aby wyjsc");
        Console.ReadKey();
    }
    }
