using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWPragueParkingV1
{
    internal class VisualMenu
    {
        public static void HelloWorld()
        {
            CenterTextLine("Welcome to Hello, World Prague Parking");
            CenterTextLine("Choose what you would like to do");
            Console.WriteLine();
            Console.WriteLine();
        }
        public static void CenterTextLine(string text)                 //detta är vår centrerade text med writeline
        {
            string centerText = GetCenterText(text);
            Console.WriteLine(centerText);
        }
        public static string GetCenterText(string text)                // checkar vart mitten av consolappen är
        {
            int consolWidth = Console.WindowWidth;
            int leftPadding = (consolWidth - text.Length) / 2;
            return new string(' ', leftPadding) + text;                // skriver ut mellanslag innan texten
        }
        public static void CenterText(string text)                     //detta är vår centrerade text med write
        {
            string centerText = GetCenterText(text);
            Console.Write(centerText);
        }
        public static void StartingSystem()                            // Gör en cool effect för starting system
        {
            string message = "Starting System";
            CenterText(message);

            for (int i = 0; i < 3; i++)
            {
                Thread.Sleep(500);
                Console.Write(".");
            }
            Thread.Sleep(1000);
        }
        public static void ShuttingDown()            // Gör en cool effect för shutdown system
        {
            string message = "Shutting down System";
            CenterText(message);

            for (int i = 0; i < 6; i++)
            {
                Thread.Sleep(500);
                Console.Write(".");
            }
            Thread.Sleep(1000);
        }
        public static void EndCretids()
        {
            string[] endCredtis = new string[]
            {
                "----------------------------",
                "        CREDIT ROLL         ",
                "----------------------------",
                "",
                "Director: Cleas Engelin",
                "Producer: Cleas Engelin",
                "Lead Developer: Cleas Engelin",
                "Graphic Designer: Cleas Engelin",
                "Sound Engineer: Cleas Engelin",
                "Special Thanks To: Cleas Engelin",
                "",
                "----------------------------",
                "        THE END.            ",
                "       Cleas Engelin        ",
                "----------------------------"
             };
            Console.CursorVisible = false;

            int windowHeight = Console.WindowHeight;

            for (int i = 0; i < windowHeight; i++)
            {
                Console.WriteLine();
            }

            foreach (string line in endCredtis)
            {
                Console.SetCursorPosition(0, 0);
                CenterTextLine(line);

                Thread.Sleep(500);

                for (int i = 0; i < windowHeight - 1; i++)
                {
                    Console.WriteLine();
                }
            }
            Console.SetCursorPosition(0, windowHeight - 1);
            CenterTextLine("Press any key to return to main menu");
            Console.ReadKey(true);
        }
        public static void CarorMCPark()
        {
            Console.Clear();
            CenterTextLine("Hello, World Prague Parking");
            CenterText("Park a Vehicle");
            ConsoleKeyInfo keyInfo;
            int choice = 0;
            string[] carorMC = { "Car", "MC", "Return" };
            int maxLength = carorMC.Max(item => item.Length) + 4;

            while (true)
            {
                Console.SetCursorPosition(0, 4);            // Här börjar positionen av vår Cursor på rad 2 för att 0 - 1 är reserverad för vår rubrik

                for (int i = 0; i < carorMC.Length; i++)
                {
                    string menuItem = $"{i + 1}. {carorMC[i]}";
                    string alignedText = menuItem.PadRight(maxLength);

                    string centeredText =   GetCenterText(alignedText);

                    if (i == choice)
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine(centeredText);
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.WriteLine(centeredText);
                    }
                }

                keyInfo = Console.ReadKey(true);

                if (keyInfo.Key == ConsoleKey.UpArrow)          // Läser in våra keys så att vi kan röra oss upp ner och enter för att gå in
                {
                    if (choice > 0)
                        choice--;
                }
                else if (keyInfo.Key == ConsoleKey.DownArrow)
                {
                    if (choice < carorMC.Length - 1)
                        choice++;
                }
                else if (keyInfo.Key == ConsoleKey.Enter)
                {
                    switch (choice)
                    {
                        case 0:

                            CenterText("Car");
                            ManipulateParking.AddCar();
                            return;
                        case 1:
                                CenterText("MC");
                            ManipulateParking.AddMC();
                            return;
                        case 2:
                                CenterText("Retrun");
                            return;
                    }
                }
            }
        }
        public static void CarorMCRemove()
        {
            Console.Clear();
            CenterTextLine("Hello, World Prague Parking");
            CenterText("Remove a Vehicle");
            ConsoleKeyInfo keyInfo;
            int choice = 0;
            string[] carorMC = { "Car", "MC", "Return" };
            int maxLength = carorMC.Max(item => item.Length) + 4;

            while (true)
            {
                Console.SetCursorPosition(0, 4);            // Här börjar positionen av vår Cursor på rad 2 för att 0 - 1 är reserverad för vår rubrik

                for (int i = 0; i < carorMC.Length; i++)
                {
                    string menuItem = $"{i + 1}. {carorMC[i]}";
                    string alignedText = menuItem.PadRight(maxLength);

                    string centeredText = GetCenterText(alignedText);

                    if (i == choice)
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine(centeredText);
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.WriteLine(centeredText);
                    }
                }

                keyInfo = Console.ReadKey(true);

                if (keyInfo.Key == ConsoleKey.UpArrow)          // Läser in våra keys så att vi kan röra oss upp ner och enter för att gå in
                {
                    if (choice > 0)
                        choice--;
                }
                else if (keyInfo.Key == ConsoleKey.DownArrow)
                {
                    if (choice < carorMC.Length - 1)
                        choice++;
                }
                else if (keyInfo.Key == ConsoleKey.Enter)
                {
                    switch (choice)
                    {
                        case 0:

                            CenterText("Car");
                            ManipulateParking.RemoveCar();
                            return;
                        case 1:
                            CenterText("MC");
                            ManipulateParking.RemoveMC();
                            return;
                        case 2:
                            CenterText("Retrun");
                            return;
                    }
                }
            }
        }
        public static void CarorMCSearch()
        {
            Console.Clear();
            CenterTextLine("Hello, World Prague Parking");
            CenterText("Search for a vehicle");
            ConsoleKeyInfo keyInfo;
            int choice = 0;
            string[] carorMC = { "Car", "MC", "Return" };
            int maxLength = carorMC.Max(item => item.Length) + 4;

            while (true)
            {
                Console.SetCursorPosition(0, 4);            // Här börjar positionen av vår Cursor på rad 2 för att 0 - 1 är reserverad för vår rubrik

                for (int i = 0; i < carorMC.Length; i++)
                {
                    string menuItem = $"{i + 1}. {carorMC[i]}";
                    string alignedText = menuItem.PadRight(maxLength);

                    string centeredText = GetCenterText(alignedText);

                    if (i == choice)
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine(centeredText);
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.WriteLine(centeredText);
                    }
                }

                keyInfo = Console.ReadKey(true);

                if (keyInfo.Key == ConsoleKey.UpArrow)          // Läser in våra keys så att vi kan röra oss upp ner och enter för att gå in
                {
                    if (choice > 0)
                        choice--;
                }
                else if (keyInfo.Key == ConsoleKey.DownArrow)
                {
                    if (choice < carorMC.Length - 1)
                        choice++;
                }
                else if (keyInfo.Key == ConsoleKey.Enter)
                {
                    switch (choice)
                    {
                        case 0:

                            CenterText("Car");
                            Console.Clear();
                            HelloWorld();
                            ManipulateParking.CarSearch();
                            return;
                        case 1:
                            CenterText("MC");
                            Console.Clear();
                            HelloWorld();
                            ManipulateParking.McSearch();
                            return;
                        case 2:
                            CenterText("Retrun");
                            return;
                    }
                }
            }
        }
        public static void CarorMCMove()
        {
            Console.Clear();
            CenterTextLine("Hello, World Prague Parking");
            CenterText("Move a vehicle");
            ConsoleKeyInfo keyInfo;
            int choice = 0;
            string[] carorMC = { "Car", "MC", "Return" };
            int maxLength = carorMC.Max(item => item.Length) + 4;

            while (true)
            {
                Console.SetCursorPosition(0, 4);            // Här börjar positionen av vår Cursor på rad 2 för att 0 - 1 är reserverad för vår rubrik

                for (int i = 0; i < carorMC.Length; i++)
                {
                    string menuItem = $"{i + 1}. {carorMC[i]}";
                    string alignedText = menuItem.PadRight(maxLength);

                    string centeredText = GetCenterText(alignedText);

                    if (i == choice)
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine(centeredText);
                        Console.ResetColor();
                    }
                    else
                    {

                        Console.WriteLine(centeredText);
                    }

                }

                keyInfo = Console.ReadKey(true);

                if (keyInfo.Key == ConsoleKey.UpArrow)          // Läser in våra keys så att vi kan röra oss upp ner och enter för att gå in
                {
                    if (choice > 0)
                        choice--;
                }
                else if (keyInfo.Key == ConsoleKey.DownArrow)
                {
                    if (choice < carorMC.Length - 1)
                        choice++;
                }
                else if (keyInfo.Key == ConsoleKey.Enter)
                {
                    switch (choice)
                    {
                        case 0:

                            CenterText("Car");
                            Console.Clear();
                            HelloWorld();
                            ManipulateParking.MoveCar();
                            return;
                        case 1:
                            CenterText("MC");
                            Console.Clear();
                            HelloWorld();
                            ManipulateParking.MoveMC();
                            return;
                        case 2:
                            CenterText("Retrun");
                            return;
                    }
                }
            }
        }
    }
}
