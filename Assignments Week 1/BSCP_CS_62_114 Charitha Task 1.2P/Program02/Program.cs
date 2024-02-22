
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

            // Calculate the sum using a do ... while loop
            int number = 1;
            do
            {
                sum += number;
                Console.WriteLine("Current number: " + number + " the sum is " + sum);
                number++;
            } while (number <= upperbound);

            // Calculate the average
            average = (double)sum / upperbound;

            // Display the result
            Console.WriteLine("The sum is " + sum);
            Console.WriteLine("The average is " + average);
        }
    }
}
