using System;

class Program
{
    static void Main()
    {
        bool exit = false;
        
        while (!exit)
        {
            Console.Clear();
            Console.WriteLine("LABORATORIUM - PROGRAMOWANIE W ŚRODOWISKU WINDOWS");
            Console.WriteLine("1. Zgadywanie liczby");
            Console.WriteLine("2. Zliczanie unikatowych wartości");
            Console.WriteLine("3. Liczenie dziur binarnych");
            Console.WriteLine("4. Operacje na zbiorach");
            Console.WriteLine("5. Sprawdzanie liczb pierwszych");
            Console.WriteLine("6. Dodatkowe ćwiczenie");
            Console.WriteLine("0. Wyjście");
            
            Console.Write("\nWybierz ćwiczenie: ");
            string choice = Console.ReadLine();
            
            switch (choice)
            {
                case "1":
                    Exercise1.Run();
                    break;
                case "2":
                    Exercise2.Run();
                    break;
                case "3":
                    Exercise3.Run();
                    break;
                case "4":
                    Exercise4.Run();
                    break;
                case "5":
                    Exercise5.Run();
                    break;
                case "6":
                    Exercise6.Run();
                    break;
                case "0":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Nieprawidłowy wybór. Naciśnij dowolny klawisz, aby kontynuować...");
                    Console.ReadKey();
                    break;
            }
        }
    }
}