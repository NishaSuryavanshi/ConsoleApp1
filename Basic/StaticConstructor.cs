using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Basic
{
    class Account
    {
        public int id;
        public string name;
        public static float rateOfInterest;

        public Account(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
        static Account()
        {
            rateOfInterest = 9.5f;
        }
        public void display()
        {
            Console.WriteLine(id+" "+name+" "+rateOfInterest);
        }
        static void Main(string[] args)
        {
            Account a = new Account(1,"nisha");
            Account a1 = new Account(2, "nami");
            a.display();
            a1.display();
            
        }
    }

}
