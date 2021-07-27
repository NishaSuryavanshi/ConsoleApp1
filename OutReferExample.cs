using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class OutReferExample
    {
        static void m1(int x)
        {
            x++;
        }
        static void Main(string[] args)
        {
            int x = 100;
            Console.WriteLine(x);
            m1(x);
            Console.WriteLine(x);
        }
    }
}
