//Charitha Pieris BSCP_CS_62_114 

using System;

class Program
{
    // FuncThree method that converts a 2D array to a 1D array with multiples of 3
    static int[] FuncThree(int[,] inputArray)
    {
        int numRows = inputArray.GetLength(0);
        int numCols = inputArray.GetLength(1);

        // Calculate the maximum possible size of the resulting 1D array
        int maxSize = numRows * numCols;

        // Initialize a 1D array to store multiples of 3
        int[] resultArray = new int[maxSize];
        int resultIndex = 0;

        // Loop through columns
        for (int col = 0; col < numCols; col++)
        {
            // Loop through rows
            for (int row = 0; row < numRows; row++)
            {
                int currentValue = inputArray[row, col];
                if (currentValue % 3 == 0)
                {
                    // If the value is a multiple of 3, add it to the result array
                    resultArray[resultIndex] = currentValue;
                    resultIndex++;
                }
            }
        }

        // Resize the result array to match the actual number of multiples of 3
        Array.Resize(ref resultArray, resultIndex);

        return resultArray;
    }

    static void Main()
    {
        // Create a 2D array of integer values
        int[,] twoDArray = {
            { 3, 6, 9 },
            { 12, 5, 15 },
            { 8, 4, 11 }
        };

        // Call FuncThree to convert the 2D array to a 1D array with multiples of 3
        int[] oneDArray = FuncThree(twoDArray);

        // Print the resulting 1D array
        Console.WriteLine("Resulting 1D array with multiples of 3:");
        foreach (int value in oneDArray)
        {
            Console.WriteLine(value);
        }
    }
}
