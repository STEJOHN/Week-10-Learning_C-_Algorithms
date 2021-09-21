using static System.Console;

namespace QueueDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO
        }
    }

    public class Queue
    {
        private int maxSize;
        private long[] myQueue;
        private int front;
        private int rear;
        private int items;

        public Queue(int size)
        {
            maxSize = size;
            myQueue = new long[size];
            front = 0;
            rear = -1;
            items = 0;
        }

        public void Insert(long j)
        {
            if (isFull())
            {
                WriteLine("Queue is full");
            }
            else
            {
                if (rear == maxSize - 1)
                {
                    rear = -1;
                }
                rear++;
                myQueue[rear] = j;
                items++;
            }
        }
        public long Remove()
        {
            long temp = myQueue[front];
            front++;
            if (front == maxSize)
            {
                front = 0;
            }
            return temp;
        }

        public long PeekFront()
        {
            return myQueue[front];
        }

        public bool IsEmpty()
        {
            return (items == 0);
        }

        private bool isFull()
        {
            return (items == maxSize);

        }
    }

}
