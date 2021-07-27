using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.inheritance
{
    class Methodoverride
    {
        public virtual void m1()
        {
            Console.WriteLine("i am parent");
        }
        public void m2()
        {
            Console.WriteLine("parent");
        }
    }
    class Child1 :Methodoverride
    {
        public override void m1()
        {
            Console.WriteLine("i am child");
        }
        public void m3()
        {
            Console.WriteLine("child");
        }
    }
    class Test1
    {
        static void Main(string[] args)
        {
            Methodoverride p1 = new Child1();
            p1.m1();
            p1.m2();
           // p1.m3();
        }
    }
}
