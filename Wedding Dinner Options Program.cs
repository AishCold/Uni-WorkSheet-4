using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L4_2_WeddingDinner
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wedding Dinner");
            Console.WriteLine("You must choose from one of the following options:");

            Console.WriteLine("1. Chicken");
            Console.WriteLine("2. Fish");
            Console.WriteLine("3. Vegetarian");

            int choice;

            while (true)
            {
                Console.WriteLine("Please enter the number of the option you would like");

                string input = Console.ReadLine();
                choice = int.Parse(input);

                if (choice >= 1 && choice <= 3)
                {
                    break;
                }

               
            }

            Console.WriteLine("You chose option " + choice);
        }
    }
}
