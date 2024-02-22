//Charitha Pieris BSCP_CS_62_114 

using System;

class Program
{
    static void Main()
    {
        // Declare and create a 2-dimensional integer array
        int[,] myArray = new int[3, 4]
        {
            { 1, 2, 3, 4 },
            { 1, 1, 1, 1 },
            { 2, 2, 2, 2 }
        };

        // Print each element of the array
        for (int i = 0; i < myArray.GetLength(0); i++)
        {
            for (int j = 0; j < myArray.GetLength(1); j++)
            {
                Console.Write(myArray[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}
