using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class Node
    {
        public object data;
        public Node next;
        public Node(object d)
        {
            data = d;
            next = null;
        }
    }
    class LinkedListImplementation
    {
        public Node head;
        
        public void push(object new_data)
        {
            Node new_node = new Node(new_data);
            new_node.next = head;
            head = new_node;
        }

        public void insertAfterNode(Node previousNode, object data)
        {
            if(previousNode == null)
            {
                Console.WriteLine("Previous node can not be null");
                return;
            }
            Node new_node = new Node(data);
            new_node.next = previousNode.next;
            previousNode.next = new_node;
        }

        public void AppendToEnd(object data)
        {
            Node new_node = new Node(data);
            if(head == null)
            {
                head = new_node;
                return;

            }
            new_node.next = null;
            Node last = head;
            while (last.next != null)
                last = last.next;

            last.next = new_node;
            return;

        }

        public void printList()
        {
            Node printNode = head;
            while(printNode != null)
            {
                Console.WriteLine("Data is " + printNode.data);
                printNode = printNode.next;
            }
        }

    }
}
