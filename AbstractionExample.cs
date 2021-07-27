using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public abstract class Shape
    {
        public abstract void drawing();
    }
    public class Rectangle:Shape
    {
        public override void drawing()
        {
            Console.WriteLine("drawing rectangle");
        }
    }
    public class Circle :Shape
    {
        public override void drawing()
        {
            Console.WriteLine("drawing circle");
        }
    }
    class AbstractionExample
    {
        static void Main(string[] args)
        {
            Shape s = new Rectangle();
            s.drawing();
            Shape s1 = new Circle();
            s1.drawing();
        }
    }
}
