using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Big, Bad World!");
            String prompt = "I'll repeat what you say.";
            Console.WriteLine(prompt);
            String user = Console.ReadLine();

            Console.WriteLine(user + ", you say!");

            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();

        }
    }
}
