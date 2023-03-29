using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder str1 = new StringBuilder("Nimap");

            var program = new Program();

            string str2 = "Good Afternoon";
            int s = 1234;
            string s1=s.ToString("x");
            Console.WriteLine(s1);

            Console.WriteLine(str2.IndexOf('A'));
            Console.ReadLine();
        }
    }
}
