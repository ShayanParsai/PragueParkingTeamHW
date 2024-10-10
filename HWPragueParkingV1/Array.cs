using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWPragueParkingV1
{
    class Array
    {
        private string[,] ArrayParking = new string[2, 101];     // Så att array sparas som private.

        public static void StartSpaces()
        {
            int rows = 2;
            int columns = 101;

            string[,] ArrayParking = new string[rows, columns];


            for (int row = 0; row < rows; row++)
            {
                for (int column = 0; column < columns; column++)
                {
                    ArrayParking[row, column] = "0";
                }
            }

            //check

            //for (int i = 0; i < ArrayParking.GetLength(0); i++)      
            //{
            //    for (int j = 0; j < ArrayParking.GetLength(1); j++)
            //    {
            //        Console.Write("{0} ", ArrayParking[i, j]);
            //    }
            //    Console.WriteLine();
            //}

        }
    }            
}
