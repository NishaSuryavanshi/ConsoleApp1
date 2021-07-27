using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Interface
{
    public interface Drawable
    {
        void draw();
    }
    public class Rectangle : Drawable
    {
        public void draw()
        {
            Console.WriteLine("drawing rectangle...");
        }
    }
    public class Circle : Drawable
    {
        public void draw()
        {
            Console.WriteLine("drawing circle...");
        }
    }
    public class TestInterface
    {
        public static void Main()
        {
           
           Drawable d = new Rectangle();
            d.draw();
            d = new Circle();
            d.draw();
        }
    }
    
    }

