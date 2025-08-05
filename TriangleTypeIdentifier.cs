using System;

public static class TriangleTypeIdentifier
{
    public static void Run()
    {
        Console.Clear();
        Console.WriteLine("Enter the three sides of the triangle:");

        if (
            double.TryParse(Console.ReadLine(), out double side1) &&
            double.TryParse(Console.ReadLine(), out double side2) &&
            double.TryParse(Console.ReadLine(), out double side3) &&
            side1 > 0 && side2 > 0 && side3 > 0
        )
        {
            if (side1 == side2 && side2 == side3)
                Console.WriteLine("The triangle is Equilateral.");
            else if (side1 == side2 || side2 == side3 || side1 == side3)
                Console.WriteLine("The triangle is Isosceles.");
            else
                Console.WriteLine("The triangle is Scalene.");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter positive numbers for all sides.");
        }

        Pause();
    }

    private static void Pause()
    {
        Console.WriteLine("\nPress Enter to return to the main menu...");
        Console.ReadLine();
    }
}

