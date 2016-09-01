using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            // fields for collection
            float originalFahrenheit;
            float calculatedCelsius;
            float calculatedFahrenheit;

            // Get Fahrenheit from user input
            Console.WriteLine("Enter temperature in Fahrenheit: ");
            originalFahrenheit = float.Parse(Console.ReadLine());

            // Conversion for F to C degrees: F - 32 / 9 * 5
            calculatedCelsius = ((originalFahrenheit - 32) / 9) * 5;

            // Conversion for C to F: C * 9 / 5 + 32
            calculatedFahrenheit = ((calculatedCelsius * 9) / 5) + 5;

            // Results
            Console.WriteLine(originalFahrenheit + " degrees Fahrenheit is "
                + calculatedCelsius);
            Console.WriteLine(calculatedCelsius + " degrees Celsius is "
                + calculatedFahrenheit + " degrees Fahrenheit");
        }
    }
}