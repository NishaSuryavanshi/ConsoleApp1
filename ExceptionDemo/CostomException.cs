using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.ExceptionDemo
{
    class CostomException :ApplicationException
    {
        static void m1()
        {
            Console.WriteLine("enter age");
            int a = int.Parse(Console.ReadLine());
          //  if (a < 0)
            //    throw new InvalidAgeException("invalide age");
        }
        static void Main(string[] args)
        {
            CostomException c = new CostomException();
          //  c.m1();
        }
    }
}
