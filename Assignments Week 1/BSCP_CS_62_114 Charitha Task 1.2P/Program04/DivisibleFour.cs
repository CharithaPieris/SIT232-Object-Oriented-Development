
// BSCP|CS|62|114   Charitha Pieris

using System;

namespace DivisibleByFour
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter a number (n): ");
            if (int.TryParse(Console.ReadLine(), out int n))
            {
                Console.WriteLine($"Numbers between 1 and {n} that are divisible by four but not by five:");
                for (int i = 1; i <= n; i++)
                {
                    if (i % 4 == 0 && i % 5 != 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }
    }
}
