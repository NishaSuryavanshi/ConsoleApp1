using System;

namespace ConsoleApp1
{
    public class Employee
    {
        public float salary = 40000;
    }

    public class Permanent : Employee
    {
        public float bonus = 10000;
    }
    class Program
    {

    
        public static void Main(string[] args)
        {
            Permanent p1 = new Permanent ();
            Console.WriteLine("Salary " + p1.salary);
            Console.WriteLine("bonus " + p1.bonus);

        }
    }

}  
    

