using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWPragueParkingV1
{
    internal class InfoArray
    { 
        public static string[] ArrayParking = new string[101];     // Så att array sparas som private.
                                                                   // samt Array som sparar info

        public static void CreateParking()
        {
            int rows = 101;

            string[] ArrayParking = new string[rows];

            for (int row = 0; row < rows; row++)
            {
                ArrayParking[row] = "0";
            }




            //check

            //for (int i = 0; i < ArrayParking.Length; i++)

            //{

            //    Console.Write("{0} ", ArrayParking[i]);
            //}
            //Console.WriteLine();


        }
    }
}
