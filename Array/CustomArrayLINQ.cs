using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ConsoleApp1.Array
{
    class Emp
    {
        int eid;
        string name;
        int salary;
        string city;

        public Emp()
        {
        }

        public Emp(int eid, string name, int salary, string city)
        {
            this.Eid = eid;
            this.Name = name;
            this.Salary = salary;
            this.City = city;
        }

        public int Eid { get => eid; set => eid = value; }
        public string Name { get => name; set => name = value; }
        public int Salary { get => salary; set => salary = value; }
        public string City { get => city; set => city = value; }
    }
    class CustomArrayLINQ
    {
        static void Main(string[] args)
        {
           // Emp[] earr = new Emp[];
        }

    }

}
