//Charitha Pieris BSCP_CS_62_114 

using System;

class Program
{
    static void Main()
    {
        // Create a one-dimensional double data type array of length 10
        double[] doubleArray = new double[10];

        // Create variables for current largest and smallest values
        double currentLargest = 0.0; // Initialize to a minimum possible value
        double currentSmallest = double.MaxValue; // Initialize to a maximum possible value

        // Request user input for 10 double values and store them in the array
        for (int i = 0; i < doubleArray.Length; i++)
        {
            Console.Write("Enter a double value for element " + (i + 1) + ": ");
            if (double.TryParse(Console.ReadLine(), out double inputValue))
            {
                doubleArray[i] = inputValue;

                // Update currentLargest and currentSmallest if necessary
                if (inputValue > currentLargest)
                {
                    currentLargest = inputValue;
                }

                if (inputValue < currentSmallest)
                {
                    currentSmallest = inputValue;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid double value.");
                i--; // Decrement 'i' to re-enter the value for the current element
            }
        }

        // Print all the entered double values
        Console.WriteLine("\nThe entered double values are:");
        for (int i = 0; i < doubleArray.Length; i++)
        {
            Console.WriteLine("Element " + (i + 1) + ": " + doubleArray[i]);
        }

        // Print the largest and smallest values
        Console.WriteLine("\nThe largest value in the array is: " + currentLargest);
        Console.WriteLine("The smallest value in the array is: " + currentSmallest);
    }
}
