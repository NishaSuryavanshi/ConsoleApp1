using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Basic
{
    class Continue
    {
        static void Main(string[] args)
        {
            for(int i=0;i<=10;i++)
            {
                if(i==5)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
        }
    }
}
