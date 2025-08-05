using System;

public static class TicketPriceCalculator
{
    public static void Run()
    {
        Console.Clear();
        Console.Write("Enter your age: ");
        if (int.TryParse(Console.ReadLine(), out int age) && age >= 0)
        {
            int price = (age <= 12 || age >= 65) ? 7 : 10;
            Console.WriteLine($"Your ticket price is: GHC{price}");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid age.");
        }

        Pause();
    }

    private static void Pause()
    {
        Console.WriteLine("\nPress Enter to return to the main menu...");
        Console.ReadLine();
    }
}
