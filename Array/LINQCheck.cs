using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ConsoleApp1.Array
{
    class LINQCheck
    {
        static void Main(string[] args)
        {
            int [] a = { 12, 34, 45, 3, 56, 7, 67 };
            var x = from d in a where d>10 orderby d select d;
            Console.WriteLine(x.GetType());
            foreach(int n in x)
            {
                Console.WriteLine(n);
            }


        }
        
       
    }
}
