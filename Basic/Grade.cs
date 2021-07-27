using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Basic
{
    class Grade
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the no");
            int num = Convert.ToInt32(Console.ReadLine());
            if(num<=0 && num>100)
            {
                Console.WriteLine("wrong");
            }
            else if (num <= 100 && num > 50)
            {
                Console.WriteLine("B grade");
            }
            else if (num <= 50 && num > 50)
            {
                Console.WriteLine("B grade");
            }
        }
    }
}
