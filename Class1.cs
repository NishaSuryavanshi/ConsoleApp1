using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Class1
    {
        public static void Main(string[] args)
        {
            string s1 = "hello";
            string s2 = "hello";
            string s3 = "csharp";
            string s4 = "mello";

            Console.WriteLine(string.Compare(s1, s2));
            Console.WriteLine(string.Compare(s2, s3));
            Console.WriteLine(string.Compare(s3, s4));
        }
    }
}

