using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWPragueParkingV1
{
    internal class InfoArray
    { 
        public static string[] ArrayParking = new string[101];     
                                                                   // samt Array som sparar info

        public static void CreateParking()
        {
            ArrayParking[0] = "$";                                 // parking space 0 used for moving vehicles if parking is full
            for (int row = 1; row < ArrayParking.Length; row++)
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


//gitcheck