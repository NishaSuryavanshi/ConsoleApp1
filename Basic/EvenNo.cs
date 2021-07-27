using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Basic
{
    class EvenNo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the no");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("even no");
            }
            else
            {
                Console.WriteLine("odd no");
            }


        }


    }
}
