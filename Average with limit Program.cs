using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L4_3_AverageWithLimit
{
    //a program that asks for numbers until the total exceeds 100
    //and then output the total's average.
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ask the user to enter a series of numbers.");
            Console.WriteLine("When the sum of the numbers is greater that 100 stop.");
            Console.WriteLine("Output the average of the numbers that were entered.");   

            //'input' contains the users input
            //'total' contains the total the user has input
            //'loop' contains the number of times the user has inputted a number
            
            float total = 0;
            float loop = 0;

            while(true)
            {
                Console.WriteLine("User, please input a series of numbers:");
                string userInput = Console.ReadLine();
                float input = float.Parse(userInput);
                total = total + input;
                loop = loop + 1;

                if (total > 100)
                {
                    break;
                }
            }

            Console.WriteLine("The average value is " + total / loop);

        }
    }
}