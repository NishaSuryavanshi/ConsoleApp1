using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Basic
{
    class Employe
    {
        private int id;
        private string name;
        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = id;
            }
        }
        public String Name
        {
            get
            {
                return name;
            }
            set
            {
                this.name = name;
            }
        }
        static void Main(string[] args)
        {
            Employe e = new Employe();
            
        }


    }
}
