using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    public class StackImplementation<T> : IStack<T>
    {
        private T[] stackelemts;
        private int currentIndex;
        public StackImplementation()
        {
            stackelemts = new T[10];
            currentIndex = 0;

        }
        public StackImplementation(int numofElements)
        {
            if (numofElements < 0)
                throw new ArgumentOutOfRangeException("N");
            else
            {
                stackelemts = new T[numofElements];
                currentIndex = 0;
            }
        }

        public void push(T element)
        {
            if (currentIndex + 1 > stackelemts.Length)
            {
                Console.WriteLine("Stack overflow");
            }
            else
            {
                stackelemts[currentIndex++] = element;
            }
        }
        public T pop()
        {
            if (currentIndex == 0)
                throw new InvalidOperationException("The Stack is Empty");

            T element = stackelemts[--currentIndex];
            stackelemts[currentIndex] = default(T);
            return element;
        }
        public void display()
        {
            for(int i=currentIndex-1; i>=0;i--)
            {
                Console.WriteLine("Item {0}: {1}", (i), stackelemts[i]);
                
            }
        }
    }
    interface IStack<T>
    {
        void push(T element);
        T pop();
        void display();
    }
}
