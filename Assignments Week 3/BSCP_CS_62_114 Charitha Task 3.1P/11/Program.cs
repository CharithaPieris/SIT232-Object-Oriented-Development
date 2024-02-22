//Charitha Pieris BSCP_CS_62_114 

using System;

class Program
{
    // FuncFour method that generates a multiplication table based on the input array
    static int[,] FuncFour(int[] inputArray)
    {
        int size = inputArray.Length;
        int[,] multiplicationTable = new int[size, size];

        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                multiplicationTable[i, j] = inputArray[i] * inputArray[j];
            }
        }

        return multiplicationTable;
    }

    static void Main()
    {
        // Input array
        int[] inputArray = { 5, 10, 20 };

        // Call FuncFour to generate a multiplication table
        int[,] multiplicationTable = FuncFour(inputArray);

        // Print the resulting multiplication table
        Console.WriteLine("Multiplication Table:");
        for (int i = 0; i < inputArray.Length; i++)
        {
            for (int j = 0; j < inputArray.Length; j++)
            {
                Console.Write(multiplicationTable[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}
