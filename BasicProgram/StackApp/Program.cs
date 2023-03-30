using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();

            stack.Push(10);
            stack.Push(20);
            stack.Push(30);
            stack.Push(40);
            stack.Push(90);


            for (int i = 0;i < 5;i++)
            {
                Console.WriteLine(stack.Pop());
                
            }
            Console.ReadLine();

        }
    }

    class Stack
    {
        public List<object> list=new List<object>();

        public void Push(int x) 
        { 
            //if(list.Count==0)
             //   Console.WriteLine("Element Not Availlable... ");
            
            list.Add(x);
        }

        public int Pop()
        {
            int index=0;
            if (list.Count == 0)
                Console.WriteLine("Stack is Empty...");
            else
            {
                 index = (int)list[list.Count - 1];
                //var toreturn= list[index];
                list.RemoveAt(list.Count - 1);
            }
            return index;
            
        }
    }

}
