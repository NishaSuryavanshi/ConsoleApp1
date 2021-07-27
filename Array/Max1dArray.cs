using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Array
{
    class Max1dArray
    {
        static void Main(string[] args)
        {
            int [] a= new int[5];
            for(int i=0;i<a.Length;i++)
            {
                a[i] =int.Parse(Console.ReadLine());

            }
            Console.WriteLine("max element is");
            int max = a[0];
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > max)
                    max = a[i];

            }
            Console.WriteLine(max);

        }
      
        
    }
}
