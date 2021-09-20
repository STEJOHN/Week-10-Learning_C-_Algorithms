using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO
        }
    }

    public class Stack
    {
        private int maxSize;
        private string[] stackArray;
        private int top;

        public Stack(int size)
        {
            maxSize = size;
            stackArray = new string[maxSize];
            top = -1;
        }

        public void Push(string m)
        {
            if (isFull())
            {

                WriteLine("This stack is full");
            }
            else
            {
                top++;
                stackArray[top] = m;
            }
        }

        private bool isFull()
        {
            return (maxSize - 1 == top);
        }
    }
}
