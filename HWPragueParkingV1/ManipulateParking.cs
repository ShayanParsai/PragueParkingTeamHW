using System;
using System.Collections.Generic;
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
            Console.Write("Enter your registration number: ");
            string Reg = Console.ReadLine().ToUpper();
            while (Reg.Length < 10)
            {
                Console.WriteLine("Reg is too long please retry ");
                Console.Write("Enter your registration number: ");
                Reg = Console.ReadLine().ToUpper();
            }

            int index = Array.IndexOf(InfoArray.ArrayParking, "0");    // searching for first empty spot

            if (index != -1)                                           // save in array if space found
            {
                InfoArray.ArrayParking[index] = Reg;
                Console.WriteLine($"Your car has been parked at spot {index + 1}");
            }
            else
            {
                Console.WriteLine("Theres no available spots");
            }
        }

        ///--------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        public static void AddMC()
        {
            string substring = "*";

            Console.Write("Enter your registration number: ");
            string Reg = Console.ReadLine().ToUpper();
            while (Reg.Length > 10)
            {
                Console.WriteLine("Reg is too long please retry ");
                Console.Write("Enter your registration number: ");
                Reg = Console.ReadLine().ToUpper();
            }

            for (int row = 1; row < 101; row++)
            {
                
                if (InfoArray.ArrayParking[row].Contains(substring))
                {

                    InfoArray.ArrayParking[row] = InfoArray.ArrayParking[row].Replace("#", Reg);               // replace the desierd string in empty 1/2 MC space (2 Mc parked in same space)
                    Console.WriteLine($"Your MC is parked in space {row} with another motorcycle");
                    break;
                }
                else if (InfoArray.ArrayParking[row] == "0")
                {
                    int index = Array.IndexOf(InfoArray.ArrayParking, "0");                                    // searching for first empty spot

                    if (index != -1)                                                                           // save in array if space found
                    {
                        InfoArray.ArrayParking[index] = Reg + ("*#");                                          // adds our search icon to find for later MC parking
                        Console.WriteLine($"Your MC has been parked at spot {index + 1}");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Theres no available spots");
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
        public static void OptimizeParkingMC()
        {
            // string originalText = "Hello World!";
            // string newText = originalText.Replace("World", "C# Developer"); // replace the desierd string
        }
        public static void RemoveCar()
        {
            // Input Reg nummer
            // Remove vehicle from spot X
        }
        public static void RemoveMC()
        {

        }
        public static void SearchVehicle()
        {
            // Input Reg nummer
            // search for spot of vehicle "X"
            // output "Vehicle is at spot "X"
        }


    }

}
