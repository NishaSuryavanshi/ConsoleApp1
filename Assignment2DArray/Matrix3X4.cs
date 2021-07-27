using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Assignment2DArray
{
    class Matrix3X4
    {
        static void Main(string[] args)
        {
            int[,] arr = { { 1, 2, 3,4 }, { 4, 5, 6 ,4}, { 7, 8, 9 ,4} };//declaration and initialization  

            //traversal  
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();//new line at each row  
            }
        }
    }
}
    

