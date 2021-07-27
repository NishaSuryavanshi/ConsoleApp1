using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Basic
{
    class OutParameter
    {
        public void show(out int var)
        {
            int square = 5;
            var = square;
            var = var * var;

        }
        static void Main(string[] args)
        {
            int var = 10;
            Console.WriteLine("value after "+var);
            OutParameter o = new OutParameter();
            o.show( out var);
            Console.WriteLine("value "+var);

        }
    }
}
