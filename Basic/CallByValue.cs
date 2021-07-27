using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Basic
{
    class CallByValue
    {
        public void show(int var)
        {
            var = var * var;
            Console.WriteLine("value in method "+var);
        }
        static void Main(string[] args)
        {
            int var = 50;
            CallByValue c = new CallByValue();
            Console.WriteLine("value before calling method "+var);
            c.show(var);
            Console.WriteLine("value after calling method "+var);
        }
    }
}
