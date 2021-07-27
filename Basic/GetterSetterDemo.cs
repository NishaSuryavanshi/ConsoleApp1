using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Basic
{
    class Employee
    {
        private int id;
        private string name;
        public int getId()
        {
            return id;
        }
        public void setId(int id)
        {
            this.id = id;
        }
        public String getName()
        {
            return name;
        }
        public void setName(string name)
        {
            this.name = name;
        }
        public void display()
        {
            Console.WriteLine("id "+id);
            Console.WriteLine("name "+name);
        }


        static void Main(string[] args)
        {
            Employee e = new Employee();
            e.setId(1);
            e.setName("nisha");
            e.display();
        }
    }
}
