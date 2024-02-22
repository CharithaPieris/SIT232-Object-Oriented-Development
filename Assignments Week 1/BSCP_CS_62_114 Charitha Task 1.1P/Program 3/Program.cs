
// BSCP|CS|62|114   Charitha Pieris


using System;

namespace MicrowaveOven
{
    class Microwave
    {
        static void Main()
        {
            Console.WriteLine("Microwave Oven - Heating Time Recommendation");

            // Get the number of items from the user
            Console.Write("Enter the number of items: ");
            int numberOfItems;
            while (!int.TryParse(Console.ReadLine(), out numberOfItems))
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
                Console.Write("Enter the number of items: ");
            }

            // Get the single-item heating time from the user
            Console.Write("Enter the single-item heating time (in seconds): ");
            int singleItemHeatingTime;
            while (!int.TryParse(Console.ReadLine(), out singleItemHeatingTime))
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
                Console.Write("Enter the single-item heating time (in seconds): ");
            }

            // Calculate the recommended heating time based on the number of items
            int recommendedHeatingTime = CalculateRecommendedHeatingTime(numberOfItems, singleItemHeatingTime);

            // Print out the recommended heating time
            Console.WriteLine($"Recommended Heating Time: {recommendedHeatingTime} seconds");
        }

        // Function to calculate the recommended heating time based on the number of items
        static int CalculateRecommendedHeatingTime(int numberOfItems, int singleItemHeatingTime)
        {
            if (numberOfItems == 2)
            {
                // For two items, add 50% to the heating time
                return singleItemHeatingTime + (singleItemHeatingTime / 2);
            }
            else if (numberOfItems == 3)
            {
                // For three items, double the heating time
                return singleItemHeatingTime * 2;
            }
            else if (numberOfItems > 3)
            {
                // Heating more than three items is not recommended
                Console.WriteLine("Heating more than three items at once is not recommended.");
            }

            // For one item or any other invalid input, no modification needed to the heating time
            return singleItemHeatingTime;
        }
    }
}
