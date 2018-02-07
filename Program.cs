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
             Console.WriteLine("Queue Implementation");
            Console.WriteLine("Elements to queue");
            QueueImplementation<object> queue = new QueueImplementation<object>(3);
            queue.Enqueue(1);
            queue.Enqueue("two");
            queue.Enqueue(3);
            queue.Enqueue("Four");
            queue.display();
            Console.ReadLine();
            queue.Dequeue();
            queue.Dequeue();
            Console.WriteLine("After Dequeue");
            queue.display();
            Console.ReadLine();


            Console.WriteLine("LinkedList Implementation");
            LinkedListImplementation linklst = new LinkedListImplementation();
            linklst.AppendToEnd(7);
            Console.WriteLine("Linked List are:");
            linklst.printList();
            linklst.AppendToEnd("Eight");
            linklst.AppendToEnd("Nine");
            linklst.push(5);

            Console.WriteLine("Linked List are:");
            linklst.printList();

            linklst.insertAfterNode(linklst.head, 6);
            Console.WriteLine("Linked List are:");
            linklst.printList();


        }
    }

    
}
