using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Basic
{
    class Emp
    {
        public int id;
        public string name;
        public int salary;

        public Emp()
        {
        }

        public Emp(int id, string name, int salary)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
        }
        public void show()
        {
            Console.WriteLine("emp id "+id);
            Console.WriteLine("name is "+name);
            Console.WriteLine("salary "+salary);
        }
    

    
        static void Main(string[] args)
        {


            Emp e = new Emp(10, "Nisha", 23456);
            e.show();

        } 
    }
}
