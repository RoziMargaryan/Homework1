/*Write a program to find the maximum and minimum elements in a given array.*/



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] arr = { 1, 6, 32, 8, 67 };

            int min = arr[0];
            int max = arr[0];

            for(int i=0; i<arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }

                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }

            Console.WriteLine($"Minimum value is {min}");
            Console.WriteLine($"Maximum value is {max}");
        }
    }
}
