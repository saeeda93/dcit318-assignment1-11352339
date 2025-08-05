using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Select an option:");
            Console.WriteLine("1. Grade Calculator");
            Console.WriteLine("2. Exit");

            Console.Write("\nEnter your choice (1-2): ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    GradeCalculator.Run();
                    break;
                case "2":
                    Console.WriteLine("Exiting program...");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Press Enter to try again.");
                    Console.ReadLine();
                    break;
            }
        }
    }
}
