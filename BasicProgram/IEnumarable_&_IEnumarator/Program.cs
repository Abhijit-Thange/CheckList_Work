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
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(6);
            list.Add(7);

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
