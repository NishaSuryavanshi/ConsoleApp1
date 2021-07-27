using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.ContainmentDemo
{
    public class Address
    {
        public string addressLine;
        public string city;
        public string state;
        public Address()
        {
            //default constructor
        }
        public Address(string addressLine,string city,string state)
        {
            this.addressLine = addressLine;
            this.city = city;
            this.state = state;
        }
    }

   public class Employee
    {
       public int id;
        public string name;
        public Address address;

        public Employee()
        {
            //default constructor
        }
        public Employee(int id, string name, Address address)
        {
            this.id = id;
            this.name = name;
            this.address = address;
        }
        public void display()
        {
            Console.WriteLine(id+" "+name);
            Console.WriteLine(address.addressLine+" "+address.city+" "+address.state);
        }
        
    }
    class Class1
    {
        static void Main(string[] args)
        {
            Address ad = new Address("G-3,section 2", "umbraj", "maharashtr");
            Employee e = new Employee(1, "Nisha", ad);
            e.display();
        }
      
        
         

    }
}
