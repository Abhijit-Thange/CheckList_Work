using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Parent
    {
        public virtual void Print()
        {
            Console.WriteLine("Parent Class");
        }
    }

    class Child :Parent
    {
        public override void Print()
        {
          //  base.Print();
            Console.WriteLine("Child Class....");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Parent c= new Child();
            c.Print();
            Console.ReadLine();
        }
    }
}
