//Charitha Pieris BSCP_CS_62_114 

using System;

class Program
{
    // FuncTwo method that accepts and modifies an array of double values
    static void FuncTwo(double[] inputArray)
    {
        // Calculate the average value
        double sum = 0;
        foreach (double value in inputArray)
        {
            sum += value;
        }
        double average = sum / inputArray.Length;

        // Subtract the average value from each element in the array
        for (int i = 0; i < inputArray.Length; i++)
        {
            inputArray[i] -= average;
        }
    }

    static void Main()
    {
        // Create an array of double values
        double[] doubleArray = { 10.5, 15.2, 20.0, 12.8, 18.3 };

        // Print the original values
        Console.WriteLine("Original values:");
        foreach (double value in doubleArray)
        {
            Console.WriteLine(value);
        }

        // Call FuncTwo to compute the average and modify the array
        FuncTwo(doubleArray);

        // Print the modified values
        Console.WriteLine("\nModified values after subtracting the average:");
        foreach (double value in doubleArray)
        {
            Console.WriteLine(value);
        }
    }
}

