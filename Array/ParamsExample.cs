using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Array
{
    class ParamsExample1
    {
        static void sum(int a, int b)
        {
            Console.WriteLine("sum =" + (a + b));
        }
        static void findingsum(params int[] z)
        {
            int t = 0;


            foreach (int i in z)
            {
                t = t + i;
                Console.WriteLine("hi this is param array" + t);

            }

        }
        static void Main(string[] args)
        {
            sum(10, 20);
            findingsum(1, 2, 3, 5);

        }
    }
}
