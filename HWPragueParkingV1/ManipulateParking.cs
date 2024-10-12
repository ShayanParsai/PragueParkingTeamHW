using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace HWPragueParkingV1
{
    internal class ManipulateParking
    {

        public static void AddCar()
        {
            Console.Clear();
            Console.Write("Enter your registration number: ");
            string Reg = Console.ReadLine().ToUpper();
            while (Reg.Length > 10 || Reg.Length < 4)
            {
                Console.WriteLine("Reg is invalid please retry again");
                Console.Write("Enter your registration number: ");
                Reg = Console.ReadLine().ToUpper();
            }

            int index = Array.IndexOf(InfoArray.ArrayParking, "0");    // searching for first empty spot

            if (index != -1)                                           // save in array if space found
            {
                InfoArray.ArrayParking[index] = Reg;
                Console.WriteLine($"Your car has been parked at spot {index}");
                Console.ReadKey(true);
            }
            else
            {
                Console.WriteLine("Theres no available spots");
                Console.ReadKey(true);  
            }
        }

        ///--------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        public static void AddMC()
        {
            Console.Clear();
            string substring = "#";

            Console.Write("Enter your registration number: ");
            string Reg = Console.ReadLine().ToUpper();
            while (Reg.Length > 10 || Reg.Length < 4)
            {
                Console.WriteLine("Reg is invalid please retry again");
                Console.Write("Enter your registration number: ");
                Reg = Console.ReadLine().ToUpper();
            }

            for (int row = 0; row < 101; row++)
            {
                
                if (InfoArray.ArrayParking[row].Contains(substring))
                {

                    InfoArray.ArrayParking[row] = InfoArray.ArrayParking[row].Replace("#", Reg);               // replace the desierd string in empty 1/2 MC space (2 Mc parked in same space)
                    Console.WriteLine($"Your MC is parked in space {row} with another motorcycle");
                    Console.ReadKey(true);
                    break;
                }
                else if (InfoArray.ArrayParking[row] == "0")
                {
                    int index = Array.IndexOf(InfoArray.ArrayParking, "0");                                    // searching for first empty spot

                    if (index != -1)                                                                           // save in array if space found
                    {
                        InfoArray.ArrayParking[index] = Reg + (" * #");                                          // adds our search icon to find for later MC parking
                        Console.WriteLine($"Your MC has been parked at spot {index}");
                        Console.ReadKey(true);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Theres no available spots");
                        Console.ReadKey(true);
                        break;
                    }
                }

            }

        }

        ///--------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        public static void OptimizeParkingCar()
        {
            // Car or MC
            // input reg nummer
            // string check for closeset avalibe space - "0"
            // Park at "X" Spot
            // Save reg at "X"
            //
        }
        ///--------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        public static void OptimizeParkingMC()
        {
            // string originalText = "Hello World!";
            // string newText = originalText.Replace("World", "C# Developer"); // replace the desierd string
        }
        ///--------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        public static void RemoveCar()
        {
            // Input Reg nummer
            Console.Write("Enter your registration number: ");
            string Reg = Console.ReadLine().ToUpper();
            while (Reg.Length > 10 || Reg.Length < 4)
            {
                Console.WriteLine("Reg is invalid please retry again");
                Console.Write("Enter your registration number: ");
                Reg = Console.ReadLine().ToUpper();
            }
            for (int row = 0; row < 101; row++)
            {
                if (InfoArray.ArrayParking[row].Contains(Reg))
                {
                    int index = Array.IndexOf(InfoArray.ArrayParking, Reg);
                    InfoArray.ArrayParking[row] = InfoArray.ArrayParking[row].Replace(Reg, "0");
                    Console.WriteLine($"Your car was removed from spot {index}");
                }
            }

            // Remove vehicle from spot X
        }
        ///--------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        public static void RemoveMC()
        {

        }
        ///--------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        public static void SearchVehicle()
        {
            // Input Reg nummer
            // search for spot of vehicle "X"
            // output "Vehicle is at spot "X"
        }
        public static void ViewParking()
        {
            string[] unwantedSymbols = { "", "#" };                         // Create and array of the unwanted char but in string format

            for (int i = 1; i < InfoArray.ArrayParking.Length; i++)
            {
                string currentString = InfoArray.ArrayParking[i];

                foreach (string symbol in unwantedSymbols)                            // Removes all symbols from currentstring first i each i 
                {
                    currentString = currentString.Replace(symbol, "").Trim();         // Trim removes all dead space before/after a string
                }

                currentString = currentString.Replace("  ", " & ").Trim();              // Removes dead space between 2 MC (Was ugly without)

                if (InfoArray.ArrayParking[i].Contains(""))                          // If it contained the chosen symbol for mc print red 
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else if (InfoArray.ArrayParking[i] != "0")                            // if its a car show blue
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;                     // empty space = white
                }
                Console.Write($"|{currentString}");                                   // put reset here so i dont have to write everything x2
                Console.ResetColor();
            }
        }

    }

}
