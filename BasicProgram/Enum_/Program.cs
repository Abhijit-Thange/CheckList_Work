using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Test r = Test.third;
            Console.WriteLine((int)Test.eight);
            Console.ReadLine();
        }
    }

    enum Test
    {
        first=1, 
        second=2,
        third=3,
        seven=7,
        eight
    }

}
