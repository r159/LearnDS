using Stack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Stack Implementation");
            Console.WriteLine("Enter Element to stack");
            StackImplementation<object> stack = new StackImplementation<object>();
            stack.push(1);
            stack.push("one");
            stack.display();
            object poppedElement = stack.pop();
            Console.WriteLine("Popped Element: : " + poppedElement);
            poppedElement = stack.pop();
            Console.WriteLine("Popped Element: : " + poppedElement);
          
            Console.ReadLine();


        }
    }

    
}
