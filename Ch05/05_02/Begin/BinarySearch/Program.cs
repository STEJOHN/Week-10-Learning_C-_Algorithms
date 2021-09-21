using System;
using static System.Console;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int thevalue = 43;
            int[] array = new int[] { 11, 22, 43, 54, 57, 59, 62, 78 };

            WriteLine("Our array contains: ");
            Array.ForEach(array, x => Write(x + " "));

            Write($"\n\nThe result of a binary search for {thevalue} is: ");
            WriteLine(BinarySearch(array, thevalue));

            ReadKey();

        }

        // a = array
        //  x = what we are searching
        //  p  = first index
        //   q = midpoint
        //    r = last index

        public static int BinarySearch(int[] a, int x)
        {
            int p = 0;
            int r = a.Length - 1;

            while (p <= r)
            {
                int q = (p + r) / 2;
                if (x < a[q])

                    r = q - 1;

                else if (x > a[q])

                    p = q + 1;

                else return q;
            }

            return -1;
        }
    }
}
