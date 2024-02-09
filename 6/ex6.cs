/*Design a program that will find the second largest element in an array.*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6
{
    internal class ex6
    {
        static void Main(string[] args)
        {

            //1case


            /* int[] arr = { 1, 23, 31, 42, 5, 6, 7, 81, };

             int largest= int.MinValue;
             int secondLargest = int.MinValue;

            for(int i = 0; i < arr.Length; i++)
             {
                 if (arr[i] > largest)
                 {
                     secondLargest = largest;
                     largest = arr[i];

                 }
                 else if (arr[i]>secondLargest && arr[i] < largest)
                 {
                     secondLargest = arr[i];
                 }
             }


             Console.WriteLine($"The second largest element is {secondLargest}");
         */

            //case 2

            int[] arr = { 1, 23, 31, 42, 5, 6, 7, 81, };

            Array.Sort(arr);         //sorts the array in ascending order

            Array.Reverse(arr);    //reverse the array so that it will be in descending order

            //for(int i=0;i<arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}


            Console.WriteLine($"The second largest element is {arr[1]}");
        }
    }
}
