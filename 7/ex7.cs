//Design a program that takes two arrays of numbers and returns a new array.
//This new array should consist of the sums of corresponding elements from the two input arrays.
//For example, if the input arrays are [1, 2, 3] and[4, 5, 6], the output should be [5, 7, 9].



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7
{
    internal class ex7
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 1, 2, 3 };
            int[] arr2 = { 4, 7, 8 };

            int[] resultArr=new int[arr1.Length];

            if(arr1.Length == arr2.Length)
            {
                for(int i=0;i<arr1.Length; i++)
                {
                    resultArr[i] = arr1[i] + arr2[i];
                }

                Console.WriteLine("The result is: ");

                foreach (int i in resultArr)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                Console.WriteLine("The lengths of the arrays are different !");
            }
        }
    }
}
