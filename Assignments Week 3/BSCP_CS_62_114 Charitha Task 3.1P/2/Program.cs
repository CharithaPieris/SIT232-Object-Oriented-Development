//Charitha Pieris BSCP_CS_62_114 

using System;

class Program
{
    static void Main()
    {
        // Declares an array of type integer with 10 elements
        int[] myArray = new int[10];

        // Use a for loop to populate the array with values
        for (int i = 0; i < 10; i++)
        {
            myArray[i] = i;
        }

        // Print each element of the array
        for (int i = 0; i < myArray.Length; i++)
        {
            Console.WriteLine("The element at position " + i + " in the array is " + myArray[i]);
        }
    }
}
