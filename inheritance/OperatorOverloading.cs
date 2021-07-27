using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.inheritance
{
    class OperatorOverloading
    {
        int a, b;
        public OperatorOverloading()
        {

        }
        public OperatorOverloading(int a, int b)
        {
            this.A = a;
            this.B = b;
        }
        public int A { get => a; set => a = value; }
        public int B { get => b; set => b = value; }
        public static OperatorOverloading operator+(OperatorOverloading o1, OperatorOverloading o2)
        {
            OperatorOverloading o3 = new OperatorOverloading();
              o3.a=o1.a + o2.a;
              o3.b=o1.b +o2.b;
                return o3;
        }
        static void Main(string[] args)
      {
        OperatorOverloading ob1 = new OperatorOverloading(10, 20);
        OperatorOverloading ob2 = new OperatorOverloading(3, 6);
        OperatorOverloading ob3 = ob1 + ob2;
        Console.WriteLine(ob3.A);
        Console.WriteLine(ob3.B);





      }

    }
}
