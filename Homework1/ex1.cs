/*Develop a program using an if-else statement to display varying weather conditions depending on the temperature input.
 For instance, if the temperature falls below 0 degrees, the program should output "Freezing weather."*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    internal class ex1
    {

        static void Main(string[] args)
        {
            Console.Write("Enter the temperature in Celsius: ");
            double temp = Convert.ToDouble(Console.ReadLine());

            if (temp < 0)
            {
                Console.WriteLine("Freezing weather");
            }
            else if(temp>0 && temp < 25)
            {
                Console.WriteLine("Great weather");
            }
            else
            {
                Console.WriteLine("Its too hot");
            }
        }



    }
}
