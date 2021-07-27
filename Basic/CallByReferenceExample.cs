using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Basic
{
    class CallByReferenceExample
    {
        public void show(ref int var)
        {
            var = var * var;
            Console.WriteLine("value in method "+var);
        }
        static void Main(string[] args)
        {
            int var = 10;
            Console.WriteLine("value after method calling " + var);

            CallByReferenceExample c = new CallByReferenceExample();
            c.show(ref var);
            Console.WriteLine("value before method calling "+var);

        }
    }
}
