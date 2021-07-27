using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Basic
{
    class NestedFor
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 9; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine(i + " " + j);
                }

            }

        }
    }
}
