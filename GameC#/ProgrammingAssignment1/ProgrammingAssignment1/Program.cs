using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingAssignment1
{
    /// <summary>
    /// Calculate the distance between two point,
    /// then calculate angle between them.
    /// </summary>
    class Program
    {
        /// <summary>
        /// from user input, calculates distance and angle between two points.
        /// </summary>
        /// <param name="args">command line</param>
        /// <returns>distance and angle</returns>
        static void Main(string[] args)
        {
            // print to console
            Console.WriteLine("Welcome! This Application will calculate the distance between two points and the angle between those points.\n");

            // get user input and store
            Console.WriteLine("Please input X1 coordinate: ");
            float point1X = float.Parse(Console.ReadLine());

            Console.WriteLine("Please input X2 coordinate: ");
            float point2X = float.Parse(Console.ReadLine());

            // print input
            Console.WriteLine("You input " + point1X + " as X1.");
            Console.WriteLine("You input " + point2X + " as X2.\n");


            Console.WriteLine("Please input Y1 coordinate: ");
            float point1Y = float.Parse(Console.ReadLine());

            Console.WriteLine("Please input Y2 coordinate: ");
            float point2Y = float.Parse(Console.ReadLine());

            // print input
            Console.WriteLine("You input " + point1Y + " as Y1.");
            Console.WriteLine("You input " + point2Y + " as Y2.\n");

            // calcualte delta x and delta y
            float deltaX = point2X - point1X;
            float deltaY = point2Y - point1Y;

            Console.WriteLine("Delta X is " + deltaX);
            Console.WriteLine("Delta Y is " + deltaY + "\n");


            // calculate distance between two points(Pythagorean Theorem)
            // a * a + b * b = c * c
            float dist = deltaX * deltaX + deltaY * deltaY;
            double distFin = Math.Sqrt(dist);
            Console.WriteLine("\nDistance between points: " + distFin.ToString("F3"));

            // calculate angle to go from point 1 to point 2(Atan2 math class)
            // convert from radians to degrees
            double radians = Math.Atan2(deltaY, deltaX);
            Console.WriteLine("\n" + radians.ToString("F3") + " is radians.");

            // convert radians to degrees
            double angle = radians * (180 / Math.PI);
            
            // print output to 3 decimal places for distance
            // print output of angle
            Console.WriteLine("\nAngle between points: " + angle.ToString("F3") + " degrees");
            
            // keep window
            Console.WriteLine("\nPress any key to exit.");
            Console.ReadKey();
        }
    }
}
