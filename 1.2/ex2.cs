
/*Create a program utilizing an if-else statement to categorize a person's age group. 
 * As an example, the program should label someone as "Child" if their age is under 13, 
 * "Teenager" if between 13 and 19, and "Adult" for ages beyond that.
 */



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    internal class ex2
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your age: ");
            int age=Convert.ToInt32(Console.ReadLine());

            if (age < 13)
            {
                Console.WriteLine("You are a child");
            }
            else if(age>13 && age < 19)
            {
                Console.WriteLine("You are a teenager");
            }
            else
            {
                Console.WriteLine("You are an adult");
            }
        }
    }
}

           
