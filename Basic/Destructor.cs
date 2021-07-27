using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Basic
{
    class Emploe
    {
        public Emploe()
        {
            Console.WriteLine("constructor invoked");
        }
        ~Emploe()
        {
            Console.WriteLine("destructor invoked");

        }
        static void Main(string[] args)
        {
            Emploe e = new Emploe();
        }


    }
}
