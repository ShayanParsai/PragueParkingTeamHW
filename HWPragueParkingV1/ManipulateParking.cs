using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data.SqlTypes;
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
            }
            else
            {
                Console.WriteLine("Theres no available spots");
            }
            Console.WriteLine("Press any key to return to menu:");
            Console.ReadKey(true);
            Console.Clear();
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
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Theres no available spots");
                        break;
                    }
                }
            }
            Console.WriteLine("Press any key to return to the menu:");
            Console.ReadKey(true);
            Console.Clear();
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
        public static void MoveCar()
        {
            string inputCarReg = "";
            bool backToMainMenu = false;

            Console.WriteLine("Please enter the Vehicle registration number");
            inputCarReg = Console.ReadLine().ToUpper();


            while (!backToMainMenu)
            {

                if (inputCarReg == "RETURN")
                {
                    backToMainMenu = true;
                }

                else
                {

                    int index = Array.IndexOf(InfoArray.ArrayParking, inputCarReg);
                    if (index == -1)
                    {
                        Console.Write(@"Reg is invalid please try again, Type ""Return"" if you wish to go to the menu:  ");
                        inputCarReg = Console.ReadLine().ToUpper();
                    }

                    else
                    {
                        Console.WriteLine($"Your vehicle is parked in spot number: {index}");

                        Console.WriteLine("Enter the parking space you would like to move to: ");
                        int newSpace = int.Parse(Console.ReadLine());

                        while (InfoArray.ArrayParking[newSpace] != "0")
                        {
                            Console.WriteLine("This space is already taken, please choose another: ");
                            newSpace = int.Parse(Console.ReadLine());
                            
                        }

                        // Flytta bilen
                        Console.WriteLine($"We have moved your vehicle from {index} to parking spot {newSpace}");
                        InfoArray.ArrayParking[newSpace] = inputCarReg;
                        InfoArray.ArrayParking[index] = "0";  // Sätt gamla platsen som tom
                        Console.ReadKey(true);


                        // Avsluta loopen efter flytt
                        break;
                    }
                }
            }
        }
        ///--------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        public static void MoveMC()
        {
            string inputMCReg = "";
            bool backToMainMenu = false;
            string substring = "*";
            string substring2 = "#";
            string substring3 = "0";

            Console.WriteLine("Please enter the Vehicle registration number");
            inputMCReg = Console.ReadLine().ToUpper();

            while (!backToMainMenu)
            {

                if (inputMCReg == "RETURN")
                {
                    backToMainMenu = true;
                    break;
                }

                else
                {

                    bool MCFound = false;
                    int row = 1;

                    for (row = 1; row < InfoArray.ArrayParking.Length; row++)
                    {
                        string ArrayParkingPlace = InfoArray.ArrayParking[row];

                        if (ArrayParkingPlace.Contains(inputMCReg) && ArrayParkingPlace.Contains(substring))
                        {
                            MCFound = true;

                            if (ArrayParkingPlace.Contains(substring2))
                            {
                                Console.WriteLine($"Your vehicle is parked in spot number: {row}");
                                InfoArray.ArrayParking[row] = "0";
                            }

                            else
                            {
                                Console.WriteLine($"Your vehicle is parked in spot number: {row}");
                                string currentParkedMC = InfoArray.ArrayParking[row];
                                InfoArray.ArrayParking[row] = currentParkedMC.Replace(inputMCReg, "#");
                            }
                            break;
                        }
                    }

                    if (!MCFound)
                    {
                        Console.WriteLine(@"Your registration is INVALID, Try again. Type ""Return"" to go back to main menu");
                        inputMCReg = Console.ReadLine().ToUpper();
                        if (inputMCReg == "RETURN")
                        {
                            backToMainMenu = true;
                            break;
                        }
                        else
                        {
                            continue;
                        }

                    }

                    Console.WriteLine(@"Enter the parking space you would like to move to or type ""0"" to return to main menu: ");
                    int newSpace = int.Parse(Console.ReadLine());
                    if (newSpace == 0)
                    {
                        backToMainMenu = true;
                        break;
                    }

                    while (!backToMainMenu)
                    {

                        string ArrayParkingNewSpace = InfoArray.ArrayParking[newSpace];

                        if (ArrayParkingNewSpace.Contains(substring2))
                        {
                            string newParkingSpace = InfoArray.ArrayParking[newSpace];
                            InfoArray.ArrayParking[newSpace] = newParkingSpace.Replace(substring2, inputMCReg);
                            Console.WriteLine($"We have moved your vehicle from {row} to parking spot {newSpace} and its parked with another MC");
                            Console.ReadKey(true);
                            backToMainMenu = true;
                            break;
                        }

                        else if (InfoArray.ArrayParking[newSpace].Contains("0"))
                        {
                            string newParkingSpace = InfoArray.ArrayParking[newSpace];
                            InfoArray.ArrayParking[newSpace] = newParkingSpace.Replace(substring3, inputMCReg);
                            InfoArray.ArrayParking[newSpace] = inputMCReg + " * #";
                            Console.WriteLine($"We have moved your vehicle from {row} to parking spot {newSpace}");
                            Console.ReadKey(true);
                            backToMainMenu = true;
                            break;
                        }

                        else if (!InfoArray.ArrayParking[newSpace].Contains("#") && !InfoArray.ArrayParking[newSpace].Contains("0"))
                        {
                            Console.WriteLine(@"This space is already occupied, please choose another space. Type ""0"" to go back to main menu");
                            newSpace = int.Parse(Console.ReadLine());
                            if (newSpace == 0)
                            {
                                backToMainMenu = true;
                                break;
                            }
                        }
                    }

                }
            }
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
        public static void CarSearch()
        {
            bool isFound = false;

            while (!isFound)
            {

                Console.Write("Enter in the Car Registration: ");
                string inputCarReg = Console.ReadLine().ToUpper();

                for (int i = 1; i < InfoArray.ArrayParking.Length; i++)
                {
                    if (inputCarReg == "RETURN")
                    {
                        isFound = true;                                                               // Set flag to true when registration number is found
                    }
                    else if (inputCarReg == InfoArray.ArrayParking[i])
                    {
                        isFound = true;
                        Console.WriteLine($"Your vehicle is parked in spot number: {i}");
                        Console.WriteLine();
                        Console.ReadKey(true);
                    }
                }

                if (!isFound)
                {
                    Console.WriteLine("Registration number not found. Please try again.");
                    Console.WriteLine(@"Type ""Return"" to go back to menu");
                }
            }
        }
        ///--------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        public static void McSearch()
        {
            bool isFound = false;

            while (!isFound)
            {

                Console.Write("Enter in the motorcycle Registration: ");
                string inputMcReg = Console.ReadLine().ToUpper();

                for (int i = 1; i < InfoArray.ArrayParking.Length; i++)
                {
                    if (inputMcReg == "RETURN")
                    {
                        isFound = true;                                                               // Set flag to true when registration number is found
                    }
                    else if (InfoArray.ArrayParking[i].Contains(inputMcReg))
                    {
                        Console.WriteLine($"Your motorcycle is parked in space number {i}");
                        isFound = true;                                                              // Set flag to true when registration number is found
                        Console.ReadKey(true);                                                     
                    }
                }

                if (!isFound)
                {
                    Console.WriteLine("Registration number not found. Please try again.");
                    Console.WriteLine(@"Type ""Return"" to go back to menu");
                }
            }
        }
        
        ///--------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        public static void ViewParking()
        {
            Console.Write("Cars will appear in: ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Blue");
            Console.ResetColor();
            Console.Write("Motorcykles will apear in: ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Red");
            Console.ResetColor();
            Console.Write("Empty spaces will appear as: ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(@"""0""");
            Console.WriteLine();


            string[] unwantedSymbols = { "*", "#" };                         // Create and array of the unwanted char but in string format

            for (int i = 1; i < InfoArray.ArrayParking.Length; i++)
            {
                string currentString = InfoArray.ArrayParking[i];

                foreach (string symbol in unwantedSymbols)                            // Removes all symbols from currentstring first i each i 
                {
                    currentString = currentString.Replace(symbol, "").Trim();         // Trim removes all dead space before/after a string
                }

                currentString = currentString.Replace("  ", " & ").Trim();              // Removes dead space between 2 MC (Was ugly without)

                if (InfoArray.ArrayParking[i].Contains("*"))                          // If it contained the chosen symbol for mc print red 
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
            Console.WriteLine();
            Console.WriteLine("Press any key to return to menu:");
            Console.ReadKey(true);
        }
        

        
    }
}
