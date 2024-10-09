﻿namespace HWPragueParkingV1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool running = true;

            while (running)
            {
                Console.WriteLine("Welcome to Prague Parking System");
                Console.WriteLine("1. Park a vehicle");
                Console.WriteLine("2. Move a vehicle");
                Console.WriteLine("3. Remove a vehicle");
                Console.WriteLine("4. Search for a vehicle");
                Console.WriteLine("5. Exit");

                Console.Write("Please select an option (1-5): ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("You selected: Park a vehicle");
                        // Koden här
                        break;
                    case "2":
                        Console.WriteLine("You selected: Move a vehicle");
                        // Koden här
                        break;
                    case "3":
                        Console.WriteLine("You selected: Remove a vehicle");
                        // Koden här
                        break;
                    case "4":
                        Console.WriteLine("You selected: Search for a vehicle");
                        // Koden här
                        break;
                    case "5":
                        Console.WriteLine("Exiting the program...");
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid option, please select between 1 and 5.");
                        break;
                }

                Console.WriteLine();
            }
        }
    }
}
