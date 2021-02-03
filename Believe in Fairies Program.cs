
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L4_5_BelieveInFairies
{
    // write a loop here to ask survey participants to enter their age
    // if the age is greater than 10 use the contiue keyword to skip 
    // part of the loop. If not ask the participant if they believe in
    // fairies. End the loop when you have results from 5 participants
    // who are under ten, and output how many believe in fairies
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fairy Belief Survey");
            int participants = 0;  //number of participants that are not over age 10.
            string answer;     //stores the user input from the y or n question.
            int fairies = 0;   // number of participants that believe in fairies
            
            while(participants < 5)
            {
                Console.WriteLine("How old are you?");
                string input = Console.ReadLine();
                int age = int.Parse(input);

                if(age > 10)
                {
                    continue;  //goes back to the beginning of the while loop
                }
                else
                {
                    Console.WriteLine("Do you believe in fairies? y or n");
                    answer = Console.ReadLine();

                    if(answer == "y")
                    {
                        fairies = fairies + 1;
                        participants = participants + 1;
                    }
                    else
                    {
                        participants = participants + 1;
                    }
                }
            }

            Console.WriteLine(fairies + " out of 5 participants believe in fairies.");
           
        }
    }
}