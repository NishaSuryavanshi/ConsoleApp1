using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Dog
    {

        // Instance Variables
        string name;
        string breed;
        int age;
        string color;

        // Constructor Declaration of Class
        public Dog(string name, string breed,
                      int age, string color)
        {
            this.name = name;
            this.breed = breed;
            this.age = age;
            this.color = color;
        }

        // Property 1
        public string getName()
        {
            return name;
        }

        // Property 2
        public string getBreed()
        {
            return breed;
        }

        // Property 3
        public int getAge()
        {
            return age;
        }

        // Property 4
        public string getColor()
        {
            return color;
        }

        // Method 1
        public string toString()
        {
            return ("Hi my name is " + this.getName()
                    + ".\nMy breed, age and color are " + this.getBreed()
                    + ", " + this.getAge() + ", " + this.getColor());
        }

        // Main Method
        public static void Main(string[] args)
        {

            // Creating object
            Dog tuffy = new Dog("tuffy", "papillon", 5, "white");
            Console.WriteLine(tuffy.toString());
        }
    }
}
