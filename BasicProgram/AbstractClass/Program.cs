using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }

   abstract class A
    {
        public abstract void Run();
        public abstract void Test();
    }

    class B : A
    {
        public override void Run() { }

        public override void Test() { }
    }

}
