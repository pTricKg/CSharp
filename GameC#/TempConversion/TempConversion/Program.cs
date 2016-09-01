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
            float calculatedCelsius:;
            float calculatedFahrenheit;

            // Get Fahrenheit from user input
            Console.WriteLine("Enter temperature in Fahrenheit: ");
            string userFahrenheit = Console.ReadLine();
            
            // Conversion for F to C degrees: F - 32 / 9 * 5
            // Conversion for C to F: C * 9 / 5 + 32
        }
    }
}
