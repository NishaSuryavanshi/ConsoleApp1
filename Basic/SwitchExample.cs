using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Basic
{
    class SwitchExample
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the no");
            int num = Convert.ToInt32(Console.ReadLine());
            switch (num)
            {
                case 10:
                    Console.WriteLine("it is 10");
                    break;
                case 20:
                    Console.WriteLine("it is 20");
                    break;
                default:
                    Console.WriteLine("it is not 10 or 20");
                    break;

            }
        }
    }
}
