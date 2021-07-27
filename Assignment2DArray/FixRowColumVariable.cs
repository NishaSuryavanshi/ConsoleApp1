using System;
using System.Collections.Generic;
using System.Text;
//2.	WAP to accept data in 2D array where rows are fixed and columns are variable.
namespace ConsoleApp1.Assignment2DArray
{
    class FixRowColumVariable
    {
        static void Main(string[] args)
        {
            int[][] jag = new int[3][];

            jag[0] = new int[] { 12, 34, 5, 6, 7 };
            jag[1] = new int[] { 15, 52 };
            jag[2] = new int[] { 1, 2, 3 };

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < jag[i].Length; j++)
                {
                    Console.Write( jag[i][j]);
                }
                Console.WriteLine();
            }

           // Console.ReadKey();
        }
    }
}
