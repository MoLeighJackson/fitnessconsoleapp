using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            int totalMinsExercised = 0;

            bool continueTracking = true;
            while (continueTracking)
            {
                // 1. Prompt user for minutes exercised

                Console.Write("How long have you been exercising? (in minutes) or enter \'QUIT\' to exit program: ");

                // 2. Read user input - create variable for user input, initialize variable

                string userTimeInput = Console.ReadLine();

                if (userTimeInput == "QUIT")
                {
                    continueTracking = false;
                }
                else
                {
                    // 3. Parse the integer entered by user - add mins to exercise total - display mins exercised to the screen

                    int minutes = int.Parse(userTimeInput);
                    totalMinsExercised = totalMinsExercised + minutes;

                    Console.WriteLine("You entered " + userTimeInput + " mins");
                    Console.WriteLine("You have been exercising for " + totalMinsExercised + " mins total");
                }
            }
            Console.WriteLine("Goodbye");
        }
    }
}
