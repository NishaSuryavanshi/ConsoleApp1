using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.StringDemo
{
    class Class1
    {
        public static void Main(string[] args)
        {
            string s1 = "hello";
            string s2 = "hello";
            string s3 = "csharp";
            string s4 = "mello";

            Console.WriteLine(s1.CompareTo( s2));
            Console.WriteLine(s2.CompareTo( s3));
            Console.WriteLine( s3.CompareTo(s4));
        }
    }
}

