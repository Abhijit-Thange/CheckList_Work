using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicVarObject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            dynamic obj = "Abhi";
            Console.WriteLine(obj);
            obj= 10;
            Console.WriteLine(obj);

            dynamic x = 10;
            dynamic y = 20;
            var a = x+y;
            

            Console.ReadLine();
        }
    }
}
