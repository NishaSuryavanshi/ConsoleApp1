using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public delegate void MyDelegate(string msg);
    class Program1
    {
        static void Main(string[] args)
        {
           MyDelegate del = ClassA.MethodA;
            InvokeDelegate(del);

            del = ClassB.MethodB;
            InvokeDelegate(del);

            del = (string msg) => Console.WriteLine("Called lambda expression: " + msg);
            InvokeDelegate(del);
        }

        static void InvokeDelegate(MyDelegate del) // MyDelegate type parameter
        {
            del("Hello World");
        }
    }

    class ClassA
    {
        public static void MethodA(string message)
        {
            Console.WriteLine("Called ClassA.MethodA() with parameter: " + message);
        }
    }

    class ClassB
    {
        public static void MethodB(string message)
        {
            Console.WriteLine("Called ClassB.MethodB() with parameter: " + message);
        }
    }
}

