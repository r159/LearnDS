using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    public class QueueImplementation<T> : IQueue<T>
    {
        private T[] queueelemts;
        private int front,rear, size, capacity;
        public QueueImplementation()
        {
           
            front = this.size= 0;
            this.capacity = 10;
            rear = capacity - 1;
            queueelemts = new T[this.capacity];
            


        }
        public QueueImplementation(int capacity)
        {
            if(capacity <1)
                throw new ArgumentOutOfRangeException("N");
            else

                front = this.size = 0;
                this.capacity = capacity;
                rear = capacity - 1;
                queueelemts = new T[this.capacity];

        }
        public bool isFull(QueueImplementation<T> queue)
        {
            return (queue.size == queue.capacity);
 
        }
        public bool isEmpty(QueueImplementation<T> queue)
        {
            return (queue.size == 0);
        }
        public void Enqueue(T item)
        {
            if (isFull(this))
                Console.WriteLine("Queue is full"); 
            else
            {
                rear = (rear + 1) % capacity;
                queueelemts[rear] = item;
                size = size + 1;
                Console.WriteLine("Item added to the queue");
            }

        }
        public void Dequeue()
        {
            if (isEmpty(this))
                Console.WriteLine("Queue is Empty");
            else
            {
                T item = this.queueelemts[this.front];
                front = (front + 1) % capacity;
                size = size - 1;
                Console.WriteLine("deleted Item is :" + item);
            }

            


        }
        public void display()
        {
            for(int i = front; i<=rear; i++)
            {
                Console.WriteLine("Item: "+ queueelemts[i]);
            }
        }
    }
    interface IQueue<T>
    {
        void display();
        void Dequeue();
        void Enqueue(T item);

        bool isFull(QueueImplementation<T> queue);
        bool isEmpty(QueueImplementation<T> queue);

    }
}
