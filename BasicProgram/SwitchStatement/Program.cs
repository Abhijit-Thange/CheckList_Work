using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace SwitchStatement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a NUmber" );
            int i=Console.Read();

            switch(i)
            {
                case 'a': Console.WriteLine(i); break;

                    case 'b': Console.WriteLine(i);   Console.WriteLine(i); break;

                    case 'c': Console.WriteLine(i);  break;


            }

            Console.ReadLine();
        }
    }
}
