using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.inheritance
{
    class Parent
    {
        public virtual void m1()
        {
            Console.WriteLine(" 1 st parent ");
        }
        public void m2()
        {
            Console.WriteLine(" 2 nd parent ");
        }
    }
    class Child3 :Parent
    {
        public  sealed override void m1()
        {
            Console.WriteLine(" 1 st child ");
        }
    }
    class Test3
    { 
      static void Main(string[] args)
        {
            Parent p1 = new Child3();
            p1.m1();
            p1.m2();
            Console.WriteLine("cant modified");
        }
    }
}
