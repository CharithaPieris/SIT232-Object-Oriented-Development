
// BSCP|CS|62|114   Charitha Pieris

using System;

namespace Repetition
{
    class Repetition
    {
        static void Main()
        {
            int sum = 0;
            double average;
            int upperbound;

            // Prompt the user for the upper bound
            Console.Write("Enter the upper bound: ");
            upperbound = int.Parse(Console.ReadLine()!);

            // Calculate the sum
            for (int number = 1; number <= upperbound; number++)
            {
                sum += number;
            }

            // Calculate the average
            average = (double)sum / upperbound;

            // Display the result
            Console.WriteLine("The sum is " + sum);
            Console.WriteLine("The average is " + average);
        }
    }
}
