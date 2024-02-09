/*Implement a program that converts temperatures between Fahrenheit and Celsius scales. 
 * Use if-else statements to facilitate the selection process for conversion direction.
 * */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    internal class ex3
    {
        static void Main(string[] args)
        {
            //f->c      (x-32)*5/9

            Console.WriteLine("Choose conversion direction(1 or 2): ");
            Console.WriteLine("1.Celsius->Fahrenheit");
            Console.WriteLine("2.Fahrenheit->Celsius");

            double option=Convert.ToDouble(Console.ReadLine());

            if(option == 1)
            {
                Console.WriteLine("Enter the temperature: ");
                double temp=Convert.ToDouble(Console.ReadLine());
                Console.WriteLine(temp * 9 / 5+32 );
            }
            else if (option == 2)
            {
                Console.WriteLine("Enter the temperature: ");
                double temp = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine((temp-32)*5/9);
            }
            else
            {
                Console.WriteLine("Invalid answer");
            }
            

        }
    }
}
