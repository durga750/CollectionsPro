using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{

    public delegate void Delegate(int num1, int num2);
    class Examp
    {
        public void add(int a,int b)
        {
            Console.WriteLine($"sum={a+b}");
        }
        public void sub(int a, int b)
        {
            Console.WriteLine($"sub={a - b}");
        }
        public void mul(int a, int b)
        {
            Console.WriteLine($"mul={a * b}");
        }
        public void div(int a, int b)
        {
            Console.WriteLine($"div={a / b}");
        }
    }
    class DelegatePro
    {
        static void Main(string[] args)
        {
            Delegate d1 = new Delegate(new Examp().add);
            d1(2, 3);
            Delegate d2 = new Delegate(new Examp().sub);
            d2(5, 3);
            Delegate d3 = new Delegate(new Examp().mul);
            d3(5, 3);
            Delegate d4 = new Delegate(new Examp().div);
            d4(15, 3);
            Console.WriteLine("sum of all dlegates");
            Delegate d5 = d1 + d2 + d3 + d4;
            d5(4, 5);
           
           




        }
    }
}
