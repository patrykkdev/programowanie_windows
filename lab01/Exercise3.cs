

public class Exercise3
{
    public static void Run()
    {
        
        Console.Write("Podaj ciag binarny: ");
        string binaryString = Console.ReadLine();
        
        // sprawdzenie czy ciag jest binarny
        foreach (char c in binaryString)
        {
            if (c != '0' && c != '1')
            {
                Console.WriteLine("wprowadzony ciag nie jest binarny");
                Console.ReadKey();
                return;
            }
        }
        
        int holeCount = CountBinaryHoles(binaryString);
        Console.WriteLine($"Liczba dziur binarnych: {holeCount}");
        Console.ReadKey();
    }
    
    static int CountBinaryHoles(string binaryString)
    {
        int holes = 0;
        bool isHoleStarted = false;
        
        for (int i = 0; i < binaryString.Length; i++)
        {
            if (binaryString[i] == '1')
            {
                if (isHoleStarted)
                {
                    // koniec dziury
                    holes++;
                    isHoleStarted = false;
                }
                
                // zzekamy na sekwencje 0 po 1
                while (i < binaryString.Length - 1 && binaryString[i + 1] == '1')
                    i++;
                
                if (i < binaryString.Length - 1 && binaryString[i + 1] == '0')
                    isHoleStarted = true;
            }
        }
        
        return holes;
    }
}