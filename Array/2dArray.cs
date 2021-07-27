using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Array
{
    class Array2d
    {
        static void Main(string[] args)
        {


            int[,] s = new int[3, 3];
            for (int i = 0; i < s.GetLength(0); i++)
            {
                for (int j = 0; j < s.GetLength(1); j++)
                {
                    s[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for (int i = 0; i < s.GetLength(0); i++)
            {
                for (int j = 0; j < s.GetLength(1); j++)
                {
                    Console.WriteLine(s[i, j]);
                }
                Console.WriteLine();
            }


        }
    }
}
