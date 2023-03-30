using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace StopWatchProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw=new Stopwatch();
            sw.Start();
            
            Console.WriteLine(sw.ElapsedTicks);
            Console.ReadLine();

        }
    }
}
