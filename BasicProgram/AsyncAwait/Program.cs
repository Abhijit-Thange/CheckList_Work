using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncAwait
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Test();
            Console.ReadLine();

        }

        public static async void Test() 
        {
            Console.WriteLine("Thtead Start...");
           await Task.Run(new Action(Check));
            Console.WriteLine("Thred Complete......");
        }

        public static void Check() 
        {
            Thread.Sleep(2000);
        
        }
    }
}
