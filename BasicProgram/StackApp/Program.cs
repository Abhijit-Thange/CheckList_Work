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

            for(int i = 0; i < 5;i++)
            {
                stack.Push(i);
            }
            
            for(int i = 0;i < 5;i++)
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
            
            list.Addition(x);
        }

        public int Pop()
        {
            if(list.Count==0)   
                Console.WriteLine("Stack is Empty...");
            var index=list.Count-1;
            var toreturn= list[index];
            list.RemoveAt(list.Count-1);
            return index;
            
        }
    }

}
