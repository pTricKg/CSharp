 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingAssignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            // print to console
            Console.WriteLine("Welcome! This Application will calculate the distance between two points.");

            // get user input and store
            String myString = Console.ReadLine();

            // print user input to console
            Console.WriteLine(myString);

            // calculate minutes and seconds 
            int minutes = 60;
            int hours = 24;
            int seconds = 60;

            int minutesInDay = hours * minutes;
            int secondsInDay = minutesInDay * seconds;

            Console.WriteLine("Minutes in day: " + minutesInDay);
            Console.WriteLine("Seconds in day: " + secondsInDay);

            // keeps console open for user input to cancel
            Console.WriteLine("\nPress any key to exit.");
            Console.ReadKey();
        }
    }
}
