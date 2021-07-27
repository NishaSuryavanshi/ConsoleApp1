using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.ExceptionDemo
{
    class TupalDemo
    {
        static(int,int) calculator(int a,int b)
        {
            return (a + b, a * b);
        }
        static void Main(string[] args)
        {
            var x = calculator(1, 2);
            Console.WriteLine(x.Item1);
            Console.WriteLine(x.Item2);
        }
    }
}
