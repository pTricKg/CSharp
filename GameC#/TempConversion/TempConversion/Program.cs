using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempConversion
{
    class Program
    {
        /// <summary>
        /// Take user input of Fahrenheit and convert to Celsius
        /// and back again.
        /// </summary>
        /// <param name="args">command line args</param>
        static void Main(string[] args)
        {
            // fields for collection
            float originalFahrenheit;
            float calculatedCelsius;
            float calculatedFahrenheit;

            // Get Fahrenheit from user input
            Console.Write("Enter temperature in Fahrenheit: ");
            originalFahrenheit = float.Parse(Console.ReadLine());

            // Conversion for F to C degrees: F - 32 / 9 * 5
            calculatedCelsius = ((originalFahrenheit - 32) / 9) * 5;

            // Conversion for C to F: C * 9 / 5 + 32
            calculatedFahrenheit = ((calculatedCelsius * 9) / 5) + 32;

            // Results
            Console.WriteLine(originalFahrenheit + " degrees Fahrenheit is "
                + calculatedCelsius + " degrees Celsius");
            Console.WriteLine(calculatedCelsius + " degrees Celsius is "
                + calculatedFahrenheit + " degrees Fahrenheit");

            Console.WriteLine("Press a key to close");
            Console.ReadKey();
        }
    }
}