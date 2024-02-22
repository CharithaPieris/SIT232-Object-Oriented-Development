// Charitha Pieris BSCP_CS_62_114 

using System;

class Program
{
    static void Main()
    {
        // Declare an array of strings to store student names
        string[] studentNames = new string[6];

        // Request user input for 6 student names
        for (int i = 0; i < studentNames.Length; i++)
        {
            Console.Write("Enter the name of student " + (i + 1) + ": ");
            studentNames[i] = Console.ReadLine();
        }

        // Print all the entered names
        Console.WriteLine("\nThe entered student names are:");
        for (int i = 0; i < studentNames.Length; i++)
        {
            Console.WriteLine("Student " + (i + 1) + ": " + studentNames[i]);
        }
    }
}
