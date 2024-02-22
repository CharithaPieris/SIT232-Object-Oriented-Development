//Charitha Pieris BSCP_CS_62_114 

using System;

class Program
{
    static void Main()
    {
        // Declares an array of type double with 10 elements
        double[] myArray = new double[10];

        // Assign specific values to each element
        myArray[0] = 1.0;
        myArray[1] = 1.1;
        myArray[2] = 1.2;
        myArray[3] = 1.3;
        myArray[4] = 1.4;
        myArray[5] = 1.5;
        myArray[6] = 1.6;
        myArray[7] = 1.7;
        myArray[8] = 1.8;
        myArray[9] = 1.9;

        // Print each element of the array
        for (int i = 0; i < myArray.Length; i++)
        {
            Console.WriteLine("The element at index " + i + " in the array is " + myArray[i]);
        }

        // Attempt to assign a value to index 10 (will result in an error)
        // myArray[10] = 2.0; // Uncommenting this line will cause an IndexOutOfRangeException
    }
}
