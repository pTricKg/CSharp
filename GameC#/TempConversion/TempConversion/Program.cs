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
            // Get Fahrenheit from user input
            Console.WriteLine("Please enter Fahrenheit temp for conversion to Celsius: ");
            double userFahrenheit = Console.ReadLine();

            // Conversion for F to C degrees: F - 32 / 9 * 5
            // Conversion for C to F: C * 9 / 5 + 32
        }
    }
}
