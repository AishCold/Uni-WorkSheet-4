using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L4_4_PrimeNumber
{
    /*A program where the user inputs a number and the program
     outputs whether that number is prime or not.*/
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prime Number Checker");
            Console.WriteLine("Type in a number");

            //user's input is stored in the string variable 'input'
            //and is int.Parsed to the variable 'number'

            string input = Console.ReadLine();
            int number = int.Parse(input);
            int currentDivisor = number;

            while(currentDivisor > 1)
            {
                currentDivisor = currentDivisor - 1;

                if(number % currentDivisor !=0)
                {
                    continue;
                }
                break;
            }

            if(currentDivisor > 1)
            {
                Console.WriteLine(number + " is not a prime number");
            }
            else
            {
                Console.WriteLine(number + " is a prime number");
            }
        }
    }
}
