using System.Runtime.InteropServices;

namespace HWPragueParkingV1
{
    internal class StartMenu
    {


        static void Main(string[] args)
        {
            // Här skapar vi en instans av klasserna


            //ManipulateParking ManipulateParking = new ManipulateParking();
            // För att öppna upp array till vår main

            InfoArray.CreateParking();






            bool running = true;

            while (running)
            {
                Console.WriteLine("Welcome to Hello, World parking System");
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
                        Console.WriteLine("Park a vehicle");

                        //Console.WriteLine("MC");
                        //Console.WriteLine("Car");
                        //Console.WriteLine("return");
                        //Console.ReadKey();
                        //ManipulateParking.AddCar();
                        ManipulateParking.AddMC();

                        for (int i = 0; i < InfoArray.ArrayParking.GetLength(0); i++)
                        {
                            Console.Write("|{0} ", InfoArray.ArrayParking[i]);
                        }
                        Console.WriteLine();

                        break;
                    case "2":
                        Console.WriteLine("Move a vehicle");
                        Console.WriteLine("car");
                        ManipulateParking.AddCar();
                        //Console.WriteLine("MC");
                        //Console.WriteLine("Car");
                        //Console.WriteLine("return");
                        //Console.ReadKey();

                        for (int i = 0; i < InfoArray.ArrayParking.GetLength(0); i++)


                        {
                            Console.Write("|{0} ", InfoArray.ArrayParking[i]);
                        }
                        Console.WriteLine();
                        break;
                    case "3":
                        Console.WriteLine("You selected: Remove a vehicle");
                        ManipulateParking.RemoveCar();
                        Console.WriteLine("MC");
                        Console.WriteLine("Car");
                        Console.WriteLine("return");
                        Console.ReadKey();
                        break;

                    case "4":
                        Console.WriteLine("You selected: Search for a vehicle");

                        ManipulateParking.SearchVehicle();
                        break;

                    case "5":
                        Console.WriteLine("You selected: View Parking");
                        Console.Write("Cars will appear in ");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Blue");
                        Console.ResetColor();
                        Console.Write("Motorcykles will appear in ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Red");
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine(@"And empty spaces are shown by ""0""");
                        Console.ResetColor();
                        Console.WriteLine();
                        ManipulateParking.ViewParking();
                        break;

                    case "6":
                        ManipulateParking.ViewParking();

                        break;
                    case "7":
                        Console.WriteLine("Exiting the program...");
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid option, please select between 1 and 5.");
                        break;
                }


                //Check
                //for (int i = 0; i < InfoArray.ArrayParking.GetLength(0); i++)


                //{
                //    Console.Write("|{0} ", InfoArray.ArrayParking[i]);
                //}
                //Console.WriteLine();


                Console.WriteLine();
            }
        }




    }
}
