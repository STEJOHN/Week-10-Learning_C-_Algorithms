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
            Stack theStack = new Stack(4);
            theStack.Push("Star Wars");
            theStack.Push("Jaws");
            theStack.Push("Jaws 2");
            theStack.Push("Titanic");
            theStack.Push("Rocky");

            WriteLine("===========================  \nThe Stack contains:\n");
            while (!theStack.isEmpty())
            {
                string movie = theStack.pop();
                WriteLine(movie);

               
            }
            ReadKey();
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

        public string pop()
        {
            if (isEmpty())
            {
                WriteLine("the stack is empty.");
                return "--";
            }
            else
            {
                int old_top = top;
                top--;
                return stackArray[old_top]; 
            }
        }

        public string Peek()
        {
            return stackArray[top];
        }

        public bool isEmpty()
        {
            return (top == -1);
        }

        private bool isFull()
        {
            return (maxSize - 1 == top);
        }
    }
}
