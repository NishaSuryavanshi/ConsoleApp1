using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.inheritance
{
    public class GetValuesTest
    {
        enum Colors { Red, Green, Blue, Yellow };
        enum Styles { Plaid = 0, Striped = 23, Tartan = 65, Corduroy = 78 };

        public static void Main()
        {

            Console.WriteLine("The values of the Colors Enum are:");
            foreach (int i in Enum.GetValues(typeof(Colors)))
                Console.WriteLine(i);

            Console.WriteLine();

            Console.WriteLine("The values of the Styles Enum are:");
            foreach (int i in Enum.GetValues(typeof(Styles)))
                Console.WriteLine(i);
        }
    }
   
    }

