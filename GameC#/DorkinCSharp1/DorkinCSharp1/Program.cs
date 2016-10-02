 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DorkinCSharp1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Your input will print next.\n");
			
            String myString = Console.ReadLine();

            // print user input to console
            Console.WriteLine(myString + "\n");

            // calculate minutes and seconds 
            int minutes = 60;
            int hours = 24;
            int seconds = 60;

            int minutesInDay = hours * minutes;
            int secondsInDay = minutesInDay * seconds;

            Console.WriteLine("Minutes in day: " + minutesInDay);
            Console.WriteLine("\nSeconds in day: " + secondsInDay);

            // get input from user
            Console.WriteLine("\nHow many days do you want to calculate seconds for?\n");
            String myNum = Console.ReadLine();

            // convert input string to int
            int num = Int32.Parse(myNum);
            // calc seconds from user input
            int userSecondsInDay = num * secondsInDay;
            // print user input
            Console.WriteLine(myNum + " is your input.\n");
            Console.WriteLine("There are " + userSecondsInDay + " seconds in " + myNum + " days.\n");

            // calc minutes from user input
            int userMinutesInDay = num * minutesInDay;
            Console.WriteLine("There are " + userMinutesInDay + " minutes in " + myNum + " days.\n");

            // keeps console open for user input to cancel
            Console.WriteLine("\nPress any key to exit.");
            Console.ReadKey();
        }
    }
}
