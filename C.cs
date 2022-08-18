using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoutilityTest
{
    public class C
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the upper limit number:");
            var i = Convert.ToInt32(Console.ReadLine());
            // Print multiples of 4 between 0 and 50 inclusive
            for (var num = 0; num <= i; num++)
            {
                if (num % 4 == 0)
                {
                    Console.WriteLine($"{num} is a multiple of 4.");
                }
            }
            // Print odd numbers 0 and 50 inclusive
            for (var num = 0; num <= i; num++)
            {
                if (num % 2 != 0)
                {
                    Console.WriteLine($"{num} is an odd number.");
                }

            }

        }
    }
}
