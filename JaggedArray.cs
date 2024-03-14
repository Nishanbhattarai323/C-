using System;

namespace Ncit_Nishan {

    class JaggedArray
    {
        static void Main()
        {
            // Declare and initialize a jagged array
            int[][] jaggedArray = new int[3][];

            // Initialize each inner array with different lengths
            jaggedArray[0] = new int[] { 9, 5, 8 };
            jaggedArray[1] = new int[] { 4, 5, 6, 7 };
            jaggedArray[2] = new int[] { 8, 9 };

            
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                Console.Write("Row {0}: ", i);
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write(jaggedArray[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }




}
