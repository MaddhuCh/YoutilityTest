using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoutilityTest
{
    public class A
    {
        static void Main(string[] args)
        {
            // Print multiples of 4 between 0 and 50 inclusive
            for (var num = 0; num <= 50; num++)
            {
                if (num % 4 == 0)
                {
                    Console.WriteLine($"{num} is a multiple of 4.");
                }
            }
            // Print odd numbers 0 and 50 inclusive
            for (var num = 0; num <= 50; num++)
            {
                if (num % 2 == 1)
                {
                    Console.WriteLine($"{num} is an odd number.");
                }

            }
        }
    }
}
