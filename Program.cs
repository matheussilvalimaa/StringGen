using System;
using StringGen.Application;

class Program
{
    public static void Main()
    {
        var stringGen = new StringGenerationService();
        bool end = true;

        Console.WriteLine("=== StringGen - Your favorite string generator! ===");

        while (end)
        {
            Console.WriteLine($@"Choose the type of character:
            (1) Uppercase
            (2) Lowercase
            (3) Digits
            (4) Upper + Lower + Digits
            (5) Upper + Lower + Digits + Simbols");
            if (!int.TryParse(Console.ReadLine(), out int option))
            {
                Console.WriteLine("Invalid option!");
                continue;
            }

            Console.WriteLine("Type the size of the string:");
            int length = int.Parse(Console.ReadLine());
            try
            {
                var result = stringGen.GenerateAndSaveString(option, length);
                Console.WriteLine($"String generated with success: {result}");
                Console.WriteLine("Want to generate more? (y/n)");
                string answer = Console.ReadLine()!;
                if (answer == "y")
                {
                    continue;
                }
                break;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
