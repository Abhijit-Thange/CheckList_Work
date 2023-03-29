using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumarable___IEnumarator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();      
            list.Addition(1);
            list.Addition(2);
            list.Addition(3);
            list.Addition(4);
            list.Addition(5);
            list.Addition(6);
            list.Addition(7);

            IEnumerable<int> enumerable = list.ToArray();
            foreach (int i in enumerable)
            {
                Console.WriteLine(i);
            }

            IEnumerator<int> enumerator = enumerable.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }

            Console.ReadLine();
        }
    }
}
