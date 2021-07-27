using System;
using System.Collections.Generic;
using System.Text;
//4.	WAP to print minimum in columns. Means e.g. arr[][]={{22, 31, 9}, {12, 5,16},
//{34, 42, 2}} output is: 12, 5, 2.
namespace ConsoleApp1.Assignment2DArray
{
    class MinimumRowWise
    {
        public static void minelement(int no_of_rows,
                                      int[][] arr)
        {
            int i = 0;

            // Initialize max to 0 at beginning
            // of finding max element of each row
            int min = 0;
            int[] result = new int[no_of_rows];
            while (i < no_of_rows)
            {
                for (int j = 0;
                         j < arr[i].Length; j++)
                {
                    if (arr[i][j] < min)
                    {
                        min = arr[i][j];
                    }
                }
                result[i] = min;
                min = 0;
                i++;

            }
            printArray(result);

        }

        // Print array element
        private static void printArray(int[] result)
        {
            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine(result[i]);
            }

        }

        // Driver code
        public static void Main(string[] args)
        {
            int[][] arr = new int[][]
            {
        new int[] {3, 4, 1, 8},
        new int[] {1, 4, 9, 11},
        new int[] {76, 34, 21, 1},
        new int[] {2, 1, 4, 5}
            };

            // Calling the function
            minelement(4, arr);
        }
    }
}
