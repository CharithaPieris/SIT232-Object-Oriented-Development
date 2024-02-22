
// BSCP|CS|62|114   Charitha Pieris


using System;

namespace DoCasting
{
    class DoCasting
    {
        static void Main(string[] args)
        {
            // Declare and initialize variables for sum and count
            int sum = 17;
            int count = 5;

            // Declare an integer variable called intAverage and calculate the integer average
            int intAverage = sum / count;

            // Print out the integer average, intAverage
            Console.WriteLine("Integer Average: " + intAverage);

            // Declare a double variable called doubleAverage and calculate the double average
            double doubleAverage = sum / count; // This will give incorrect result due to integer division

            // Print out the double average, doubleAverage
            Console.WriteLine("Incorrect Double Average: " + doubleAverage);

            // Cast the sum variable to a double using (double)sum and divide this by count
            doubleAverage = (double)sum / count; // Now, the correct result will be obtained

            // Print out the correct double average, doubleAverage
            Console.WriteLine("Correct Double Average: " + doubleAverage);

            Console.ReadLine();
        }
    }
}
