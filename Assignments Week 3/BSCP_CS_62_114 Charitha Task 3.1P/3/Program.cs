//Charitha Pieris BSCP_CS_62_114 

using System;

class Program
{
    static void Main()
    {
        // Declare and create an integer array with 10 elements
        int[] studentArray = { 87, 68, 94, 100, 83, 78, 85, 91, 76, 87 };

        // Calculate the total marks
        int total = 0;
        for (int i = 0; i < studentArray.Length; i++)
        {
            total += studentArray[i];
        }

        // Print the total marks, number of elements, and average mark
        Console.WriteLine("The total marks for the student is " + total);
        Console.WriteLine("This consists of " + studentArray.Length + " marks");
        Console.WriteLine("Therefore the average mark is " + (total/studentArray.Length));
    }
}
