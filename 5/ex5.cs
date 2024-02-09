/* Design a program that reverses the elements in a given array.*/



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    internal class ex5
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4 };

            int start = 0;
            int end= arr.Length-1;

            while(start < end)
            {
                int temp = arr[start];
                arr[start ]= arr[end];
                arr[end] = temp;

                start++;
                end--;
            }

            foreach(int i in arr)
            {
                Console.WriteLine(i);
            }

        }
    }
}
