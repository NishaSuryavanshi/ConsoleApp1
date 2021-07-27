using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.ExceptionDemo
{
    class Class1
    {
        static void Main(string[] args)
        {
            try
            {
                int a = 10;
                int b = 0;
                Console.WriteLine("div" + (a / b));
            }
            catch(Exception e)
            {
                Console.WriteLine("exception occurs");
            }
            finally
            {
                Console.WriteLine("in fallay");
            }

            }
        
    }
}
