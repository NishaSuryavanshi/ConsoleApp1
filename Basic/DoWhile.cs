using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Basic
{
    class DoWhile
    {
        static void Main(string[] args)
        {
            int i = 1;
            do
            {
                Console.WriteLine(i);
                i++;
            }
             while (i <= 10);
        }
    }
}
